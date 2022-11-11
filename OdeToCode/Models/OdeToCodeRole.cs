﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace OdeToCode.Models
{
    public class OdeToCodeRole : IdentityRole
    {
        [StringLength(128,MinimumLength =1)]
        public string DisplayName { get; set; }
    }
}
