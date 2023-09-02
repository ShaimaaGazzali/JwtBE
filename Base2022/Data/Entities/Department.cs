using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Base2022.Data.Entities
{
    public class Department 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id   { get; set; }
        public string Name { get; set; }

        public string ManagerId   { get; set; }
        public AppUser Manager { get; set; }
    }
}
