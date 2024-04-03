﻿namespace ShiftsLogger.frockett.API.Models;

public class Shift
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public TimeSpan Duration => EndTime - StartTime;
    public int EmployeeId { get; set; }

    public Employee Employee { get; set; }
}
