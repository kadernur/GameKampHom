using System;
using System.Collections.Generic;
using System.Text;

namespace GameKampHom
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Kader Nur" && gamer.LastName == "Tekin" && gamer.IdentityNumber == 12345)
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
