using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Proyect_CSharp
{
    [Serializable]
    class Persona
    {
        public string name { get; set; }
        public string console { get; set; }
        public int age { get; set; }
        public DateTime date { get; set; }
        public string comment { get; set; }
        public double price { get; set; }
        public string code { get; set; }
    }
}
