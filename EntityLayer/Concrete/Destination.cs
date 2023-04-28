using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{   
    public class Destination    //Places to go in home page 
    {   
        [Key] //ID to be primary key
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string Time { get; set; }
        public double Price { get; set; } 
        public string Image { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }
        public bool Status { get; set; } 
        public string CoverImage { get; set; }
        public string DetailsTop { get; set; }
        public string DetailsLower { get; set; }
        public string Image2 { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
