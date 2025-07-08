using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Disaster_demo.Models.Entities
{
    [Table("gn_officers")]
    public class GN_Officer : Users
    {
        //[Key]
        public int gn_id { get; set; }
        public string name { get; set; }
        public string contact_no { get; set; }
        public string district { get; set; }
        public string gn_division { get; set; }
        
        
    }
}
