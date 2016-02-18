using System;
using System.Runtime.Serialization;

namespace Reagan.Data
{
    [Serializable()]
    public class Term : ISerializable 
    {
        private string value;
        private string termType;

        public Term() { }

        //Deserialization constructor.
        public Term(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            value = (string)info.GetValue("value", typeof(string));
            termType = (string)info.GetValue("termType", typeof(string));
        }
        
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("value", value);
            info.AddValue("termType", termType);
        }

        public string Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string TermType
        {
            get { return termType; }
            set { termType = value; }
        }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
