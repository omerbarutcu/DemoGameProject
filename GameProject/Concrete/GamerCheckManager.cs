using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            if (gamer.NationalId == 12345 && gamer.FirstName == "Omer" && gamer.LastName == "Barutcu" && gamer.DateOfBirth == 1984)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
