#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xxXXXxxx.xxXXXxxx.ru.Context;
using xxXXXxxx.xxXXXxxx.ru.Models;
using xxXXXxxx.xxXXXxxx.ru.Helpers;

namespace xxXXXxxx.xxXXXxxx.ru.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {      
        private readonly SupportWebContext _context;

        public EmployeeController(SupportWebContext context)
        {          
            _context = context;
        }

        // GET: api/Employee/Filter
        [HttpGet("Filter")] 
        public async Task<IActionResult> GetEmployeesByFilterAsync([FromBody]RequestEmployeeModel model)
        {
            try
            {
                var barSize = (int)model.limit;
                var substring = model.substring;
                if (string.IsNullOrEmpty(substring) || substring.Length < 3)
                {
                    return Ok(Array.Empty<EmployeeDto>());
                }

                var persons = await _context.Employees
                    .AsNoTracking()
                    .Include(x => x.Orgs)
                    .Where(x => x.EmpName.Contains(substring))
                    .Take(barSize)
                    .ToListAsync();


                var dtosEmployeeList = new List<EmployeeDto>(persons.Count);
                foreach (var person in persons)
                {
                    var org = await _context.Orgs
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.OrgId == person.EmpOrg);
                    var employeeDTO = new EmployeeDto()
                    {
                        Id = person.EmpId,
                        LastName = person.EmpLname,
                        FirsName = person.EmpFname,
                        MiddleName = person.EmpMname,                      
                        Title = person.EmpTitle ?? null,
                        OrgName = org is not null ? org.OrgName : null
                    };
                    dtosEmployeeList.Add(employeeDTO);

                }


                return Ok(dtosEmployeeList);
            }
            catch(Exception ex)
            {
                return Content(ex.ToString());
            }
           
        }

        // GET: api/Employee/Order
        [HttpGet("Order")]
        public async Task<IActionResult> GetEmployeesByListAsync([FromBody]RequestEmployeeModel model)
        {
            try {
                var persons = await _context.Employees.
                               AsNoTracking().
                               Where(x => model.guidList.Contains(x.EmpId)).
                               Select(y => y).
                               ToListAsync();
                var dtosEmployeeList = new List<EmployeeDto>(persons.Count);

                foreach (var person in persons)
                {
                    var org = await _context.Orgs
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.OrgId == person.EmpOrg);
                    var orgMotherName = (EmployeeHelper.GetMotherOrgAsync(_context, person)).Result;
                    dtosEmployeeList.Add(new EmployeeDto()
                    {
                        Id = person.EmpId,
                        LastName = person.EmpLname,
                        FirsName = person.EmpFname,
                        MiddleName = person.EmpMname,
                        Title = person.EmpTitle ?? null,
                        OrgName = org is not null ? org.OrgName : null,
                        EmpMotherOrgName = orgMotherName is not null ? orgMotherName : null
                    });
                }

                return Ok(dtosEmployeeList);
            } 
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
            
        }


    }
}
