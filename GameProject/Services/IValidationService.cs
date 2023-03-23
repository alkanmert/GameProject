using OOPProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Services
{
    internal interface IValidationService
    {
        public bool Validate(User user);
    }
}
