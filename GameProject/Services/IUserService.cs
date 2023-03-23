using OOPProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Services
{
    internal interface IUserService
    {
        public void Add(User user);
        public void Remove(User user);
        public void Update(User user);
    }
}
