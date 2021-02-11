using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameManager : Market
    {
        List<Game> Games = new List<Game>();

        public void Add(int id, string name, double price)
        {
            Game game = new Game();
            game.Id = id;
            game.Name = name;
            game.Price = price;

            Games.Add(game);

            Console.WriteLine("Game is added : " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game is updated : " + game.Name);

            Games.Add(game);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game is deleted : " + game.Name);
        }


        public void Buy(Player player)
        {
            Console.WriteLine("These games bought by : " + player.FirstName + " " + player.LastName );
            double total = 0;
            foreach (var game in Games)
            {
                Console.WriteLine(game.Name);
                total += game.Price;
            }

            Console.WriteLine("Total Price: $" + total);
        }
    }
}
