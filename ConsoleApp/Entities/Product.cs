using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Entities;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string ProductName { get; set; } = null!;
}
