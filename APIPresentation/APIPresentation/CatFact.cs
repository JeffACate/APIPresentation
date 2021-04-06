using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPresentation
{

    public class CatFact
    {
        public Status status { get; set; }
        public string type { get; set; }
        public bool deleted { get; set; }
        public string _id { get; set; }
        public string source { get; set; }
        public string user { get; set; }
        public string text { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public int __v { get; set; }
        public bool used { get; set; }
    }

    public class Status
    {
        //public bool verified { get; set; }
        public int sentCount { get; set; }
    }

}
