using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public class CampaignManager : ICampaignService
    {
     

        public bool NewCampaignEntry(GameSale gameSale)
        {
            if (gameSale.GamePrice > 50)
            {
                Console.WriteLine("Yeni Kampanya girişi");
                return true;
            }
            else 
            {
                return false;
            
            }
           
        }

        public void CampaignDelete(Campaign campaign)
        {
            Console.WriteLine(" Kampanya silindi");
        }

        public void CampaignUpdate(Campaign campaign)
        {
            Console.WriteLine(" Kampanya güncellendi");
        }
    }
}
