﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ESP.Models
{
    public class Roles
    {
        [Key] public int RoleId { get; set; }

        [StringLength(50)] public string RoleName { get; set; }
    }
}