using System.ComponentModel.DataAnnotations;

namespace ApiSetUpFile.Model
{
    public class Employee
    {
        [Key]
        public int E_Id { get; set; }
        public string E_name { get; set; }
        public Nullable<int> E_age { get; set; }
        public Nullable<System.DateTime> E_DateOfBirth { get; set; }
        public string E_Email { get; set; }
        public decimal E_Salary { get; set; }
        public string E_Phone { get; set; }
        public virtual ICollection<E_Address> E_Address { get; set; }
    }
}
