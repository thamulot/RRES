using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace Reagan.Engine
{

    /* Pour le model expert:
     *   - Le but est le noeud "vide", mais c'est specifie avant l'appel
     *   - En C# les listes on la propriete reverse, find, add, remove, etc :)
     * */

    public /*abstract*/ class AEtoile
    {
        private static Logger logger = LogManager.GetCurrentClassLogger(); 

        public static int MAXMIMUM_EMPIRIQUE = 3000; //on reste ça ici...devra jamais bucke...

        public static bool rechercheDansGraphe(Noeud noeudInitial, NoeudList but, 
            Successeurs successeur)
        {
            // Declare des noeuds
            NoeudList n1;
            NoeudList n2;
            NoeudList n3;
         
            // Declare deux listes
            List<NoeudList> open = new List<NoeudList>();
            List<NoeudList> closed = new List<NoeudList>();

            // Insere noeudInitial dans open
            NoeudList nInit = new NoeudList(noeudInitial);
            open.Add(nInit);

            bool resultat = false;
            int nbrTours = 0;

            while (nbrTours < MAXMIMUM_EMPIRIQUE)
            {	// La condition de sortie (exit) est determinee dans la boucle
                nbrTours++;

                // Si open est vide, sorts de la boucle avec echec
                if (open.Count <= 0)
                {
                    break;
                }

                // Noeud au debut de open
                n1 = open[0];

                // Enleve n1 de open et ajoute le dans closed
                open.Remove(n1);

                closed.Add(n1);

                // Si n1 est le but, sorts de la boucle avec success en retournant le chemin
                if (n1.Count == 0)//Le but est la liste vide
                {
                    resultat = true;
                    break;
                }

                // Pour chaque successeur n2 de n1
                List<NoeudList> enfants = successeur.getSuccesseurs(n1);

                if (enfants.Count > 0)
                {
                    for (int i = 0; i < enfants.Count; ++i)
                    {
                        n2 = (NoeudList)enfants[i];

                        // Verification des cas egalitaires
                        n3 = obtenirNoeudEquivalent(closed, n2);
                        if (n3 != null)
                        {
                            // Avec f(n3) <= f(n2)
                            if (n3.getCout() <= n2.getCout())
                            {
                                // Comme n3 est meilleur mais deja traite, on n'y touche pas et on dedouble pas
                            }
                            else
                            {
                                // On a trouve meilleur, on supprime de closed et ajoute n2 dans open
                                closed.Remove(n3);
                                open.Insert(0,n2);
                            }
                        }
                        else
                        {
                            n3 = obtenirNoeudEquivalent(open, n2);
                            if (n3 != null)
                            {
                                // Avec f(n3) <= f(n2)
                                if (n3.getCout() <= n2.getCout())
                                {
                                    // Comme n3 est meilleur et en "attente" dans open, on y touche pas et on dedouble pas
                                }
                                else
                                {
                                    // On vient de trouver mieux... on supprime n3
                                    open.Remove(n3);
                                    open.Insert(0, n2);
                                }
                            }
                            else
                            {
                                // Rien d'equivalent nulle part, nouvelle entree
                                open.Insert(0, n2);
                            }
                        }
                    }

                    //Appliquer l'UPG
                    successeur.propagationUPG(open);

                }//fin enfant != null

            } //while

            //si faut ça fait de la job pour a rien...mais bon
            successeur.propagationUPG(noeudInitial);

            return resultat;
        }

        /**
         */
        private static NoeudList obtenirNoeudEquivalent(List < NoeudList> liste, NoeudList n2)
        {
            if (liste.Count <= 0)
                return null;

            return liste.Find(delegate(NoeudList n) { return n == n2; });
        }
    }

}