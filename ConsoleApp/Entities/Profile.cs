using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Entities;

public partial class Profile
{
    [Key]
    public Guid UserId { get; set; }

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(50)]
    public string? StreetName { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? PostalCode { get; set; }

    [StringLength(50)]
    public string? City { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Profile")]
    public virtual User User { get; set; } = null!;
}
