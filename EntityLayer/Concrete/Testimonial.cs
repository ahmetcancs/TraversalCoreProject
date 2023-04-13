using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public int Client { get; set; }
        public int Comment   { get; set; }
        public int Image { get; set; }
        public bool Status { get; set; }


    }
}
