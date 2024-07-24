using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = [];

        LectureEvent lectureEvent = new(
            "Who is God?",
            "Discussion about God in the Bible",
            new DateTime(2024, 07, 24, 10, 00, 00),
            new Address("Russia", "Central Region", "Moscow", "Saint Seraphim street 333"),
            "Isaac the Syrian",
            777
        );
        events.Add(lectureEvent);

        ReceptionEvent receptionEvent = new(
            "Q&A with Holy Fathers of the Church",
            "Ask anything about Christian life",
            new DateTime(2024, 08, 25, 12, 30, 00),
            new Address("Russia", "Volga region", "Samara", "St. George street 777"),
            "samara_talks@gmail.com"
        );
        events.Add(receptionEvent);

        OutdoorEvent outdoorEvent = new(
            "Collective prayer",
            "Pray together on the mointain",
            new DateTime(2024, 09, 30, 08, 59, 00),
            new Address("Greece", "Agio Oros", "Mount Athos", "Chalkidiki peninsula"),
            "+20 Sunny"
        );
        events.Add(outdoorEvent);

        int index = 0;

        foreach(Event eventItem in events)
        {
            index++;

            Console.WriteLine($"\n[Event #{index}]");
            Console.WriteLine(" - Standard details: " + eventItem.GetStandardDetails());
            Console.WriteLine(" - Full details: " + eventItem.GetFullDetails());
            Console.WriteLine(" - Short description: " + eventItem.GetShortDescription());
        }
    }
}