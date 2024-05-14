using ApiSetUpFile.DB;
using ApiSetUpFile.Model;
using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;

namespace ApiSetUpFile.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly AppDbContext _db;
        public EmployeeController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost("CreatADD")]
        public IActionResult CreatAdd([FromQuery] E_Address address)
        {
            try
            {
                _db.CreatAddres(address.DoorNum, address.E_Id, address.StreetName, address.StreetName2, address.LandMark, address.City, address.StateName, address.AddressType);
                return Ok("address Created Succefully"+ ("action2"));
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An Error occured");
            }

        }

        [HttpGet("GetAllADD")]
        public IActionResult Getall()
        {
            var empl = _db.E_Address.ToList();
            return Ok(empl);
        }
        [HttpGet("{GetByIdAdd:int}")]
        public IActionResult GetById(int id)
        {
            E_Address emp = _db.E_Address.Find(id);
            return Ok(emp == null);
        }

        [HttpPut("{UpdateAddress}")]
        public IActionResult UpdateAddress(E_Address address)
        {
            try
            {
                _db.UpdateAddress(address.DoorNum, address.E_Id, address.StreetName, address.StreetName2, address.LandMark, address.City, address.StateName, address.AddressType);
                return Ok("Employee Created Succefully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An Error occured");
            }
        }

        [HttpDelete("{DeleteAddress}")]
        public IActionResult DeleteAddress(int id)
        {
            var address = _db.E_Address.Find(id);
            _db.E_Address.Remove(address);
            _db.SaveChanges();
            return Ok("Employee Id Deleted Succefully");
        }

        
        


        [HttpGet("GetAllEmp")]
        public IActionResult GetallEmploye()
        {
            var empl = _db.Employee.ToList();
            return Ok(empl);
        }

        [HttpGet("{GetEmpByID:int}")]
        public IActionResult GetEmployeeByID(int Eid, int id)
        {
            Employee emp = _db.Employee.Find(id);
            return Ok(emp == null);
        }

        [HttpPost("CreatEmp")]
        public IActionResult CreatEmp(Employee employee)
        {
            try
            {
                _db.CreatEmp(employee.E_name, employee.E_age, employee.E_Email, employee.E_DateOfBirth, employee.E_Phone,
                    employee.E_Salary, employee.E_Salary, employee.E_Address);
                return Ok("Employee Created Succefully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An Error occured");
            }

        }

        [HttpPut("{UpdateEmp}")]
        public IActionResult UpdateEmp(Employee employee)
        {
            try
            {
                _db.UpdateEmp(employee.E_name, employee.E_age, employee.E_Email, employee.E_DateOfBirth, employee.E_Phone,
                    employee.E_Salary, employee.E_Salary, employee.E_Address);
                return Ok("Employee Created Succefully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An Error occured");
            }
        }

        [HttpDelete("{DeleteEmployee}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _db.Employee.Find(id);
            _db.Employee.Remove(employee);
            _db.SaveChanges();
            return Ok("Employee Id Deleted Succefully");
        }



    }
}
