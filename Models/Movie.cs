using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9_Tema.Models
{
    public class Movie
    {

        public Guid ID { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string type { get; set; }
    }
}
