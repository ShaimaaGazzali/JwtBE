﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2022.Data.Entities
{
    public class AppUser: IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public string Birthday   { get; set; }
        public string Mobile { get; set; }

    }
}
