﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BlogEngineSergioDemarco.Areas.Identity.Data
{

    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationPost
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}