using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Base2022.DTO
{
    public class DepartmentDto 
    {
        public int? Id   { get; set; }
        public string Name { get; set; }
        public string ManagerId   { get; set; }
        public string Manager { get; set; }
    }
}
