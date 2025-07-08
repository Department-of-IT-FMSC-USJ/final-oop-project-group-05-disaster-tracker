using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace DisasterMgtSystemAPI.Models.Entities

{
    [Table("gn_officers")]
    public class GnOfficer
    {
        [Key]

        private int gnId;
        private int userId;
        private string Name;
        private string contactNo;
        private string district;
        private string gNDivision;

        public int GnId { get => gnId; set => gnId = value; }
        public int GNId { get; internal set; }
        public int UserId { get => userId; set => userId = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string District { get => district; set => district = value; }
        public string GNDivision { get => gNDivision; set => gNDivision = value; }
    }
}
