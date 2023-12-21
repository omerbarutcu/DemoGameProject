using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    internal class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double UnitPrice { get; set; }
        public Campaign Campaign { get; set; }
    }
}
