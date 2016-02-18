using System;
using System.Collections.Generic;
using System.Text;

namespace Reagan.Engine 
{
    public class NoeudList : List<Noeud>
    {
        Noeud parent;
        int cout;
        String nom_etat;

        public NoeudList()
        {

        }

        public NoeudList(String nom, Noeud p, int iCout)
        {
            nom_etat= nom;
            parent= p;
            cout= iCout;
        }

        public NoeudList(Noeud first)
        {
            nom_etat = "racine";
            parent = null;
            cout = 0;
            base.Add(first);
        }

        //Getters&Setters
        public Noeud getParent(){return parent;}
        public int getCout() { return cout; }

        //Fonctions de comparaison
        public static bool operator ==(NoeudList n1, NoeudList n2)
        {
            bool test= true;

            if ((Object)n1 == null && (Object)n2 == null) return true;
            if ((Object)n1 == null || (Object)n2 == null) return false;

            if (n2.Count != n1.Count) return false;

            for(int i=0; i< n1.Count; ++i)
            {
                if(n1[i] != n2[i])
                {
                    test= false;
                    break; //c'est faut vaut pas la peine de continue a boucle
                }
            }

            return test;
        }

        public static bool operator !=(NoeudList n1, NoeudList n2){return !(n1==n2);}

        public override bool Equals(Object o)
        {
            if (o == null)
                return false;

            NoeudList n = o as NoeudList;
            //Can't be cast to Noeud
            if((Object)n == null)
                return false;

            return (this == n);
        }

        public bool Equals(NoeudList n)
        {
            if ((Object)n == null) return false; 

            return (parent == n.parent);
        }

        public override int GetHashCode()
        {
            return 1;
        }

    }
}
