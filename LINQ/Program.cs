namespace LINQ

{
    public class Program
    {
        static void Main(string[] args)
        {
            //This will be the list of my favorite games not in order of favoritism
            List<string> videoGames = new List<string>
            {
                "Half-Life Series",
                "The legend of zelda: A Link back to the past!",
                "Minecraft",
                "Dead by Daylight",
                "Pal-World",
                "Final Fantasy 14 Online",
                "Guild Wars 2",
                "Fallout series",
                "DOOM"

            };
            
            // This will order the length of the name of the game using the above LINQ method

            var sortedVideoGames = videoGames
                .OrderBy(game => game.Length)
                .ToList();
            
            // This will sort list to the console

            foreach (var game in sortedVideoGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
