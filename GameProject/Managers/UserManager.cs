using OOPProject.Objects;
using OOPProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProject.Managers
{
    internal class UserManager : IUserService
    {   
        IValidationService _validationService;

        public UserManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(User user)
        {
            if(_validationService.Validate(user) == true)
            {
                Console.WriteLine(user.FirstName + "," +  "kayıt işlemin başarılı.");
            }
            else
            {
                Console.WriteLine("Kayıt işlemi başarısız");
            }
        }

        public void Remove(User user)
        {
            if (_validationService.Validate(user) == true)
            {
                Console.WriteLine(user.FirstName + "," + "silme işlemi başarılı");
            }
            else
            {
                Console.WriteLine("Silme işlemi başarısız");
            }
        }

        public void Update(User user)
        {
            if (_validationService.Validate(user) == true)
            {
                Console.WriteLine(user.FirstName + "," + "güncelleme işlemi başarılı");
            }
            else
            {
                Console.WriteLine("Güncelleme işlemi başarısız");
            }
        }
    }
}
