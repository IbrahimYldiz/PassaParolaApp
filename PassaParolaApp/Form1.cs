using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParolaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            linkLabel1.Text = "Sonraki Soru";
            soruno++;

            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                BtnA.BackColor = Color.Black;
                richTextBox1.Text = "Anavarza antik şehri nerede bulunmaktadır?";
                BtnSec.Text = "A";
                linkLabel1.Enabled = false;


            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Türkiye'de ve Türk tarihinde ilk kez toplu olarak şehirlerarası yolcu taşımalığı hangi ilimizde başlamıştır? ";
                BtnSec.Text = "B";
                BtnB.BackColor = Color.Black;
                linkLabel1.Enabled = false;
            }
            if (soruno == 3)
            {
                BtnSec.Text = "C";
                richTextBox1.Text = "Türkiye'nin üçüncü ve ilk sivil Cumhurbaşkanı olan Cumhurbaşkanımız kimdir?";
                BtnC.BackColor = Color.Black;
                linkLabel1.Enabled = false;
            }

            if (soruno == 4)
            {
                BtnD.BackColor = Color.Black;
                BtnSec.Text = "D";
                richTextBox1.Text = "Dünyanın Doğal Tek Antik Havuzu nederedir?";
                linkLabel1.Enabled = false;

            }
            if (soruno == 5)
            {
                BtnE.BackColor = Color.Black;
                BtnSec.Text = "E";
                richTextBox1.Text = "Alaca Höyük kazısı nerede yapılmıştır?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 6)
            {
                BtnF.BackColor = Color.Black;
                BtnSec.Text = "F";
                richTextBox1.Text = "Eskiden insanların bir yerden başka bir yere gitmek için kullandıkları, günümüzdeki taksi görevi göreven aracın adı nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 7)
            {
                BtnG.BackColor = Color.Black;
                BtnSec.Text = "G";
                richTextBox1.Text = "Fındığın ve Kirazın Anavatanı olarak bilenen yer neresidir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 8)
            {
                BtnH.BackColor = Color.Black;
                BtnSec.Text = "H";
                richTextBox1.Text = "Mustafa Kemal Atatürk'ün şahsi davası olarak söylenen ve Türkiye sınırlarına daha sonradan dahil olan yer neresidir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 9)
            {
                BtnI.BackColor = Color.Black;
                BtnSec.Text = "I";
                richTextBox1.Text = "Göller yöresi olarak bilenen, Gülü ve Halısıyla ünlü olan yer neresidir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 10)
            {
                Btnİ.BackColor = Color.Black;
                BtnSec.Text = "İ";
                richTextBox1.Text = "2010 yılında Dünya Kültür Başkenti seçilen yer neresidir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 11)
            {
                BtnJ.BackColor = Color.Black;
                BtnSec.Text = "J";
                richTextBox1.Text = "Daha öncesinde Genelkurmay Başkanlığı bünyesinde olan 27 Temmuz 2016 tarihinden " +
                    "itibaren İçişleri Bakanlığı bünyesinde görev yapmaya başlayan teşkilatımız nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 12)
            {
                BtnK.BackColor = Color.Black;
                BtnSec.Text = "K";
                richTextBox1.Text = "17 Ağustos 1999 yılında meydana gelen ve binlerce vatandaşımızın vefat ettiği deprem hangi ilimizde olmuştur?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 13)
            {
                BtnL.BackColor = Color.Black;
                BtnSec.Text = "L";
                richTextBox1.Text = "Türkiye'nin kuruluş anlaşması olan ve süresiz anlaşma olmasına rağmen 2023 yılında son " +
                    "bulunacağı söylenen anlaşmanın adı nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 14)
            {
                BtnM.BackColor = Color.Black;
                BtnSec.Text = "M";
                richTextBox1.Text = "Ekşili Balık yemeğiyle ünlü şehrimizin adı nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 15)
            {
                BtnN.BackColor = Color.Black;
                BtnSec.Text = "N";
                richTextBox1.Text = "Uluslararası alanda hizmet veren, kullanıcıya uygun ücretlerle sınırsız dizi ve " +
                    "filim izleme hizmeti veren firmanın adı nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 16)
            {
                BtnO.BackColor = Color.Black;
                BtnSec.Text = "O";
                richTextBox1.Text = "Uludağ kimin önderisle şuandaki adını almıştır? ";
                linkLabel1.Enabled = false;
            }
            if (soruno == 17)
            {
                BtnP.BackColor = Color.Black;
                BtnSec.Text = "P";
                richTextBox1.Text = "Genelde çocukların aldığı, değişik renklerde olan, pamuksu bir yapıya sahip olan ve " +
                    "sokakta ya da işletmelerde şekerden yapılan tatlının adı nedir? ";
                linkLabel1.Enabled = false;
            }
            if (soruno == 18)
            {
                BtnR.BackColor = Color.Black;
                BtnSec.Text = "R";
                richTextBox1.Text = "Osmanlı Dönemi'nde halka verilen isim nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 19)
            {
                BtnS.BackColor = Color.Black;
                BtnSec.Text = "S";
                richTextBox1.Text = "Mustafa Kemal Atatürk'ün kurtuluş savaşını başlattığı yer olarak bilenen yerin adı nedir? ";
                linkLabel1.Enabled = false;
            }
            if (soruno == 20)
            {
                BtnT.BackColor = Color.Black;
                BtnSec.Text = "T";
                richTextBox1.Text = "Eleştiri kelimesiyle aynı anlamı taşıyan kelime";
                linkLabel1.Enabled = false;
            }
            if (soruno == 21)
            {
                BtnU.BackColor = Color.Black;
                BtnSec.Text = "U";
                richTextBox1.Text = "Osmanlı Dönemi'de üst düzey din adamlarına verilen isim";
                linkLabel1.Enabled = false;
            }
            if (soruno == 22)
            {
                BtnV.BackColor = Color.Black;
                BtnSec.Text = "V";
                richTextBox1.Text = "Cumhurbaşkanı'nın illerdeki temsilcine ne ad verilir?";
                linkLabel1.Enabled = false;

            }
            if (soruno == 23)
            {
                BtnY.BackColor = Color.Black;
                BtnSec.Text = "Y";
                richTextBox1.Text = "Su kaynağı olarak nitelendirilen ve ülkemizde büyük oranda azalma olan bu kaynağının adı nedir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 24)
            {
                BtnZ.BackColor = Color.Black;
                BtnSec.Text = "Z";
                richTextBox1.Text = "Covid-19 salgının ülkemize ilk geldiği sıralarda, büyük şehirlerle birlikte kısıtlamalara uğrayan şehrimiz neresidir?";
                linkLabel1.Enabled = false;
            }
            if (soruno == 25)
            {
                string a = Convert.ToString(dogru);

                if (dogru > yanlis)
                {

                    MessageBox.Show( "Doğru: " + a + " " + "Yanlış:" + yanlis );
                }
                if (yanlis > dogru)
                {
                    MessageBox.Show( "Doğru: " + a + " " + "Yanlış:" + yanlis );
                }
                if (dogru == yanlis)
                {
                    MessageBox.Show( "Doğru: " + a + " " + "Yanlış:" + yanlis );
                }

            }


        }

        void temizle()
        {
            textBox1.Text = "";
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text.ToUpper() == "ADANA")
                        {
                            BtnA.BackColor = Color.Green; label2.Text = dogru.ToString();
                            linkLabel1.Enabled = true;
                            dogru++;
                            label2.Text = dogru.ToString();
                            temizle();
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: ADANA");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 2:
                        if (textBox1.Text.ToUpper() == "BURSA")
                        {
                            BtnB.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: BURSA");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 3:
                        if (textBox1.Text.ToUpper() == "CELAL BAYAR")
                        {
                            BtnC.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: CELAL BAYAR");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 4:
                        if (textBox1.Text.ToUpper() == "DENİZLİ")
                        {
                            BtnD.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: DENİZLİ");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 5:
                        if (textBox1.Text.ToUpper() == "ERZURUM")
                        {
                            BtnE.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: ERZURUM");
                            linkLabel1.Enabled = true; 
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 6:
                        if (textBox1.Text.ToUpper() == "FAYTON")
                        {
                            BtnF.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: FAYTON");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();

                        }
                        break;
                    case 7:
                        if (textBox1.Text.ToUpper() == "GİRESUN")
                        {
                            BtnG.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: GİRESUN");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 8:
                        if (textBox1.Text.ToUpper() == "HATAY")
                        {
                            BtnH.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: HATAY");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 9:
                        if (textBox1.Text.ToUpper() == "ISPARTA")
                        {
                            BtnI.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnI.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: ISPARTA");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 10:
                        if (textBox1.Text.ToUpper() == "İSTANBUL")
                        {
                            Btnİ.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            Btnİ.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: İSTANBUL");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 11:
                        if (textBox1.Text.ToUpper() == "JANDARMA")
                        {
                            BtnJ.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnJ.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: JANDARMA");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 12:
                        if (textBox1.Text.ToUpper() == "KOCAELİ")
                        {
                            BtnK.BackColor = Color.Green;
                            linkLabel1.Enabled = true; 
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnK.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: KOCAELİ");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 13:
                        if (textBox1.Text.ToUpper() == "LOZAN")
                        {
                            BtnL.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnL.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: LOZAN");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 14:
                        if (textBox1.Text.ToUpper() == "MUĞLA")
                        {
                            BtnM.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnM.BackColor = Color.Red;
                            linkLabel1.Enabled = true;
                            MessageBox.Show("Doğru Cevap: MUĞLA");
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 15:
                        if (textBox1.Text.ToUpper() == "NETFLİX")
                        {
                            BtnN.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++;
                            label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnN.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: NETFLİX");
                            linkLabel1.Enabled = true;
                            yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 16:
                        if (textBox1.Text.ToUpper() == "OSMAN ŞEVKİ BEY")
                        {
                            BtnO.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnO.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: OSMAN ŞEVKİ BEY");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 17:
                        if (textBox1.Text.ToUpper() == "PAMUK ŞEKER")
                        {
                            BtnP.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnP.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: PAMUK ŞEKER");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 18:
                        if (textBox1.Text.ToUpper() == "REAYA")
                        {
                            BtnR.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnR.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: REAYA");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 19:
                        if (textBox1.Text.ToUpper() == "SAMSUN")
                        {
                            BtnS.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnS.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: SAMSUN");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 20:
                        if (textBox1.Text.ToUpper() == "TENKİT")
                        {
                            linkLabel1.Enabled = true;
                            BtnT.BackColor = Color.Green; dogru++; label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnT.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: TENKİT");
                            linkLabel1.Enabled = true; yanlis++; label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 21:
                        if (textBox1.Text.ToUpper() == "ULEMA")
                        {
                            BtnU.BackColor = Color.Green;
                            linkLabel1.Enabled = true;
                            dogru++;
                            label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnU.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: ULEMA");
                            linkLabel1.Enabled = true; yanlis++;
                            label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 22:
                        if (textBox1.Text.ToUpper() == "VALİ")
                        {
                            BtnV.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++;
                            label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnV.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: VALİ"); linkLabel1.Enabled = true; yanlis++;
                            label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 23:
                        if (textBox1.Text.ToUpper() == "YERALTI SU KAYNAĞI")
                        {
                            BtnY.BackColor = Color.Green;
                            linkLabel1.Enabled = true; dogru++;
                            label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnY.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: YERALTI SU KAYNAĞI");
                            linkLabel1.Enabled = true; yanlis++;
                            label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                    case 24:
                        if (textBox1.Text.ToUpper() == "ZONGULDAK")
                        {
                            BtnZ.BackColor = Color.Green; linkLabel1.Enabled = true; dogru++;
                            label2.Text = dogru.ToString(); temizle();
                        }
                        else
                        {
                            BtnZ.BackColor = Color.Red;
                            MessageBox.Show("Doğru Cevap: Zonguldak");
                            linkLabel1.Enabled = true; yanlis++;
                            label4.Text = yanlis.ToString(); temizle();
                        }
                        break;
                }
            }

        }
        private void BtnSec_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "Başla";

        }
    }
}



