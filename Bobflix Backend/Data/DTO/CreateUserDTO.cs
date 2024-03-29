﻿using System.ComponentModel.DataAnnotations;

namespace Bobflix_Backend.Data.DTO
{
    public class CreateUserDTO
    {
        [Required]
        public bool isAdmin { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
