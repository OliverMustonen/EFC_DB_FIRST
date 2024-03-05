using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Entities;

[Index("Email", Name = "IX_Users_Email", IsUnique = true)]
[Index("RoleId", Name = "IX_Users_RoleId")]
public partial class User
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    [InverseProperty("User")]
    public virtual Profile? Profile { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("Users")]
    public virtual Role Role { get; set; } = null!;
}
