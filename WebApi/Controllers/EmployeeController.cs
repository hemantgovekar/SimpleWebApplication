using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace WebApi.Controllers
{
    //[Authorize]
    public class EmployeeController : ApiController
    {
        // GET api/Employee
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDbEntities employeeDbEntities = new EmployeeDbEntities())
            {
                return employeeDbEntities.Employees.ToList();
            }
        }

        // GET api/Employee/5
        public Employee Get(int id)
        {
            using (EmployeeDbEntities employeeDbEntities = new EmployeeDbEntities())
            {
                return employeeDbEntities.Employees.FirstOrDefault(e => e.Id == id);
            }
        }

        // POST api/Employee
        public void Post([FromBody]Employee value)
        {
            using (EmployeeDbEntities employeeDbEntities = new EmployeeDbEntities())
            {
                employeeDbEntities.Employees.Add(value);
                employeeDbEntities.SaveChanges();
            }
        }

        // PUT api/Employee/5
        public void Put(int id, [FromBody]Employee value)
        {
            using (EmployeeDbEntities employeeDbEntities = new EmployeeDbEntities())
            {
                Employee employee = employeeDbEntities.Employees.FirstOrDefault(e => e.Id == id);
                employee.EName = value.EName;
                employeeDbEntities.SaveChanges();
            }
        }

        // DELETE api/Employee/5
        public void Delete(int id)
        {
            using (EmployeeDbEntities employeeDbEntities = new EmployeeDbEntities())
            {
                Employee employee = employeeDbEntities.Employees.FirstOrDefault(e => e.Id == id);
                employeeDbEntities.Employees.Remove(employee);
                employeeDbEntities.SaveChanges();
            }
        }
    }
}
