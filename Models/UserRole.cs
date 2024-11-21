using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProjetoEntityFramework.Models
{
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}