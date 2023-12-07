using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Program 3: Inheritance with Event Planning");
        Console.WriteLine("---------------------------------------------------------------------------------");

        // Create the venue addresses
        Address address1 = new Address("Twenty & Creek", "2050 Creek Rd", "Sandy", "UT", "84093", "USA"); //OutdoorActivity
        Address address2 = new Address("Krehbiels Barn", "305 S Broadway St", "Blackfoot", "ID", "83221", "USA"); // Lecture
        Address address3 = new Address("The Murie Ballroom", "3335 Village Dr", "Teton Village", "WY", "83025", "USA"); //Reception

        Reception reception1 = new Reception("Reception", "Olaf & Elsa Anderson Wedding Reception", "A wedding reception for Olaf and Elsa.  Brunch will be served.", "Saturday, March 16, 2024", "10:00 a.m.", address3, "anderson031624@receptions.com");
        // New Reception

        Console.WriteLine("Reception");
        Console.WriteLine("Standard");
        Console.WriteLine($"Title:\t\t{reception1.GetTitle()}\nDescription:\t{reception1.GetDescription()}\nDate & Time:\t{reception1.GetDate()} at {reception1.GetTime()}\nLocation:\n{reception1.GetAddress()}\n");

        Console.WriteLine("Full");
        Console.WriteLine($"Title:\t\t{reception1.GetTitle()}\nDescription:\t{reception1.GetDescription()}\nDate & Time:\t{reception1.GetDate()} at {reception1.GetTime()}\nLocation:\n{reception1.GetAddress()}\n\nToRSVP, send response to: {reception1.GetEmailRSVP()}\n");


        Console.WriteLine("Short");
        Console.WriteLine($"Event Type:\tReception\nTitle:\t\t{reception1.GetTitle()}\nDate:\t\t{reception1.GetDate()}\n");

        Lecture lecture1 = new Lecture("Lecture", "Declining Water Levels in Eastern Idaho", "Lecture with Kassidy Telford Discussing strategies for preparing for water shortages. Hotcake breakfast served", "Saturday, December 16, 2023", "9:00 a.m.", address2, "Kassidy Telford, Director of IDWR, Bingham Ground Water District", 100);
        // New Lecture

        Console.WriteLine("Lecture                                                                           ");
        Console.WriteLine("Standard                                                                          ");
        Console.WriteLine($"Title:\t\t{lecture1.GetTitle()}\nDescription:\t{lecture1.GetDescription()}\nDate & Time:\t{lecture1.GetDate()} at {lecture1.GetTime()}\nLocation:\n{lecture1.GetAddress()}\n");


        Console.WriteLine("Full                                                                              ");
        Console.WriteLine($"Title:\t\t{lecture1.GetTitle()}\nDescription:\t{lecture1.GetDescription()}\nDate & Time:\t{lecture1.GetDate()} at {lecture1.GetTime()}\nLocation:\n{lecture1.GetAddress()}\n\nThe speaker will be: {lecture1.GetSpeaker()}\nSeating is limited to {lecture1.GetCapacity()} attendees.\n\n");

        Console.WriteLine("Short                                                                             ");
        Console.WriteLine($"Event Type:\tLecture\nTitle:\t\t{lecture1.GetTitle()}\nDate:\t\t{lecture1.GetDate()}\n");
        
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("OutdoorGathering", "Christmas Market", "Come and see everything and anything to decorate your home for Christmas.", "Saturday, December 9, 2023", "10:00 a.m.", address1, "Weather is expected to be chilly but dry.  Dress warmly.");
        // New OutdoorGathering
        Console.WriteLine("Outdoor Gathering                                                                 ");
        Console.WriteLine("Standard                                                                          ");
        Console.WriteLine($"Title:\t\t{outdoorGathering1.GetTitle()}\nDescription:\t{outdoorGathering1.GetDescription()}\nDate & Time:\t{outdoorGathering1.GetDate()} at {outdoorGathering1.GetTime()}\nLocation:\n{outdoorGathering1.GetAddress()}\n");
        Console.WriteLine("Full                                                                              ");
        Console.WriteLine($"Title:\t\t{outdoorGathering1.GetTitle()}\nDescription:\t{outdoorGathering1.GetDescription()}\nDate & Time:\t{outdoorGathering1.GetDate()} at {outdoorGathering1.GetTime()}\nLocation:\n{outdoorGathering1.GetAddress()}\n\nWeather Statement:\t{outdoorGathering1.GetWeather()}\n");
        Console.WriteLine("Short                                                                              ");
        Console.WriteLine($"Event Type:\tOutdoorGathering\nTitle:\t\t{outdoorGathering1.GetTitle()}\nDate:\t\t{outdoorGathering1.GetDate()}\n");


    }
    /* 
    Standard - Lists the title, description, date, time, and address.

    Full - Lists all of the above, plus type of event and information specific 
    to that event type. For lectures, this includes the speaker name and capacity. For 
    receptions this includes an email for RSVP. For outdoor gatherings, this includes a 
    statement of the weather.

    Short - Lists the type of event, title, and the date 
    */
}