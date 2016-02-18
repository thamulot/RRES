using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Reagan.Data
{
    [Serializable()]
    public class Domain : ISerializable 
    {
        private string sujet;
        private string description;
        private string auteurs;
        private List<Rule> regles;
        private List<Fact> faits;
        private List<Term> termes;

        public Domain(){}

        //Deserialization constructor.
        public Domain(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            sujet = (string)info.GetValue("sujet", typeof(string));
            description = (string)info.GetValue("description", typeof(string));
            auteurs = (string)info.GetValue("auteurs", typeof(string));

            regles = (List<Rule>)info.GetValue("regles", typeof(List<Rule>));
            faits = (List<Fact>)info.GetValue("faits", typeof(List<Fact>));
            termes = (List<Term>)info.GetValue("termes", typeof(List<Term>));
        }
        
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("sujet", sujet);
            info.AddValue("description", description);
            info.AddValue("auteurs", auteurs);

            info.AddValue("regles", regles);
            info.AddValue("faits", faits);
            info.AddValue("termes", termes);
        }

        public string Subject
        {
            get { return sujet; }
            set { sujet = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Authors
        {
            get { return auteurs; }
            set { auteurs = value; }
        }

        public List<Rule> Rules
        {
            get {
                if (regles == null)
                {
                    regles = new List<Rule>();
                }
                return regles; 
            }
        }

        public List<Fact> Facts
        {
            get
            {
                if (faits == null)
                {
                    faits = new List<Fact>();
                }
                return faits;
            }
        }

        public List<Term> Terms
        {
            get
            {
                if (termes == null)
                {
                    termes = new List<Term>();
                }
                return termes;
            }
        }

        /// <summary>
        /// Return (unique) each post-condition for each rule
        /// of the current domain
        /// </summary>
        /// <returns></returns>
        public List<Fact> getEachPostConditions()
        {
            List<Fact> value = new List<Fact>();

            foreach (Rule rule in Rules)
            {
                if (!value.Contains(rule.PostCondition))
                {
                    String name = rule.PostCondition.Name;

                    // Verifie si existe pas déja
                    bool existe = false;
                    foreach (Fact fait in value)
                    {
                        if (!rule.PostCondition.Equals(fait) && fait.Name.Equals(name))
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (!existe)
                    {
                        value.Add(rule.PostCondition);
                    }
                }
            }

            return value;
        }
    }
}
