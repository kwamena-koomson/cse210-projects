using System;

class Program
{
  static void Main(string[] args)
  {
    Job job1 = new Job();
    job1._jobTitle = "Software Engineer";
    job1._company = "Microsoft";
    job1._startYear = 2500;
    job1._endYear = 2520;

    Job job2 = new Job();
    job2._jobTitle = "COO";
    job2._company = "Spotify";
    job2._startYear = 2000;
    job2._endYear = 3000;

    Resume resume = new Resume();
    resume._name = "Kwamena Koomson";
    resume._jobs.Add(job1);
    resume._jobs.Add(job2);

    resume.Display();
  }
}