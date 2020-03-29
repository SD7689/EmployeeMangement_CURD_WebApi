﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
// Copyright © 2020 Company="BridgeLabz".
// </copyright>
// <creator name="Shivam Dewangan"/>
// --------------------------------------------------------------------------------------------------------------------

namespace EmployeeMangementCurd_Api.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Manager.ManagerInterface;
    using Microsoft.AspNetCore.Mvc;
    using Model;

    /// <summary>
    /// EmployeeController implements ControllerBase.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeManager manager;
        public EmployeeController(IEmployeeManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// AddEmployee Method.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route("AddEmployee")]
        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var result = await this.manager.AddEmployee(employee);
            if (result == 1)
            {
                return this.Ok(employee);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// GetAllEmployees Method.
        /// Routing [Route("GetAllEmployee")]
        /// </summary>
        /// <returns></returns>
        [Route("GetAllEmployee")]
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.manager.GetAllEmployees();
        }

        /// <summary>
        /// UpdateEmployee Method.
        /// Routing [Route("UpdateEmployee")]
        /// </summary>
        /// <param name="employeeChanges"></param>
        /// <returns></returns>
        [Route("UpdateEmployee")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee employeeChanges)
        {
            var result = await this.manager.UpdateEmployee(employeeChanges);
            if (result == 1)
            {
                return this.Ok(employeeChanges);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// DeleteEmployee Method.
        /// Routing [Route("DeleteEmployee")]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteEmployee")]
        public Employee DeleteEmployee(int id)
        {
            return this.manager.DeleteEmployee(id);
        }

        /// <summary>
        /// GetEmployee Method.
        /// Routing  [Route("GetEmployee")]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return this.manager.GetEmployee(id);
        }
    }
}