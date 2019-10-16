using FeedReader.App.Services;
using System;

namespace FeedReader.App
{
    class Program
    {
        private static readonly RaceService raceService;

        static void Main(string[] args)
        {
            var horses = raceService.GetAll();
            Console.WriteLine(horses);
        }
    }
}
