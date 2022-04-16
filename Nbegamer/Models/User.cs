using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nbegamer.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserFullName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }


        public DateTime JoinDate { get; set; }
        public string LastLoginIP { get; set; }

        
        public string ProfilePicture { get; set; }
        public bool IsActive { get; set; }

        public int UserTypeID { get; set; }
    }
}
