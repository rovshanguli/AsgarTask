﻿namespace ServiceLayer.DTOs.AppUser
{
    public class UpdatePasswordDto
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
