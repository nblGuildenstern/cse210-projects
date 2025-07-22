using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        videos.Add(new Video("Baby Shark Dance", "Baby Shark", 137));
        videos[0].AddComment(new Comment("BabyMama32", "My 23 4-year-olds can't get enough!!"));
        videos[0].AddComment(new Comment("that1dude", "Yo that's so hype"));
        videos[0].AddComment(new Comment("hater33", "I hate this song it's annoying"));

        videos.Add(new Video("I beat Donkey Kong Bananza. It's amazing.", "cjya", 9677));
        videos[1].AddComment(new Comment("corgistaniel1150", "The devil works fast but CJ's editor works faster"));
        videos[1].AddComment(new Comment("sagittariuskirby", "Take a shot every time CJ thinks hes near the end of the game when hes not even close"));
        videos[1].AddComment(new Comment("Saaaten", "The third act of this game might be my favorite 3rd act in any nintendo game tbh"));

        videos.Add(new Video("Gangnam Style", "officialpsy", 252));
        videos[2].AddComment(new Comment("hai5379", "This man concealed the honmoon by himself in 2012 stopping the end of the world!!!"));
        videos[2].AddComment(new Comment("zbynula166", "This song prooved, that nobody cares about the lyrics"));
        videos[2].AddComment(new Comment("Iblamegenetics", "This is the closest we were to achieve world peace"));

        foreach (Video vid in videos)
        {
            vid.DisplayVideo();
            Console.WriteLine();
        }
    }
}