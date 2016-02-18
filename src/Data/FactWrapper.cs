using System;
using System.Runtime.Serialization;
using System.Collections;

namespace Reagan.Data
{
    [Serializable()]
    public class FactWrapper : ISerializable 
    {
        private Fact fait;
        private bool negation;

        public FactWrapper() { }

        //Deserialization constructor.
        public FactWrapper(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            negation = (bool)info.GetValue("negation", typeof(bool));
            fait = (Fact)info.GetValue("fait", typeof(Fact));
        }
        
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("negation", negation);
            info.AddValue("fait", fait);
        }

        public Fact Fact
        {
            get { return fait; }
            set { fait = value; }
        }

        public bool Negation
        {
            get { return negation; }
            set { negation = value; }
        }

        public string GetFact()
        {
            return this.fait.GetPredicate();
        }

        public override string ToString()
        {
            String value = this.Fact.ToString();
            if (negation)
            {
                value = "(ne pas) " + value;
            }
            return value;
        }
    }
}
