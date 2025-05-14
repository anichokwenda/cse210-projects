public class Job
{
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    //Constructor
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        JobTitle = jobTitle;
        Company = company;
        StartYear = startYear;
        EndYear = endYear;
    }

    //Display method
    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }

}