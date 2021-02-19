using System;

namespace MyGameProject
{
    class Program
    {
     //1. Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz.
     //Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
     //(E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır.Bunu yapacak servisi simule etmeniz yeterlidir.)
     //2.Oyun satışı yapılabilecek satış ortamını simule ediniz.(Yapılan satışlar oyuncu ile ilişkilendirilmelidir.
     //Oyuncunun parametre olarak metotta olmasını kastediyorum.)
     //3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.
     //4.Satışlarda kampanya entegrasyonunu simule ediniz.
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player { Id = 1, Birthyear = 2000, FirstName = "Merve", LastName = "BİNGÖL", NationalyId = 123456 });

            Console.WriteLine("--------------------------------------------------------------");
            GameSaleManager gameSaleManager = new GameSaleManager(new CampaignManager());
            GameSale gameSale = new GameSale {GamePrice=60 };
            gameSaleManager.GetGameSale(gameSale);
        }
    }
}
