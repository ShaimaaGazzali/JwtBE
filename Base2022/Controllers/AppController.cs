﻿using Base2022.BindindModel;
using Base2022.Data.Entities;
using Base2022.DTO;
using Base2022.Models;
using BE_Base2022.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Base2022.Data.Enums;
using BE_Base2022.Models.BindindModel;
using System.Security.Claims;
using BE_Base2022.Repository;

namespace Base2022.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppController : ControllerBase
    {

        private readonly IAppRepo _appRepo;

        public AppController( IAppRepo appRepo)
        {
            _appRepo = appRepo;
    
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("CreateDepartment")]
        public async Task<object> CreateDepartment([FromBody] DepartmentDto model)
        {
            try
            {
                var dept = new Department()
                {
                    Name = model.Name,
                    ManagerId = model.ManagerId,
                };

                 await _appRepo.CreateDepartment(dept);
           
                return await Task.FromResult(new ResponseModel(ResponseCode.OK, "Department have been Registered", null));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new ResponseModel(ResponseCode.Error, ex.Message , null));
            }
            
        }

        [Authorize(Roles = "Manager")]
        [HttpPost("CreateTask")]
        public async Task<object> CreateTask([FromBody] TaskDto model)
        {
            try
            {
                var task = new TaskK()
                {
                    Name = model.Name,
                    Description = model.Description,
                    SubmissionDate = model.SubmissionDate,
                    EmployeeId = model.EmployeeId,
                };

                await _appRepo.CreateTask(task);

                return await Task.FromResult(new ResponseModel(ResponseCode.OK, "Task have been Registered", null));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new ResponseModel(ResponseCode.Error, ex.Message, null));
            }

        }

    }
}
