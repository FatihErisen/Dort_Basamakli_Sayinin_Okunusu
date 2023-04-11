namespace Odev_Fatih_Erisen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            this.Width = 550;
            string[] rakamlarYaziyla = new string[10] {"S�f�r", "Bir", "�ki", "��", "D�rt", "Be�",
                "Alt�","Yedi","Sekiz","Dokuz" };
            List<int> Rakamlar = new List<int>();
            string Yazdir="";
            int sayi;
            int Birler;
            int Onlar;
            int Yuzler;
            int Binler;
            sayi=int.Parse(txtSayi.Text);
            if (sayi>999 && sayi < 10000)
            {
                while (sayi > 0)
                {
                    Rakamlar.Add(sayi % 10);
                    sayi = sayi / 10;
                }
                Rakamlar.Reverse();
                if (Rakamlar[0] == 1)
                    Yazdir += " Bin ";
                else
                    Yazdir += rakamlarYaziyla[Rakamlar[0]] + " Bin ";
                if (Rakamlar[1] == 1)
                    Yazdir += " Y�z";
                else if (Rakamlar[1] > 2)
                    Yazdir += rakamlarYaziyla[Rakamlar[1]] + " Y�z";
                else
                    Yazdir += "";

                switch (Rakamlar[2])
                {
                    case 1: Yazdir += " On"; break;
                    case 2: Yazdir += " Yirmi"; break;
                    case 3: Yazdir += " Otuz"; break;
                    case 4: Yazdir += " K�rk"; break;
                    case 5: Yazdir += " Elli"; break;
                    case 6: Yazdir += " Atm��"; break;
                    case 7: Yazdir += " Yetmi�"; break;
                    case 8: Yazdir += " Seksen"; break;
                    case 9: Yazdir += " Doksan"; break;
                    default: break;
                }

                if (Rakamlar[3] != 0)
                    Yazdir += " " + rakamlarYaziyla[Rakamlar[3]];

                lblYazi.Text = Yazdir;
            }
            else lblYazi.Text = "Hatal� Giri� Yapt�n�z";




        }
    }
}