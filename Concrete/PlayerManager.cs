using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    //MicroService
    public class PlayerManager : IPlayerService //  somut halini oluşturuyoruz
    {

   // validation özelliğini kullanmak için ve bir Manager sınıfınfa başka bir Manager sınıfını kullanmak istiyorsak asla onu new leme

        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService) // PlayerManagerde bir doğrulama servisi kullanacağım demek
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if (_userValidationService.validate(player))
            {
                Console.WriteLine("Kayıt oldu");
            }
            else 
            {
                Console.WriteLine("Doğrulama başarısız, Kayıt başarısız");

            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
