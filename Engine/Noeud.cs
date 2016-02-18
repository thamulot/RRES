using System;
using System.Collections.Generic;
using System.Text;

namespace Reagan.Engine
{
    public class Noeud
    {
        /* Les operator de comparaison vont deprendre de ce qu'il y aura ici...*/
        Object contenu;  //du data...peut être n'importe quoi!
        Noeud parent;
        bool negation;
        String nom_regle;

        public Noeud(Noeud p, Object dd, bool negation_fait, string nom_de_regle)
        {
            parent = p;
            contenu = dd;
            negation = negation_fait;
            nom_regle = nom_de_regle;
        }

        

        //Getters&Setters
        public String getNomRegle
        {
            get
            {
                return nom_regle;
            }
            set
            {
                nom_regle = value;
            }
        }

        public bool inversion
        {
            get
            {
                return negation;
            }
            set
            {
                negation = value;
            }
        }

        public Object data
        { 
            get
            {
                return contenu; 
            }
            set
            {
                contenu = value;
            }
        }

        public Noeud pere
        {
            get
            {
                return parent;
            }
        }

        //Fonctions de comparaison
        public static bool operator ==(Noeud n1, Noeud n2)
        {
            if ((Object)n1 == null && (Object)n2 == null) return true;
            if ((Object)n1 == null || (Object)n2 == null) return false;

            if (n1.data == n2.data)
                 return true;

            return false;
        }

        public static bool operator !=(Noeud n1, Noeud n2){return !(n1==n2);}

        public override bool Equals(Object o)
        {
            if (o == null)
                return false;

            Noeud n = o as Noeud;
            //Can't be cast to Noeud
            if((Object)n == null)
                return false;

            return (data == n.data);
        }

        public bool Equals(Noeud n)
        {
            return (data == n.data);
        }

        public override int GetHashCode()
        {
            return 1;
        }

    }
}
