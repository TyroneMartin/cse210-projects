using System;

class Program
{
    static void Main(string[] args)
    {

// Activity Instructions
// Practice the principle of abstraction by creating classes to represent a resume or an job history 
// for a person like you might see on LinkedIn.

        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();

        job3._company = "Google";
        job3._jobTitle = "Software Engineer";
        job3._startYear = 2023;
        job3._endYear = 2024;


        Resume myResume = new Resume();

        myResume._name = "Ricardo Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayResume();

    


    }
}