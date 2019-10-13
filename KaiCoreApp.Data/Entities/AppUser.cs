﻿using KaiCoreApp.Data.Enums;
using KaiCoreApp.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KaiCoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateModified { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}