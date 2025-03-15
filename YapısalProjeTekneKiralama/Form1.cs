using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapısalProje._22295639
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Hocam basit, kullanışsız ve uzun bir kod olduğunun farkındayım.
        //Dizilerle yapmayı denedim ama bilmediğim çok şey vardı ve AI'dan kopya çekerek de yaptırmak istemedim
        //Elimden gelen bu kadardı saygılar.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text == "GULET 16M")
            {
                listBox1.Items.Add("Nisan:400€      Mayıs:450€ ");
                listBox1.Items.Add("Haziran:500€     Temmuz:550€");
                listBox1.Items.Add("Ağustos: 550€     Eylül: 500€ ");
                listBox1.Items.Add("Ekim: 450€");
            }
            if (comboBox1.Text == "GULET 15M")
            {
                listBox1.Items.Add("Nisan:500€      Mayıs:700€  ");
                listBox1.Items.Add(" Haziran:750€    Temmuz:850€");
                listBox1.Items.Add(" Ağustos:900€     Eylül:750€ ");
                listBox1.Items.Add("Ekim:700€");
            }
            if (comboBox1.Text == "GULET 14M")
            {
                listBox1.Items.Add("Nisan:250€      Mayıs:400€  ");
                listBox1.Items.Add("Haziran:550€     Temmuz:650€ ");
                listBox1.Items.Add("Ağustos:650€      Eylül:550€");
                listBox1.Items.Add("Ekim:400€");
            }
          
            if (comboBox1.Text == "MOTOR YAT 16M")
            {
                listBox1.Items.Add("Nisan:1250TL      Mayıs:1500TL   ");
                listBox1.Items.Add("Haziran:1750TL     Temmuz:2000TL");
                listBox1.Items.Add("Ağustos:2000TL      Eylül:1750TL ");
                listBox1.Items.Add("Ekim:1500TL");
            }

            if (comboBox1.Text == "MOTOR YAT 15M")
            {
                listBox1.Items.Add("Nisan:900TL      Mayıs:1000TL   ");
                listBox1.Items.Add("Haziran:1100TL    Temmuz:1200TL");
                listBox1.Items.Add("Ağustos:1200TL     Eylül:1100TL ");
                listBox1.Items.Add("Ekim:1000TL");
            }
            if (comboBox1.Text == "MOTOR YAT 14M")
            {
                listBox1.Items.Add("Nisan:600TL      Mayıs:750TL  ");
                listBox1.Items.Add("Haziran:900TL     Temmuz:1200TL ");
                listBox1.Items.Add("Ağustos:1200TL     Eylül:900TL ");
                listBox1.Items.Add("Ekim:750TL ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //GULET HESAPLAMASI İÇİN AŞAĞIDA Kİ İŞLEMLER//
            
            string uzunluk, ay;

            uzunluk = comboBoxUzunluk.Text;
            ay = comboBoxAy.Text;

            DateTime date1 = dateTimePicker1.Value;

            DateTime date2 = dateTimePicker2.Value;

            TimeSpan difference = date2 - date1;
           
            int kiralamaGunSayisi = difference.Days+2;

         

            if (difference < TimeSpan.Zero)
            {
                MessageBox.Show("HATALI İŞLEM!! BİTİŞ TARİHİ BAŞLANGIÇ TARİHİNDEN KÜÇÜK OLAMAZ");
            }
            else
            {

                if (uzunluk == "16M")
                {


                    if (ay == "Nisan")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 400;
                        MessageBox.Show("Kiralama günübirlik ücret: 400€" + "\n" +"Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());

                    }
                    else if (ay == "Mayıs")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 450;
                        MessageBox.Show("Kiralama günübirlik ücret: 450€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Haziran")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 500;
                        MessageBox.Show("Kiralama günübirlik ücret: 500€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Temmuz")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 550;
                        MessageBox.Show("Kiralama günübirlik ücret: 550€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Ağustos")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 550;
                        MessageBox.Show("Kiralama günübirlik ücret: 550€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Eylül")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 500;
                        MessageBox.Show("Kiralama günübirlik ücret: 500€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Ekim")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 450;
                        MessageBox.Show("Kiralama günübirlik ücret: 450€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else
                    {
                        MessageBox.Show("HATALI İŞLEM!! LÜTFEN BULUNAN YERDEN İŞLEM SEÇİNİZ!");
                    }

                }
                if (uzunluk == "15M")



                {
                    if (ay == "Nisan")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 500;
                        MessageBox.Show("Kiralama günübirlik ücret: 500€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Mayıs")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 700;
                        MessageBox.Show("Kiralama günübirlik ücret: 700€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Haziran")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 750;
                        MessageBox.Show("Kiralama günübirlik ücret: 750€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Temmuz")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 850;
                        MessageBox.Show("Kiralama günübirlik ücret: 850€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Ağustos")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 900;
                        MessageBox.Show("Kiralama günübirlik ücret: 900€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Eylül")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 750;
                        MessageBox.Show("Kiralama günübirlik ücret: 750€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Ekim")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 700;
                        MessageBox.Show("Kiralama günübirlik ücret: 700€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else
                    {
                        MessageBox.Show("HATALI İŞLEM!! LÜTFEN BULUNAN YERDEN İŞLEM SEÇİNİZ!");
                    }

                }
                if (uzunluk == "14M")
                {


                    if (ay == "Nisan")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 250;
                        MessageBox.Show("Kiralama günübirlik ücret: 250€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Mayıs")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 400;
                        MessageBox.Show("Kiralama günübirlik ücret: 400€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Haziran")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 550;
                        MessageBox.Show("Kiralama günübirlik ücret: 550€" + "\n" + "Kiralama günübirlik ücret: 450€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Temmuz")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 600;
                        MessageBox.Show("Kiralama günübirlik ücret: 600€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Ağustos")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 650;
                        MessageBox.Show("Kiralama günübirlik ücret: 650€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Eylül")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 550;
                        MessageBox.Show("Kiralama günübirlik ücret: 550€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else if (ay == "Ekim")
                    {
                        int kiralamaUcreti = kiralamaGunSayisi * 400;
                        MessageBox.Show("Kiralama günübirlik ücret: 400€" + "\n" + "Kiralama ücreti: " + kiralamaUcreti.ToString() + "€" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi.ToString());
                    }
                    else
                    {
                        MessageBox.Show("HATALI İŞLEM!! LÜTFEN BULUNAN YERDEN İŞLEM SEÇİNİZ!");
                    }

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MOTOR YAT İÇİN HESAPLAMALAR//
            string uzunluk1, ay1;

            uzunluk1 = comboBoxUzunluk2.Text;
            ay1 = comboBoxAy2.Text;

            DateTime date3 = dateTimePicker3.Value;
            DateTime date4 = dateTimePicker4.Value;
          
            TimeSpan difference2 = date4 - date3;

            int kiralamaGunSayisi2 = difference2.Days+2;

            if (difference2 < TimeSpan.Zero)
            {
                MessageBox.Show("HATALI İŞLEM!! BİTİŞ TARİHİ BAŞLANGIÇ TARİHİNDEN KÜÇÜK OLAMAZ");
            }
            else { 
            
                if (uzunluk1 == "14M")
                {

                    if (ay1 == "Nisan")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 600;
                        MessageBox.Show("Kiralama günübirlik ücret: 600Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Mayıs")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 750;
                        MessageBox.Show("Kiralama günübirlik ücret: 750Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Haziran")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 900;
                        MessageBox.Show("Kiralama günübirlik ücret: 900Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Temmuz")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1200;
                        MessageBox.Show("Kiralama günübirlik ücret: 1200Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Ağustos")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1200;
                        MessageBox.Show("Kiralama günübirlik ücret: 1200Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Eylül")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 900;
                        MessageBox.Show("Kiralama günübirlik ücret: 900Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Ekim")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 750;
                        MessageBox.Show("Kiralama günübirlik ücret: 750Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else
                    {
                        MessageBox.Show("HATALI İŞLEM!! LÜTFEN BULUNAN YERDEN İŞLEM SEÇİNİZ!");
                    }

                }
                if (uzunluk1 == "15M")
                {

                    if (ay1 == "Nisan")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 900;
                        MessageBox.Show("Kiralama günübirlik ücret: 900Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Mayıs")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1000;
                        MessageBox.Show("Kiralama günübirlik ücret: 1000Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Haziran")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1100;
                        MessageBox.Show("Kiralama günübirlik ücret: 1100Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Temmuz")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1200;
                        MessageBox.Show("Kiralama günübirlik ücret: 1200Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Ağustos")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1200;
                        MessageBox.Show("Kiralama günübirlik ücret: 1200Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Eylül")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1100;
                        MessageBox.Show("Kiralama günübirlik ücret: 1100Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Ekim")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1000;
                        MessageBox.Show("Kiralama günübirlik ücret: 1000Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else
                    {
                        MessageBox.Show("HATALI İŞLEM!! LÜTFEN BULUNAN YERDEN İŞLEM SEÇİNİZ!");
                    }

                }
                if (uzunluk1 == "16M")
                {


                    if (ay1 == "Nisan")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1250;
                        MessageBox.Show("Kiralama günübirlik ücret: 1250Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Mayıs")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1500;
                        MessageBox.Show("Kiralama günübirlik ücret: 1500Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Haziran")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1750;
                        MessageBox.Show("Kiralama günübirlik ücret: 1750Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Temmuz")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 2000;
                        MessageBox.Show("Kiralama günübirlik ücret: 2000Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Ağustos")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 2000;
                        MessageBox.Show("Kiralama günübirlik ücret: 2000Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Eylül")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1750;
                        MessageBox.Show("Kiralama günübirlik ücret: 1750Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else if (ay1 == "Ekim")
                    {
                        int kiralamaUcreti2 = kiralamaGunSayisi2 * 1500;
                        MessageBox.Show("Kiralama günübirlik ücret: 1500Tl" + "\n" + "Kiralama ücreti: " + kiralamaUcreti2.ToString() + "TL" + "\n" + "Kiralanacak gün sayısı: " + kiralamaGunSayisi2.ToString());
                    }
                    else
                    {
                        MessageBox.Show("HATALI İŞLEM!! LÜTFEN BULUNAN YERDEN İŞLEM SEÇİNİZ!");
                    }

                }
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Güncel tarihde itibaren ve sonraki 8 ay için isşlem yaptırdım
            //Nisan ayı geçtiği için müşteri oradan zaten kiralama yapamaz diye düşündüm
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddMonths(8);
            dateTimePicker2.MinDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today.AddMonths(8);
            dateTimePicker3.MinDate = DateTime.Today;
            dateTimePicker3.MaxDate = DateTime.Today.AddMonths(8);
            dateTimePicker4.MinDate = DateTime.Today;
            dateTimePicker4.MaxDate = DateTime.Today.AddMonths(8);
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUzunluk2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxUzunluk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

