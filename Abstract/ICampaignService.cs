using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    public interface ICampaignService
    {
        bool NewCampaignEntry(GameSale gameSale);
        void CampaignDelete(Campaign campaign);
        void CampaignUpdate(Campaign campaign);
    }
}
