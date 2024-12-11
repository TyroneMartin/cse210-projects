using System;
using System.Collections.Generic;

// Class: Resume
// Attributes:  
// * _operationName : string
// * _jobs : List<Job>

// * Behaviors/Methods:
// * DisplayResume() : void  

// Responsibilities:
// Keeps track of the person's name and a list of their jobs.

public class Resume
{
    public string _operationName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }

}




