using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("5000 Forbes Ave", "Pittsburgh", "Pennsylvania", "USA");
        Lecture lecture = new Lecture("The Last Lecture", "9/18/07", "7:00pm", address1, "Randy Pausch", 200);

        Address address2 = new Address("50 E North Temple Street", "Salt Lake City", "Utah", "USA");
        Reception reception = new Reception("The Second Coming", "3/25/35", "3:30pm", address2, "jc@ldschurch.org");

        Address address3 = new Address("35330 Billie Ann Road", "Wildomar", "California", "USA");
        Gathering gathering = new Gathering("Courtney's Wedding", "5/13/18", "2:00pm", address3, "Planning on sunny weather");

        Console.WriteLine("---------------------------------------------------------------------------------");
        lecture.PrintStandardDetails();
        Console.WriteLine();
        lecture.PrintFullDetails();
        Console.WriteLine();
        lecture.PrintShortDescription();
        Console.WriteLine("---------------------------------------------------------------------------------");

        reception.PrintStandardDetails();
        Console.WriteLine();
        reception.PrintFullDetails();
        Console.WriteLine();
        reception.PrintShortDescription();
        Console.WriteLine("---------------------------------------------------------------------------------");

        gathering.PrintStandardDetails();
        Console.WriteLine();
        gathering.PrintFullDetails();
        Console.WriteLine();
        gathering.PrintShortDescription();
        Console.WriteLine("---------------------------------------------------------------------------------");
    }
}