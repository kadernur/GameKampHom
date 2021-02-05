using System;
using System.Collections.Generic;
using System.Text;

namespace GameKampHom
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
