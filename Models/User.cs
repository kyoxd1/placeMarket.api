using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace placeMarket.api.Models
{
    public class User
    {
        public int id { get; set; }
        
        public string Username { get; set; }
        [NotMapped]
        public string Password { get; set; }
        
        public byte[] passwordHash { get; set; }
        
        public byte[] PasswordSalt { get; set; }
        public string ValidationCode { get; set; }
        public DateTime ValidationDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Ci { get; set; }
        public string ExpeditionCi { get; set; }
        public string Gender { get; set; }
        public int LoginAttemptCounter { get; set; }
        public string UserState { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nickname { get; set; }
        public DateTime LastActive { get; set; }
        public string PhotoUrl { get; set; }
        public string RecoveryKey { get; set; }
        public DateTime RecoveryDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime DateModified { get; set; }
        public Boolean VerifiedEmail { get; set; }
        public string VerifiedEmailKey { get; set; }
        public DateTime VerifyEmailDate { get; set; }
        public int phone { get; set; }
        public virtual ExternalLogin ExternalLogin { get; set; }
        public int ExternalLoginId { get; set; }
        public virtual ICollection<UserRol> UserRols { get; set; }

    }
}