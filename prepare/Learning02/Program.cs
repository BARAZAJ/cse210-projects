using System;


    
public class Job
{
    // Properties
    public string JobTitle { get; set; }
    public string Company { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    // Constructor
    public Job(string jobTitle, string company, int startYear, int endYear)
    {
        JobTitle = jobTitle;
        Company = company;
        StartYear = startYear;
        EndYear = endYear;
    }

    // Method to display job information
    public void DisplayJobInfo()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}

    



    



    
}