using EFC_Ex1.DAL;
using EFC_Ex1.DAL.Moduls;

namespace EFC_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Games> games = new List<Games>()
                                    {
                                        new Games()
                                        {
                                                Name = "Arcanum: Of Steamworks and Magick Obscura",
                                                Developer ="Troika Games",
                                                Gener ="RPG",
                                                Release = new DateTime(2000,8,26)
                                        },
                                        new Games()
                                        {
                                                Name = "Gothic",
                                                Developer ="Piranha Bytes",
                                                Gener ="RPG",
                                                Release = new DateTime(2001,3,15)
                                        },
                                        new Games()
                                        {
                                                Name = "System Shock 2",
                                                Developer ="Irrational Games & Looking Glass Studios",
                                                Gener ="Survival horror",
                                                Release = new DateTime(1999, 7,11 )
                                        },
                                         new Games()
                                         {
                                                Name = "Warcraft III: Reign of Chaos",
                                                Developer ="Blizzard Entertainment",
                                                Gener ="RTS",
                                                Release = new DateTime(2002, 6,3 )
                                         }
                                    };
            //using (var context = new Context())
            //{
            //    context.AddRange(games);
            //    context.SaveChanges();
            //}
            using (var context = new Context())
            {
                var gamesInfo = context.Games;
                foreach (var game in gamesInfo)
                {
                    Console.WriteLine($"{game.Name} \t {game.Gener} \t {game.Developer}\t {game.Release.Value.Year}:{game.Release.Value.Month}:{game.Release.Value.Day}");
                }
            }
            Console.ReadKey(); 
        }
    }
}