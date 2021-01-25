using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerKing
{
   public class siparis
    {
        //siparis classı ile fiyatı etkileyen tüm özellikleri bir class içerisine almıs olduk:
        public string etMenu { get; set; }
        public string tavukMenu { get; set; }
        public string Kampanya { get; set; }
        public string Boyut { get; set; }

        public string tatlilar { get; set; }

        public string Extralar { get; set; }
        public int Adet { get; set; }
        public decimal SiparisTutari { get; set; }

        
        //metot tanımlayarak secilen menuye göre fiyat hesaplaması yapalım:
        //metodumuz:

        public void TutarHesapla()
        {

            this.SiparisTutari =0;

            //switch case mantıgı ile secilen menuye ve menu içerisindeki ürüne göre fiyat tutarı girilecektir:

            #region  etMenu
            switch (etMenu)
            {
                case "Big King@Jr":
                    SiparisTutari =22.99M;
                    break;
                case "Whopper.Jr@":
                    SiparisTutari =24.99M;
                    break;

                case "Bk Steakhouse Burger":
                    SiparisTutari = 34.99M;
                    break;

                case "Cheeseburger":
                    SiparisTutari = 24.99M;
                    break;


                case "Texas Smokehouse Burger":
                    SiparisTutari = 39.99M;
                    break;

                case "Köfteburger":
                    SiparisTutari = 22.99M;
                    break;

                case "Hamburger":
                    SiparisTutari = 22.99M;
                    break;



            }
            #endregion

            #region tavukMenu
            switch (tavukMenu)
            {
                case "Tavukburger":
                    this.SiparisTutari = 18;
                    break;

                case "King Chicken":
                    this.SiparisTutari = 25.99M;
                    break;
                case "Chicken Tenders 6lı":
                    this.SiparisTutari = 22.99M;
                    break;
                case "Fish Royale":
                    this.SiparisTutari = 29.99M;
                    break;

            }
            #endregion

            #region Kampanya
            switch (Kampanya)
            {

                case "Taraftar Menüsü":
                    SiparisTutari = 32.50M;
                    break;
                case "Kral Fırsat(2 kişilik)":
                    SiparisTutari = 59.99M;
                    break;

                case "Pro Gammer Big King":
                    SiparisTutari = 29.99M;
                    break;

                case "Dörtlü Fırsat Menüsü":
                    SiparisTutari = 49.99M;
                    break;

                case "Köftesever Menü":
                    SiparisTutari = 39.99M;
                    break;
                case "Çıtır Çıtır Atıstır":
                    SiparisTutari = 9.50M;
                    break;

            }
            #endregion

            
            #region boyut
            
            switch (Boyut)
            {
                case "Orta":
                    SiparisTutari += 0;
                    break;
                case "King":
                    SiparisTutari += 5;
                    break;

              
               
            }
            #endregion

            //extraların hiç secilmeme durumu da olabilir. null ve bos demek aynı seyler demek degildir::
            //null:referansı verilmis ama ramde yeri acılmamıs
            //bos:ramde yeri acılmıs ama degeri atanmamıs 
            //o yüzden boyut stringinin bos olma durumunu kontrol edelim:

            #region extralar
            if (!string.IsNullOrEmpty(Extralar))
            {

                int extraSayisi = Extralar.Split(',').Length;
                SiparisTutari += extraSayisi * 1.25M;


            }
            #endregion

            #region tatlılar
            switch (tatlilar)
            {
                case "profiterol":
                    SiparisTutari += 10;
                    break;

                case "suffle":
                    SiparisTutari += 10;
                    break;
                case "pasta":
                    SiparisTutari += 10;
                    break;



            }

            #endregion



            #region adet
            SiparisTutari *= Adet;
            #endregion



        }

        

        public override string ToString()
        {
            //listview da siparis detayımızın formatı:

            //1 adet King boy Tavukburger Menu(acı sos)--Fiyatı:25tl

            if (string.IsNullOrEmpty(Extralar))
                return string.Format("{0} adet {1} boy {2},{3},{4}  tatli {5}  Fiyatı:{6:C}", Adet, Boyut, etMenu, tavukMenu, Kampanya, tatlilar, SiparisTutari);
            else
                return string.Format("{0} adet {1} boy {2},{3},{4}({5})  tatli {6}  Fiyatı:{7:C}", Adet, Boyut, etMenu, tavukMenu, Kampanya, Extralar, tatlilar, SiparisTutari);

        }

    }
}
