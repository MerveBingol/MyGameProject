using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    //kullanıcı doğrulama servisi
   public interface IUserValidationService
    {
        bool validate(Player player);

    }
}
