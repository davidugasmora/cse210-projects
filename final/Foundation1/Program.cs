using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video_1 = new Video("Watch my cat!", "Mark Twaine", 3.5f);
        Comment comment_1_1 = new Comment("Marco Salazar", "First comment!");
        video_1.AddComment(comment_1_1);
        Comment comment_1_2 = new Comment("Veronica Montero", "Such beautiful pet, please take care of it!");
        video_1.AddComment(comment_1_2);
        Comment comment_1_3 = new Comment("James Howlet", "I prefer dogs to be honest.");
        video_1.AddComment(comment_1_3);
        videos.Add(video_1);

        Video video_2 = new Video("I will finish my homework or die trying!", "Rebecca Smith", 45.9f);
        Comment comment_2_1 = new Comment("Rebecca's hater #1", "You suck!");
        video_2.AddComment(comment_2_1);
        Comment comment_2_2 = new Comment("Miguel Juarez", "Great video!");
        video_2.AddComment(comment_2_2);
        Comment comment_2_3 = new Comment("The hater of haters", "Never pay attention to any hater, including me!");
        video_2.AddComment(comment_2_3);
        Comment comment_2_4 = new Comment("Dave the man", "Came for the title, stayed for the content.");
        video_2.AddComment(comment_2_4);
        videos.Add(video_2);

        Video video_3 = new Video("How to open a door (easy tutorial)", "Master of none", 5.0f);
        Comment comment_3_1 = new Comment("Juan Pablo", "Been searching a video like this for years!");
        video_3.AddComment(comment_3_1);
        Comment comment_3_2 = new Comment("Door investigator", "Finally someone that gives real answers.");
        video_3.AddComment(comment_3_2);
        Comment comment_3_3 = new Comment("Alissa Porter", "Anyone here in 2025?");
        video_3.AddComment(comment_3_3);
        videos.Add(video_3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();

            video.DisplayVideoComments();
        }
    }
}