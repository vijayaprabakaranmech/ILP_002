using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ILP_002_Anglar_VI393317_VijayaprabakaranS.Models;

namespace ILP_002_Anglar_VI393317_VijayaprabakaranS.Controllers
{
    public class EmployeesController : ApiController
    {
        private AspContext db = new AspContext();

        [Route("api/Employees/{emailId}")]
        [HttpGet]
        [ResponseType(typeof(Supervisor))]
        public IQueryable<Supervisor> GetSupervisor(string emailId)
        {
            IQueryable<Supervisor> supervisors = db.supervisors.Where(s => s.Id.Equals(
                db.employees.Where(e => e.EmailID.Equals(emailId)).Select(e => e.SupervisorID).FirstOrDefault()));
            return supervisors;
        }

        [Route("api/Employees/Get/{emailId}")]
        [HttpGet]
        [ResponseType(typeof(Employee))]
        public IQueryable<Employee> GetEmployee(string emailId)
        {
            IQueryable<Employee> employees = db.employees.Where(e => e.EmailID.Equals(emailId));
            return employees;
        }

        [Route("api/Employees/GetEmployees/{supervisorId}")]
        [HttpGet]
        [ResponseType(typeof(Employee))]
        public IQueryable<Employee> GetEmployeeList(int supervisorId)
        {
            IQueryable<Employee> employees = db.employees.Where(e => e.SupervisorID.Equals(supervisorId));
            return employees;
        }

        // GET: api/Employees
        public IQueryable<Employee> Getemployees()
        {
            return db.employees;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult GetEmployee(int id)
        {
            Employee employee = db.employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Employees
        [ResponseType(typeof(Employee))]
        public IHttpActionResult PostEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.employees.Add(employee);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        [ResponseType(typeof(Employee))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            Employee employee = db.employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.employees.Remove(employee);
            db.SaveChanges();

            return Ok(employee);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(int id)
        {
            return db.employees.Count(e => e.Id == id) > 0;
        }
    }
}