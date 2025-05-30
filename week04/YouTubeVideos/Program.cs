
using System;

class Program
{
    static void Main()
    {
        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 400);
        Video video3 = new Video("Video 3", "Author 3", 500);
        Video video4 = new Video("Video 4", "Author 4", 600);

        // Add comments to videos
        video1.AddComment("Willow Vee", "Amaizing video. Can you make more of these!");
        video1.AddComment("Vivian Wild", "Great job! There is always room for improvements");
        video1.AddComment("Charles Mwenje", "I love the quality of the video. Keep it up!");

        video2.AddComment("Jack Arnold", "Bravo!");
        video2.AddComment("Drew Fox", "Woooow . Thats a good one!");
        video2.AddComment("Emily Nikes", "It was not that bad! All the best.");

        video3.AddComment("Karl Leigh", "That's a good video!");
        video3.AddComment("Susan Tyre", "I enjoyed it!");
        video3.AddComment("Kelvin Waters", "Nice job!");

        video4.AddComment("Oliver Marlin", "Great video!");
        video4.AddComment("Lillian Harts", "We need more of this!");
        video4.AddComment("Austin Thomas", "Quite enjoyable!");

        // Display video information
        Video[] videos = { video1, video2, video3, video4 };
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoInfo());
            Console.WriteLine("Comments:");
            Console.WriteLine(video.GetComments());
            Console.WriteLine();
        }
    }
}
