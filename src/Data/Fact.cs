using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Reagan.Data
{
    [Serializable()]
    public class Fact : ISerializable 
    {
        private string name;
        private string comments;
        private string question;
        private Term term;

        public Fact() { }

        //Deserialization constructor.
        public Fact(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            name = (string)info.GetValue("name", typeof(string));
            comments = (string)info.GetValue("comments", typeof(string));
            question = (string)info.GetValue("question", typeof(string));
            term = (Term)info.GetValue("term", typeof(Term));
        }
        
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("name", name);
            info.AddValue("comments", comments);
            info.AddValue("question", question);
            info.AddValue("term", term);
        }


        public string Name
        {
            get { return name;}
            set { name = value;}
        }

        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string GetPredicate()
        {
            return "(" + this.Name + " " + this.Term + ")";
        }

        public Term Term
        {
            get { return term; }
            set { term = value; }
        }

        public override string ToString()
        {
            return this.Name + "(" + this.Term + ")";
        }
    }
}