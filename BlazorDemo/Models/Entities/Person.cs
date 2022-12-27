using System;
using System.Collections.Generic;

namespace BlazorDemo.Models.Entities;

public partial class Person
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }
}
