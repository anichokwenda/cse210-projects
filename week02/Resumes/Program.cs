using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a new job instance
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        //Create a new resume instance
        Resume myResume = new Resume("Anisa Chokwenda");

        //Add jobs to the resume 
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        //Display the first job title
        myResume.Display();
    }
}