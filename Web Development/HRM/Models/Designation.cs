﻿using System.ComponentModel;
using HRM.Models;
using Microsoft.EntityFrameworkCore;

public class Designation
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public Role Role { get; set; }
}
