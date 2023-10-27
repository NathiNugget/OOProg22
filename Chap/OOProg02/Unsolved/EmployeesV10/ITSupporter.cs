﻿
using EmployeesV10;

public class ITSupporter : Employee
{
    #region Properties
    
    public string PrimaryWorkArea { get; set; }

    public string AllInformation
    {
        get
        {
            return $"IT-Supporter {base.Name} works {HoursPerWeek} hours/week, mostly with {PrimaryWorkArea}";
        }
    }
    #endregion

    #region Constructor
    public ITSupporter(string name, int hoursPerWeek, string primaryWorkArea) : base(name, hoursPerWeek)
    {
        Name = name;
        HoursPerWeek = hoursPerWeek;
        PrimaryWorkArea = primaryWorkArea;
    }
    #endregion
}