using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("added game");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("deleted game");
        }

        public void Update(Game game)
        {
            Console.WriteLine("updated game");
        }
    }
}
