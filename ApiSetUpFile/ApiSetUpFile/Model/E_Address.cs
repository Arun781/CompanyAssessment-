using System.ComponentModel.DataAnnotations;

namespace ApiSetUpFile.Model
{
    public class E_Address
    {
        [Key]
        public int DoorNum { get; set; }
        public int E_Id { get; set; }
        public string StreetName { get; set; }
        public string StreetName2 { get; set; }
        public string LandMark { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string AddressType { get; set; }
    }
}
