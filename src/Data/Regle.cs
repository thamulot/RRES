using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Reagan.Data
{
    [Serializable()]
    public class Rule : ISerializable 
    {
        List<FactWrapper> wrappers;
        Fact postcon;
        string name;

        public Rule() { }

        //Deserialization constructor.
        public Rule(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the appropriate properties
            name = (string)info.GetValue("name", typeof(string));
            postcon = (Fact)info.GetValue("postcon", typeof(Fact));
            wrappers = (List<FactWrapper>)info.GetValue("wrappers", typeof(List<FactWrapper>));
        }
        
        //Serialization function.
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("name", name);
            info.AddValue("postcon", postcon);
            info.AddValue("wrappers", wrappers);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<FactWrapper> PreConditions
        {
            get
            {
                if (wrappers == null)
                {
                    wrappers = new List<FactWrapper>();
                }
                return wrappers;
            }
        }

        public Fact PostCondition
        {
            get
            {
                return postcon;
            }
            set
            {
                postcon = value;
            } 
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
