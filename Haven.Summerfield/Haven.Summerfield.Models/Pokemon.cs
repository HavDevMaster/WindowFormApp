using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haven.Summerfield.Models

{
    public class Pokemon
    {
        //This class holds the data that will be gathering, validating, and converted to be be sent to database.

        public int PokedexId { get; set; }
        public string Name { get; set; } 
        public string Type { get; set; }
        public int Level { get; set; }
        public string Nature { get; set; }
        public string Gender { get; set; }
        public string Message { get; set; }



    }
}
