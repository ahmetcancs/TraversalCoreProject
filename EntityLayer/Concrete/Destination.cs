using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{   
    public class Destination    //Places to go in home page 
    {
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string Time { get; set; }//how many stays there
        public string Image { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }//How many person
        public bool Status { get; set; } //Is holiday active?
    }
}
