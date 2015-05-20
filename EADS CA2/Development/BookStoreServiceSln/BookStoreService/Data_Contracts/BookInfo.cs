using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BookStoreService.Data_Contracts
{
    [DataContract(Namespace = "www.davidkelly.com")]
    public class BookInfo
    {
        [DataMember]
        public string Author { get; set; }

        [DataMember]
        public string BookTitle { get; set; }

        [DataMember]
        public string Publisher { get; set; }

    }
}