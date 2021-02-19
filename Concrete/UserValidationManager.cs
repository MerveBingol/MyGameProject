using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool validate(Player player)
        {
            if (player.Birthyear==2000&& player.FirstName=="Merve"&&player.LastName=="BİNGÖL"&& player.NationalyId==123456)
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
