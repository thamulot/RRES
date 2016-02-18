using System;
using System.Collections.Generic;
using System.Text;

namespace Reagan.Engine
{
    public class contenu
    {
        public Noeud fait;
        public contenu parent;
        public string reponse;
        public List<contenu> enfants;
    }

    public class TraceData
    {
        List<contenu> trace;

        public void CreateNode(Noeud element)
        {
            contenu toAdd= new contenu();
            toAdd.fait = element;
            toAdd.parent = FindParent(element);
            toAdd.enfants= new List<contenu>();
            toAdd.reponse = "courante";

            if (toAdd.parent != null)
                toAdd.parent.enfants.Add(toAdd);

            if(trace == null)
            {
                //la racine
                trace= new List<contenu>();
               
            }

            trace.Add(toAdd);
        }

        public void UpdateNode(Noeud element, string lecture)
        {
            if (element != null)
            {
                contenu node = getNode(element);

                if(node != null)
                    node.reponse = lecture;
            }
        }

        public contenu getNode(Noeud element)
        {
            contenu toFind= new contenu();

            if (element == null){return null;}

            toFind = trace.Find(delegate(contenu ob) { return ob.fait.getNomRegle == element.getNomRegle && ob.fait.data == element.data; });

            return toFind;
        }

        public contenu getParent(Noeud element)
        {
            contenu toFind = new contenu();

            if (element == null) { return null; }

            toFind = getNode(element);

            return toFind.parent;
        }

        public contenu FindParent(Noeud element)
        {
           contenu toFind = getNode(element.pere);

           return toFind;
        }

        public string getTrace(Noeud element)
        {
            String reponse = "";
            String rule = element.getNomRegle;
            contenu node;

            if (element.pere != null)
            {
                reponse= "Règle parente= " + element.pere.getNomRegle + "\n";
        //        reponse += Ligne(getNode(element.pere));  // affiche les enfants...
            }

            reponse+= rule + "\n";

            for (int i = 0; i < trace.Count; ++i)
            {
                node = trace[i];

                if(node.fait.getNomRegle == rule)
                    reponse += Ligne(node);
            }

            return reponse;
        }

        public string getAllTrace()
        {
            String reponse= "";
            contenu node;
            string lastRule = "";

            //IMplique que le nom de la regle est un chiffre...
            trace.Sort(delegate(contenu p1, contenu p2) {
                string test = p1.fait.getNomRegle.Substring(p1.fait.getNomRegle.Length-1);
                string test2 = p2.fait.getNomRegle.Substring(p2.fait.getNomRegle.Length - 1);
                if (test == "e") test = "0";
                if (test2 == "e") test2 = "0";
                return int.Parse(test).CompareTo(int.Parse(test2)); 
            });

            for (int i = 0; i < trace.Count; ++i)
            {
                node= trace[i];

                if (!node.fait.getNomRegle.Equals(lastRule))
                {
                    reponse+= node.fait.getNomRegle + "\n";
                    lastRule = node.fait.getNomRegle;
                }

                reponse += Ligne(node);
            }

            return reponse;
        }


        public string Ligne(contenu node)
        {
            string reponse = "";

            reponse += "-----" + Negation(node.fait) + ((Reagan.Data.Fact)node.fait.data).Comments + ": " + node.reponse + "\n";

            return reponse;
        }
        public string Negation(Noeud fait)
        {
            if (fait.inversion)
                return "inversion de ";

            return "";
        }

    }
}
