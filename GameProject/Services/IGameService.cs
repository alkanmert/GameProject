using OOPProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Services
{
    internal interface IGameService
    {
        public void Add(Game game);
        public void Remove(Game game);
        public void Update(Game game);
    }
}
