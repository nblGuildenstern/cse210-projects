public class Job {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display() {
        System.Console.WriteLine($"{_jobTitle} ({_company}) {_startYear.ToString()}-{_endYear.ToString()}");
    }
}