﻿namespace Domain.Entities;

public class Priority
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int ExpectedDays { get; set; }
}