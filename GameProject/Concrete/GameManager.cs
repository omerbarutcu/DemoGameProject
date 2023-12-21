using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi :" + game.GameName);
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName +" güncellendi.");
        }
    }
}
