
using System;

namespace Kelasi.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public DateTime Registered { get; set; }
        public Status Status { get; set; }
    }
}
