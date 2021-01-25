using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerKing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //generic list<>: bir koleksiyon yapısıdır, ben hangi tipte liste olusturmasını kendim söylerim, içersine eleman attıkçada boyutunu kendisi ayarlar,boyut kavramı kensisine aittir


        //siparis türünde bir liste olusturmus olduk:
        List<siparis> siparisler = new List<siparis>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            /*MENULER  -FİYATLARI
             * 
             * ET ÜRÜNLERİ:
             * 
             * Big King@Jr--22.99
             * Whopper.Jr@--24.99
             * Bk Steakhouse Burger--34.99
             * Texas Smokehouse Burger--39.99
             * Köfteburger--22.99
             * Cheeseburger--24.99
             * Hamburger--22.99
             * 
             * TAVUK ÜRÜNLERİ
             * 
             * 
             * Tavukburger--18.99
             * King Chicken--25.99
             * Chicken Tenders 6lı--22.99
             * Fish Royale--29.99
             * 
             * KAMPANYALAR
             * 
             * Taraftar Menüsü--32.50
             * Kral Fırsat(2 kişilik)--59.99
             * Pro Gammer Big King--29.99
             * Dörtlü Fırsat Menüsü--49.99
             * Köftesever Menü--39.99
             * Çıtır Çıtır Atıstır--9.50
             * 
             * 
             * 
             * */

            string[] et = { "Big King@Jr", "Whopper.Jr@", "Bk Steakhouse Burger", "Texas Smokehouse Burger", "Köfteburger", "Cheeseburger", "Hamburger" };
            string[] tavuk = { "Tavukburger", "King Chicken", "Chicken Tenders", "Fish Royale" };
            string[] kampanya = { "Taraftar Menüsü", "Kral Fırsat(2 kişilik)", "Pro Gammer Big King", "Dörtlü Fırsat Menüsü", "Köftesever Menü", "Çıtır Çıtır Atıstır" };
            string[] tatlilar = { "profiterol", "suffle", "pasta" };


            comboBox1.Items.AddRange(et);
            comboBox2.Items.AddRange(tavuk);
            comboBox3.Items.AddRange(kampanya);
            comboBox4.Items.AddRange(tatlilar);


            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox4.SelectedIndex = -1;
            radioButton1.Checked = true;
            numericUpDown1.Value = 1;
            numericUpDown1.ReadOnly = true;
            this.Text = "BURGER KİNG";
           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           siparis yeniSiparis = SiparisOlustur();//ctrl+. ile yenibir method olusturduk

            lstSiparis.Items.Add(yeniSiparis);

            siparisler.Add(yeniSiparis);
        }

        private siparis SiparisOlustur()
        {

            siparis s = new siparis();
            //siparis classı türünde metot tanımlayarak form'a girilen degerleri classtaki propertieslere atayalım:

            //menüler için
            if (comboBox1.SelectedIndex >= 0)
            {
                comboBox2.Enabled = false; comboBox3.Enabled = false;
                s.etMenu = comboBox1.SelectedItem.ToString();
               
            }

            else if (comboBox2.SelectedIndex >= 0)
            {
                comboBox1.Enabled = false; comboBox3.Enabled = false;
                s.tavukMenu = comboBox2.SelectedItem.ToString();
               
            }

            else if (comboBox3.SelectedIndex >= 0) {
                comboBox1.Enabled = false; comboBox2.Enabled = false;
                s.Kampanya = comboBox3.SelectedItem.ToString();
                
            }
          
            
             if(comboBox4.SelectedIndex>=0)
            s.tatlilar = comboBox4.SelectedItem.ToString();
            
            //boyut için
            if (radioButton1.Checked)
                s.Boyut = radioButton1.Text;
            else if (radioButton2.Checked)
                s.Boyut = radioButton2.Text;

            //extralar için

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)//bir checkbox secili ise
                    
                    s.Extralar += item.Text + ",";//extralara +1 ekleme yapalım

            }

            //alttaki if ilede sondaki eklenen , işaretini kaldıralım
            if (!string.IsNullOrEmpty(s.Extralar))
                s.Extralar = s.Extralar.Remove(s.Extralar.Length - 1);

            s.Adet = Convert.ToInt32(numericUpDown1.Value);

            s.TutarHesapla();
            return s;

        }
     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            comboBox1.SelectedIndex = -1;  comboBox1.Enabled = true;
            comboBox2.SelectedIndex = -1;   comboBox2.Enabled = true;
            comboBox3.SelectedIndex = -1;  comboBox3.Enabled = true;
            comboBox4.SelectedIndex = -1;
            numericUpDown1.Value = 1;
            radioButton1.Checked = true;

            foreach (CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                    item.Checked = false;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal toplam_tutar = 0;




            //biz burda listboxtaki siparislere baglıyız(controle baglayız)
            //genelde yapılan ise controle bagımlı olmamak!!

            //ilk olarak siparis[] dizisi olusturarak yenisiparisi diziye aktararak yapabiliriz ancak 
            //dizilerde ram i aktif kullanmak istiyorsak boyutu kendimiz belirlememiz lazım ve diziler aynı tip verileri tutan yapılardır:

            //en mantıklısı ve güzeli generic list<> yapısıdır:

            //listboxtaki tüm satırları gez:

            //   foreach (var item in lstSiparis.Items)
            // {
            //     siparis s = (siparis)item;
            ///   toplam_tutar += s.SiparisTutari;



            //}

            //artık yukarda tanımladıgım siparisler dizisi ile listboxa bagımlılıgı kaldırıp
            //toplamtutar generic dizi yardımı ile hesaplayalım:

            foreach (siparis item in siparisler)
                {
                    toplam_tutar += item.SiparisTutari;
                }



            MessageBox.Show(string.Format("{0} adet siparis bulunmaktadır! \n toplam siparis tutarı:{1:C}", siparisler.Count, toplam_tutar));
        }
    }
}
