using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace TestSqlite
{
    internal class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Name => $"{FirstName} {SecondName}";
        public string Email { get; set; }
        public string Address { get; set; }
    }
}