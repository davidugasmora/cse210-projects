using System;

class Program
{    static void Main(string[] args)
    {
        int sleepTime = 250;
        int time = 9;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);

        string animationStringLoad = "-+\\|/";
        int index = 0;

        //while (DateTime.Now < endTime)
        //{
        //    Console.Write(animationStringLoad[index++ % animationStringLoad.Length]);
        //    Thread.Sleep(sleepTime);
        //    Console.Write("\b");
        //}

        int count = time;

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
    }
}