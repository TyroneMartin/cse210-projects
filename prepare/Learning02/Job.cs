using System;

// Class: Job
// Attributes/ Fields:  
// * _jobTitle : string
// * _company : string
// * _startYear : int
// * _endYear : int

// Behaviors/Methods:
// * DisplayJob() : void

// Responsibilities:
// Keeps track of the company, job title, start year, and end year.


public class Job 
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
          Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}



