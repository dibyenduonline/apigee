using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace DemoApi001
{
    /*
    [Serializable]
    [DataContract]*/
    public class APIRequest
    {
    //    [DataMember]
        public string method1 { get; set; }
      //  [DataMember]
        public string dataDetails { get; set; }
    }
}
