using OOPProject.Objects;
using OOPProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Managers
{
    internal class ValidationManager : IValidationService
    {
        public bool Validate(User user)
        {
            return true;
        }
    }
}
