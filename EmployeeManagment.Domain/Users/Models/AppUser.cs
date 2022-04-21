using EmployeeManagment.Domain.Base;
using EmployeeManagment.Domain.Users.Models;
using EmployeeManagment.Shared.User.Types;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Models
{
    [Table(nameof(AppUser))]
    public class AppUser : Entity
    {
        #region Attribute
        [Required]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Introduction { get; set; }
        [DefaultValue(Gender.Male)]
        public Gender Gender { get; set; } = Gender.Male;
        public bool IsActive { get; set; }
        public ICollection<UserImage> Images { get; set; }
        #endregion

        #region Methods
        public void Update(string userName,
                           string email,
                           string password)
        {
            UserName = userName;
            Email = email;
            var passwordHasher = new PasswordHasher<AppUser>();
            Password = passwordHasher.HashPassword(null, password);
        }
        public static AppUser Create(string userName,
                                     string email,
                                     string password,
                                     )
        {
            var entity = new AppUser();
            entity.Update(userName, email, password);
            return entity;
        }
        #endregion

    }
}
