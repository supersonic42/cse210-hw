using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];

        Video video1 = new("Animal in the wilds", "Bear Grills", 100);
        video1.AddComment(new Comment("Joe Pesci", "Now bad, but wolves are dnagerous."));
        video1.AddComment(new Comment("Mike Miles", "I like foxes."));
        video1.AddComment(new Comment("Jimbo Slice", "Who saw a squirrel on 1:01?"));
        videos.Add(video1);

        Video video2 = new("How to build a spaceship", "Elon Musk", 200);
        video2.AddComment(new Comment("Mr. Bean", "I wanna test it! Where to sign up?"));
        video2.AddComment(new Comment("Yuri Gagarin", "Does it even fly?"));
        video2.AddComment(new Comment("Bob Marley", "Doubt it. I have another type of spaceship."));
        videos.Add(video2);

        Video video3 = new("How big is the Universe?", "Stephen Hawking", 300);
        video3.AddComment(new Comment("Albert E.", "I bet it is twice as big."));
        video3.AddComment(new Comment("YHWH", "Not even close..."));
        video3.AddComment(new Comment("Brahmachari", "Read Vedas lol."));
        videos.Add(video3);

        Console.WriteLine("Your recommended videos:");
    
        foreach(Video video in videos)
        {
            video.Display();
        }
    }
}