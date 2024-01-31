namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<string> videoGames = new List<string>() {"Call of Duty", "Halo", "Madden", "Nba", "League of legends", "Palworld", "Tekken", "Street Fighter" };

            var orderedName = videoGames.OrderBy(x => x.Length);

            foreach(var games in orderedName) 
            {
                Console.WriteLine(games);
            }

        }
    }
}
