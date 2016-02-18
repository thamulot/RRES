using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Reagan.Engine
{
    /* Classe Objet successeur, fait la grande partie du travail dans l'engin du SE
     * 
     * Doit être cree comme un objet avec new et le constructeur.
     * 
     * 
     */

    public class Successeurs
    {
        struct UPG
        {
            public String nomRegle;
            public String[] upg;
        
        }

        //member
        // stream pour envoye les questions/reponse de l'engin
        TraceData trace;
        List<UPG> upg;

        Noeud faitCourant;
        bool reponseOUI;

        public QuestionsForm qf = new QuestionsForm();

        // Liste des faits
        List<Reagan.Data.Fact> facts;
        // Liste des regles 
        List<Reagan.Data.Rule> rules;

        List<Reagan.Data.Fact> faitVrai;
        List<Reagan.Data.Fact> faitFaux;
        
        public Successeurs(List<Reagan.Data.Fact> listeFaits, List<Reagan.Data.Rule> listeRules)
        {
            Init();

            //initialisation des listes de faits et des regles
            facts = listeFaits;
            rules = listeRules;

            /*initialisation des streams de la classe*/
        }

        public void Init()
        {
            //La trace des "deplacements"
            trace = new TraceData();

            faitVrai = new List<Reagan.Data.Fact>();
            faitFaux = new List<Reagan.Data.Fact>();

            faitCourant = null;

            upg = new List<UPG>();
        }

        public List<NoeudList> getSuccesseurs(NoeudList parent)
        {
            /* - Chercher les precondition repondant a la post condition parent
             * - faire une belle list de
             * - setter le parent de chaque noeud
             * - gestion des questions
             * - ajout d'un predicat precondition dans la table des fait si reponse a "oui/non" est oui
             * - Si reponse est "how": afficher la trace courante complete
             * - Si reponse est "why": afficher la trace de la regle courante
             * - Si reponse est "stop": on arrete et affiche ou on est rendu.
             * */

            if (rules.Count <= 0) return null; //error!

            List<NoeudList> tousLesEnfants= new List<NoeudList>();
            Noeud papa = parent[0]; //le premier est tester

            //On copie le reste, on commence a 1 pour enleve papa
            NoeudList groupe= new NoeudList();
            for(int k=1; k < parent.Count; ++k)
            {
                groupe.Add(parent[k]);
            }
            faitCourant = papa; //va peut-etre etre mis dans la liste des faits donc on sauvegarde

            for(int i=0; i < rules.Count;++i)
            {
                String[] resultats = Unify.unification(((Reagan.Data.Fact)papa.data).GetPredicate(), rules[i].PostCondition.GetPredicate());

                if ( resultats.Length == 0 || resultats[0] != "-1") //unification a fonctionne
                {
                    for (int j = 0; j < rules[i].PreConditions.Count; ++j)
                    {
                        //ajoute de l'enfant precon
                        groupe.Insert(0, new Noeud(papa, rules[i].PreConditions[j].Fact, rules[i].PreConditions[j].Negation, rules[i].Name));
                    }

                    UPG newUPG;
                    newUPG.upg= resultats;
                    newUPG.nomRegle = rules[i].Name;
                    upg.Add(newUPG);

                    //......
                    tousLesEnfants.Add(groupe);
                    groupe = new NoeudList();
                }
            }

            trace.CreateNode(faitCourant);

            //Si on a des successeurs good...faut pas oublie d'appeller le UPG plus loin.
            if (tousLesEnfants.Count > 0)
            {
                string regleEnfant = "Règles enfants= ";
                for (int i = 0; i < tousLesEnfants.Count; ++i)
                {
                    regleEnfant += "\n                      " + tousLesEnfants[i][0].getNomRegle;
                }

                trace.UpdateNode(faitCourant, regleEnfant);
                return tousLesEnfants;
            }

            bool dejaFaitOUI = faitVrai.Contains(((Reagan.Data.Fact)faitCourant.data));
            bool dejaFaitNON = faitFaux.Contains(((Reagan.Data.Fact)faitCourant.data));

            //Si unification ne marche pas on pose les questions...
            if (!dejaFaitOUI && !dejaFaitNON)
            {
                gestionDemande();

                //cas oui et pas de negation 
                if (reponseOUI && !faitCourant.inversion)
                {
                    tousLesEnfants.Add(groupe);
                    trace.UpdateNode(faitCourant, "oui");
                    faitVrai.Add(((Reagan.Data.Fact)faitCourant.data));
                }
                //ou cas non et negation
                else if (!reponseOUI && faitCourant.inversion)
                {
                    tousLesEnfants.Add(groupe);
                    trace.UpdateNode(faitCourant, "oui");
                    //le cas pas inverse est faux...
                    faitFaux.Add(((Reagan.Data.Fact)faitCourant.data));
                }
                // autre cas NON
                else if (!reponseOUI && !faitCourant.inversion)
                {
                    //Comme on rejette la regle on passe a la suivante
                    trace.UpdateNode(faitCourant, "non");
                    faitFaux.Add(((Reagan.Data.Fact)faitCourant.data));
                }
                else if (reponseOUI && faitCourant.inversion)
                {
                    //Comme on rejette la regle on passe a la suivante
                    trace.UpdateNode(faitCourant, "non");
                    faitVrai.Add(((Reagan.Data.Fact)faitCourant.data));
                }   
            }
            // cas où on à déjà donnée un réponse aux faits
            else if (dejaFaitOUI && !faitCourant.inversion || dejaFaitNON && faitCourant.inversion)
            {
                tousLesEnfants.Add(groupe);
                trace.UpdateNode(faitCourant, "oui");
            }
            else
            {
                trace.UpdateNode(faitCourant, "non");
            }

            reponseOUI = false;

            return tousLesEnfants; //reponse non!, c'est null, noeud partie en enfer... (closed)
        }

        public string getCommentaireUnification()
        {
            int i = 0;
            for (; i < rules.Count; ++i)
            {
                if (rules[i].Name == faitCourant.getNomRegle)
                    break;
            }

            return rules[i].PostCondition.Comments;
        }

        public void propagationUPG(List<NoeudList> open)
        {
            //On propage UPG dans la liste open...
            //Ca va etre le fun!
            for (int i = 0; i < open.Count; ++i)
            {
                NoeudList n = open[i];
                for (int j = 0; j < n.Count; ++j)
                {
                    //acceder la string interne de chaque noeud!
                    string unification;
                    for (int k = 0; k < upg.Count; ++k)
                        if (Unify.premierElementDe(upg[k].upg[0]) == ((Reagan.Data.Fact)n[j].data).Term.Value)
                        {
                            unification = Unify.resteDe(upg[k].upg[0]);
                            ((Reagan.Data.Fact)n[j].data).Term.Value = unification.Substring(1, unification.Length - 2);
                        }
                }
            }
        }

        public void propagationUPG(Noeud init)
        {
            string unification;
            //Unification finale du noeud initial et de la constante
            for(int i=0; i < upg.Count ; ++i)
            {
                if(upg[i].nomRegle == faitCourant.getNomRegle)
                {
                    String value = Unify.applique(upg[i].upg, ((Reagan.Data.Fact)init.data).GetPredicate());
                    unification = Unify.resteDe(value);
                    ((Reagan.Data.Fact)init.data).Term.Value = unification.Substring(1, unification.Length - 2);
                    break;
                }
            }
        }

        private void gestionDemande()
        {
            /*Posons la question*/
            string question = ((Reagan.Data.Fact)faitCourant.data).Question;
            //Prendre en contre faitCourant.inversion lors de la question...

            qf.setQuestion(question, true, true);
            qf.ShowDialog();

            gestionReponse(qf.getChoix());
        }

        public void afficherResultat(String reponse)
        {
              qf.setTraceResulat(reponse);
              qf.ShowDialog();
              GestionAfficherResultat(reponse);
        }

        public void GestionAfficherResultat(String reponse)
        {
            if (qf.getChoix() == "why")
            {
                qf.setTraceResulat("Pourquoi :\n " + trace.getTrace(faitCourant) + "\n");
                qf.ShowDialog();
            }
            else if (qf.getChoix() == "how")
            {
                qf.setTraceResulat("Comment :\n " + trace.getAllTrace() + "\n");
                qf.ShowDialog();
            }
            
            if (qf.getChoix() != "close")
                GestionAfficherResultat(reponse);

        }

        private void gestionReponse(String reponse)
        {
            //Attente des resultats
            if (reponse == "yes" ) gestionReponseYes();
            else if (reponse == "no") gestionReponseNo();
            else if (reponse == "why") gestionReponseWhy();
            else if (reponse == "how") gestionReponseHow();
        }

        private void gestionReponseYes()
        {
            //On mets le "fait" courant dans la liste des faits
            reponseOUI = true;
        }

        private void gestionReponseNo()
        {
            //On drop le fait 'en enfer'
            //Donc on fait rien, sauf un update de la trace
        }

        private void gestionReponseWhy()
        {
            //Affichage du raisonnement - courant + ce qui est traite du parent -
            qf.setQuestion("Pourquoi :\n " + trace.getTrace(faitCourant) + "\n", false, false);
            qf.ShowDialog();
            //Reaffichons la question
            gestionDemande();
        }

        private void gestionReponseHow()
        {
            //Affichage de la trace
            qf.setQuestion("Comment :\n " + trace.getAllTrace() + "\n", false, false);
            qf.ShowDialog();
            //Reaffichons la question
            gestionDemande();
        }
    }
}
