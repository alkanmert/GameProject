using OOPProject.Objects;
using OOPProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Managers
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {   
            Console.WriteLine(game.GameName + " "+ "Oyunu başarıyla eklendi") ;
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " " +"Oyunu başarıyla silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " " + "Oyunu başarıyla güncellendi");
        }
    }
}
