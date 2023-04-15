using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AboutTop
    {
        [Key] //ID to be primary key
        public int AboutTopID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Subtitle { get; set; }
        public string SubDescription { get; set; }
        public bool Status { get; set; }
    }
}
