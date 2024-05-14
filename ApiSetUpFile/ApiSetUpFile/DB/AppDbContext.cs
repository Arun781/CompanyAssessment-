using ApiSetUpFile.Model;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Storage;

namespace ApiSetUpFile.DB
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<E_Address> E_Address { get; set; }
         
        public void CreatEmp(string e_name, int? e_age, string e_Email, DateTime? e_DateOfBirth, string e_Phone, decimal? e_Salary1, decimal? e_Salary2, ICollection<E_Address> e_Address)
        {
            Database.ExecuteSqlRaw("EXEC CreatEmp @E_Name,@E_age,E_DateOfBirth,E_Email,E_Salary,E_Phone,E_Address",
                new SqlParameter("@E_Name", e_name),
                new SqlParameter("@E_age", e_age),
                new SqlParameter("@E_DateOfBirth", e_DateOfBirth),
                new SqlParameter("@E_Email", e_Email),
                new SqlParameter("@E_Salary", e_Salary1),
                new SqlParameter("@E_Phone", e_Phone),
                new SqlParameter("@E_Address", e_Address));
        }



        public void UpdateEmp(string e_name, int? e_age, string e_Email, DateTime? e_DateOfBirth, string e_Phone, decimal? e_Salary1, decimal? e_Salary2, ICollection<E_Address> e_Address) => Database.ExecuteSqlRaw("EXEC UpdateEmp @E_Name,@E_age,E_DateOfBirth,E_Email,E_Salary,E_Phone,E_Address",
                new SqlParameter("@E_Name", e_name),
                new SqlParameter("@E_age", e_age),
                new SqlParameter("@E_DateOfBirth", e_DateOfBirth),
                new SqlParameter("@E_Email", e_Email),
                new SqlParameter("@E_Salary", e_Salary1),
                new SqlParameter("@E_Phone", e_Phone),
                new SqlParameter("@E_Address", e_Address));
        public void CreatAddres(int DoorNum, int E_Id, string StreetName, String StreetName2, string LandMark, String City, String StateName, String AddressType)
        {
            Database.ExecuteSqlRaw("EXEC  CreatAddres  @E_Name,@E_age,E_DateOfBirth,E_Email,E_Salary,E_Phone,E_Address",
                new SqlParameter("@DoorNum", DoorNum),
                new SqlParameter("@E_Id", E_Id),
                new SqlParameter("@StreetName", StreetName),
                new SqlParameter("@StreetName2", StreetName2),
                new SqlParameter("@LandMark", LandMark),
                new SqlParameter("@City", City),
                new SqlParameter("@StateName", StateName),
                new SqlParameter("@AddressType", AddressType));
        }

        internal void UpdateAddress(int DoorNum, int E_Id, string StreetName, String StreetName2, string LandMark, String City, String StateName, String AddressType) => Database.ExecuteSqlRaw("EXEC UpdateAddress @E_Name,@E_age,E_DateOfBirth,E_Email,E_Salary,E_Phone,E_Address",
                    new SqlParameter("@DoorNum", DoorNum),
                new SqlParameter("@E_Id", E_Id),
                new SqlParameter("@StreetName", StreetName),
                new SqlParameter("@StreetName2", StreetName2),
                new SqlParameter("@LandMark", LandMark),
                new SqlParameter("@City", City),
                new SqlParameter("@StateName", StateName),
                new SqlParameter("@AddressType", AddressType));
        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

    }
}
#endregion
