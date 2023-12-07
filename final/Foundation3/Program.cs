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
        Console.WriteLine("===================================================================================");
        reception1.DisplayStandardMessage();
        reception1.DisplayFullReceptionMessage();
        reception1.DisplayShortMessage();

        Lecture lecture1 = new Lecture("Lecture", "Declining Water Levels in Eastern Idaho", "Lecture with Kassidy Telford Discussing strategies for preparing for water shortages. Hotcake breakfast served", "Saturday, December 16, 2023", "9:00 a.m.", address2, "Kassidy Telford, Director of IDWR, Bingham Ground Water District", 100);
        // New Lecture
        Console.WriteLine("===================================================================================");
        lecture1.DisplayStandardMessage();
        lecture1.DisplayFullLectureMessage();
        lecture1.DisplayShortMessage();
        
        OutdoorGathering outdoorGathering1 = new OutdoorGathering("OutdoorGathering", "Christmas Market", "Come and see everything and anything to decorate your home for Christmas.", "Saturday, December 9, 2023", "10:00 a.m.", address1, "Weather is expected to be chilly but dry.  Dress warmly.");
        // New OutdoorGathering
        Console.WriteLine("===================================================================================");
        outdoorGathering1.DisplayStandardMessage();
        outdoorGathering1.DisplayFullOutdoorGatheringMessage();
        outdoorGathering1.DisplayShortMessage();
    }
}