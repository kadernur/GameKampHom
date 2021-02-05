using System;
using System.Collections.Generic;
using System.Text;

namespace GameKampHom
{
    class GamerManager : IGamerService
    {
        //e devlet sistemi üzerinde kişi doğruluk kontrolü.
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Gamer added");
            }
            else
            {
                Console.WriteLine("In valid gamer");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated");
        }
    }
}
