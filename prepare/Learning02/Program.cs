using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "ABC Interactive";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2008;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._company = "Meta";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2012;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume._name = "Allison Rose";
        myResume.displayListOfJobs();
    }
}