using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_2
{
    public partial class Form2 : Form
    {
        
        int Satir, Sutun;
        int[,] Matris;
        int[,] TMatris;
        float[,] AxTMatris;
        float[,] TxAMatris;
        double[,] DAxTMatris;
        double[,] DTxAMatris;
        double[,] bmatris;
        double[,] cmatris;

        double[,] b1matris;//en sonki sonuc
        double[,] c1matris;//en sonki sonuc

        public int[,] matrisilkhal;

        public Form2()
        {
            InitializeComponent();
        }
        public static int carpmadegiskeni = 0;
        public static int toplamadegiskeni = 0;
        public static int cikarmadegiskeni = 0;
        public static int bölmedegiskeni = 0;

        
        public void   carpmasayma()
        {
            carpmadegiskeni += 1;
            
        }
        public void toplamsayma()
        {
            toplamadegiskeni += 1;

        }
        public void cıkarmasayma()
        {
            cikarmadegiskeni += 1;

        }
        public void bölmesayma()
        {
            bölmedegiskeni += 1;

        }


        public Form2(string MatrisTuru)
        {
            InitializeComponent();  
            MatrisAlanlariniGizle();
            if (MatrisTuru == "RASTGELE") // rastgele matris oluşturulacaksa
            {
                RastgeleMatrisOlustur();
                label1.Text = "Matris rastgele oluşturuldu.";
                numericUpDownSatir.Enabled = false;
                numericUpDownSutun.Enabled = false;
                buttonMatrisOlustur.Enabled = false;
            }
            else // random matris degilse 
            {
                label1.Text = "Matris verilerini giriniz.";
            }
        }

        public void MatrisAlanlariniGizle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // tüm matris alanları ismine göre aranıyor ve gizleniyor
                    Control control = groupBox1.Controls.Find("numericUpDown" + i.ToString() + j.ToString(), false)[0];
                    NumericUpDown n = (NumericUpDown)control;
                    n.Visible = false;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void RastgeleMatrisOlustur()
        {
            Satir = RandomSayiUret(1, 5);
            Sutun = RandomSayiUret(1, 5);
            while (Satir == Sutun) // satır ve sütun aynı ise farklı olana kadar random sayı üretmek icin 
            {
                Satir = RandomSayiUret(1, 5);
                Sutun = RandomSayiUret(1, 5);
            }

            Matris = new int[Satir, Sutun];
            numericUpDownSatir.Value = Satir;
            numericUpDownSutun.Value = Sutun;
            for (int i = 0; i < Satir; i++)
            {
                for (int j = 0; j < Sutun; j++)
                {
                    Matris[i, j] = RandomSayiUret(1, 9); // rastgele 1, 9 arasında sayı uretıyoruz  burdan xddsa


                    // matris alanları isme göre tek tek bulunup matris değeri ilgili alana kopyalanıyor
                    Control control = groupBox1.Controls["numericUpDown" + i.ToString() + j.ToString()];
                    NumericUpDown n = (NumericUpDown)control;
                    n.Value = Matris[i, j];
                    n.Visible = true;
                    n.Enabled = false;
                }

            }
        }



        public void kullanicigirislimatrisolusturma()
        {
            Matris = new int[Satir, Sutun];

            for (int i = 0; i < Satir; i++)
            {
                for (int j = 0; j < Sutun; j++)
                {
                    Control control = groupBox1.Controls["numericUpDown" + i.ToString() + j.ToString()];
                    NumericUpDown n = (NumericUpDown)control;
                    n.Visible = true;
                }
            }
        }



        public void buttonMatrisOlustur_Click(object sender, EventArgs e)
        {
            MatrisAlanlariniGizle(); // her yeni matris oluşturulduğunda alanlar gizlenecek

            Satir = Convert.ToInt32(numericUpDownSatir.Value);
            Sutun = Convert.ToInt32(numericUpDownSutun.Value);

            if (Satir == Sutun)
            {
                MessageBox.Show("Satır ve sütun sayıları farklı olmalıdır!!!!!!!!!");
            }
            else
            {
                kullanicigirislimatrisolusturma();
            }
        }

        public void buttonMatrisTersiniAl_Click(object sender, EventArgs e)
        {

            //gf.Show();
            // kullanici girişli  matris ise verileri kutulardan almak için döngü
            int i, j;

            string matrixString3 = ""; // sutun>satirdan buyuk oldugunda kullanılan textboxa matrislerin carpimini yazdıran string
            string matrixString4 = "";// satir>sutundan buyuk oldugunda kullanılan textboxa matrislerin carpimini yazdıran string
            string matrixString5 = "";//sutun>satirdan buyuk oldugunda kullanılan textboxa gauss carpimini yazdıran string
            string matrixString6 = "";// satir>sutundan buyuk oldugunda kullanılan textboxa gauss carpimini yazdıran string
            string matrixString7 = "";//sutun>satirdan buyuk oldugunda kullanılan textboxa a tnın transpozu ile gauss matrisinin carpımını yazdıran string
            string matrixString8 = "";// satir>sutundan buyuk oldugunda kullanılan textboxa gauss matrisi ile a nın transpozunun carpimini yazdıran string
            for (i = 0; i < Satir; i++)
            {

                for (j = 0; j < Sutun; j++)
                {
                    Control control = groupBox1.Controls["numericUpDown" + i.ToString() + j.ToString()];
                    NumericUpDown n = (NumericUpDown)control;
                    Matris[i, j] = Convert.ToInt32(n.Value);
                }

            }


            // matrisin tersi işlemleri burada yapılacak

            // alınan matris consolda gosterdik ilk
            for (i = 0; i < Satir; i++)
            {
                for (j = 0; j < Sutun; j++)
                {
                    Console.Write(Matris[i, j] + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------transpoz asagisi");




            // transpoz alma matrisin trasnpozesini TMatrise atıyoruz.
            TMatris = new int[Sutun, Satir];

            for (i = 0; i < Sutun; i++)
            {
                for (j = 0; j < Satir; j++)
                {
                    TMatris[i, j] = Matris[j, i];
                    Console.Write(TMatris[i, j] + "\t");

                }

                Console.WriteLine();
            }


            Console.WriteLine("---------------transpoz asagisi");

            for (i = 0; i < TMatris.GetLength(0); i++)
            {
                for (j = 0; j < TMatris.GetLength(1); j++)
                {
                    Console.Write(TMatris[i, j] + "\t");

                }

                Console.WriteLine();
            }


            //2 matris carpımı
            //matris * transpoz 
            void tumfonk()
            {
                
               if (Sutun > Satir){
                    //sutun>satir dan ise
                    if (Matris.GetLength(1) == TMatris.GetLength(0))
                    {
                        AxTMatris = new float[Matris.GetLength(0), TMatris.GetLength(1)];
                        for (i = 0; i < AxTMatris.GetLength(0); i++)
                        {
                            
                            for (j = 0; j < AxTMatris.GetLength(1); j++)
                            {
                                AxTMatris[i, j] = 0;
                               
                                for ( int k = 0; k < Matris.GetLength(1); k++) // OR k<b.GetLength(0)
                                    AxTMatris[i, j] = AxTMatris[i, j] + Matris[i, k] * TMatris[k, j];
                                     carpmadegiskeni++;
                                    toplamadegiskeni++;


                            }
                        }
                    }
                    

                    else
                    {
                        Console.WriteLine("\n Mmatrisini sutun sayisi ile TMatrisinin satir sayisi eşit olmak zorundadir...");
                        Console.WriteLine("\n lutfen dogru girin");
                        Environment.Exit(-1);
                    }


                    Console.Write("matrislerin carpımının sonucu :");

                    for (i = 0; i < AxTMatris.GetLength(0); i++)
                    {
                        for (j = 0; j < AxTMatris.GetLength(1); j++)
                        {
                            Console.Write(AxTMatris[i, j] + "\t");
                            
                        }
                        Console.WriteLine();
                    }


                   
                    for (i = 0; i < AxTMatris.GetLength(0); i++)
                    {
                        for (j = 0; j < AxTMatris.GetLength(1); j++)
                        {
                            matrixString3 += AxTMatris[i, j].ToString() + "\t";
                            matrixString3 += " ";
                        }
                        Console.WriteLine();

                        matrixString3 += Environment.NewLine;
                    }

                    //gauss

                    bmatris = new double[Satir, Satir];

                    for (i = 0; i < Satir; i++)
                    {
                        for (j = 0; j < Satir; j++)
                        {
                            if (i == j)
                            {
                                bmatris[i, j] = 1;
                            }
                            else
                            {
                                bmatris[i, j] = 0;
                            }

                        }
                    }
                    float d, k1;
                    for (i = 0; i < Satir; i++)
                    {
                        d = AxTMatris[i, i];
                        for (j = 0; j < Satir; j++)
                        {
                            AxTMatris[i, j] = AxTMatris[i, j] / d;
                            bölmedegiskeni++;
                            bmatris[i, j] = bmatris[i, j] / d;
                            bölmedegiskeni++;

                        }

                        for (int x = 0; x < Satir; x++)
                        {
                            if (x != i)
                            {
                                k1 = AxTMatris[x, i];
                                for (j = 0; j < Satir; j++)
                                {
                                    AxTMatris[x, j] = AxTMatris[x, j] - (AxTMatris[i, j] * k1);
                                    cikarmadegiskeni++;
                                    bmatris[x, j] = bmatris[x, j] - (bmatris[i, j] * k1);
                                    cikarmadegiskeni++;
                                    carpmadegiskeni++;
                                }
                            }

                        }
                    }
                  


                    Console.Write("gauss carpımı :");
                    for (i = 0; i < bmatris.GetLength(0); i++)
                    {
                        for (j = 0; j < bmatris.GetLength(1); j++)
                        {
                            Console.Write(bmatris[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }


                    Console.WriteLine();


                    for (i = 0; i < bmatris.GetLength(0); i++)
                    {
                        for (j = 0; j < bmatris.GetLength(1); j++)
                        {
                            matrixString5 += bmatris[i, j].ToString() + "\t";
                            matrixString5 += " ";
                        }
                        Console.WriteLine();

                        matrixString5 += Environment.NewLine;
                    }



                    //a nın tranpozesi ile gauss sonucunda cıkan matris carpımı
                    //gauss matris ile transpoz matrisin carpımı
                    //yani sutun >satir ise axt var burda



                    if (TMatris.GetLength(1) == bmatris.GetLength(0))
                    {
                        b1matris = new double[TMatris.GetLength(0), bmatris.GetLength(1)];
                        for (i = 0; i < b1matris.GetLength(0); i++)
                        {
                            for (j = 0; j < b1matris.GetLength(1); j++)
                            {
                                b1matris[i, j] = 0;
                                for (int k = 0; k < TMatris.GetLength(1); k++) // OR k<b.GetLength(0)
                                    b1matris[i, j] = b1matris[i, j] + TMatris[i, k] * bmatris[k, j];
                                    toplamadegiskeni++;
                                    carpmadegiskeni++;
                            }
                        }
                    }


                    else
                    {
                        Console.WriteLine("\n Mmatrisini sutun sayisi ile TMatrisinin satir sayisi eşit olmak zorundadir...");
                        Console.WriteLine("\n lutfen dogru girin");
                        Environment.Exit(-1);
                    }




                    Console.Write("transpoz matris ile gauss matrsiin  carpımı :");


                    for (i = 0; i < b1matris.GetLength(0); i++)
                    {
                        for (j = 0; j < b1matris.GetLength(1); j++)
                        {
                            Console.Write(b1matris[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }


                    for (i = 0; i < b1matris.GetLength(0); i++)
                    {
                        for (j = 0; j < b1matris.GetLength(1); j++)
                        {
                            matrixString7 += b1matris[i, j].ToString() + "\t";
                            matrixString7 += " ";
                        }
                        Console.WriteLine();

                        matrixString7 += Environment.NewLine;
                    }
             
                    Console.WriteLine(carpmadegiskeni);
                    Console.WriteLine(bölmedegiskeni);

                }


                else
                {
                    //satir>sutun dan ise
                    if (TMatris.GetLength(1) == Matris.GetLength(0))
                    {
                        TxAMatris = new float[TMatris.GetLength(0), Matris.GetLength(1)];
                        for (i = 0; i < TxAMatris.GetLength(0); i++)
                        {
                            for (j = 0; j < TxAMatris.GetLength(1); j++)
                            {
                                TxAMatris[i, j] = 0;
                                for (int k = 0; k < TMatris.GetLength(1); k++) // OR k<b.GetLength(0)
                                    TxAMatris[i, j] = TxAMatris[i, j] + TMatris[i, k] * Matris[k, j];
                                    toplamadegiskeni++;
                                    carpmadegiskeni++;
                            }
                        }
                    }
                   


                    else
                    {
                        Console.WriteLine("\n Mmatrisini sutun sayisi ile TMatrisinin satir sayisi eşit olmak zorundadir...");
                        Console.WriteLine("\n lutfen dogru girin");
                        Environment.Exit(-1);
                    }

                   

                    Console.Write("matrislerin carpımının sonucu :");

                    for (i = 0; i < TxAMatris.GetLength(0); i++)
                    {
                        for (j = 0; j < TxAMatris.GetLength(1); j++)
                        {
                            Console.Write(TxAMatris[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    for (i = 0; i < TxAMatris.GetLength(0); i++)
                    {
                        for (j = 0; j < TxAMatris.GetLength(1); j++)
                        {
                            matrixString4 += TxAMatris[i, j].ToString() + "\t";
                            matrixString4 += " ";
                        }
                        Console.WriteLine();

                        matrixString4 += Environment.NewLine;
                    }
                     //gauss


                    cmatris = new double[Sutun, Sutun];

                    for (i = 0; i < Sutun; i++)
                    {
                        for (j = 0; j < Sutun; j++)
                        {
                            if (i == j)
                            {
                                cmatris[i, j] = 1;
                            }
                            else
                            {
                                cmatris[i, j] = 0;
                            }

                        }
                    }
                    float d, k1;
                    for (i = 0; i < Sutun; i++)
                    {
                        d = TxAMatris[i, i];
                        for (j = 0; j < Sutun; j++)
                        {
                            TxAMatris[i, j] = TxAMatris[i, j] / d;
                            bölmedegiskeni++;
                            cmatris[i, j] = cmatris[i, j] / d;
                            bölmedegiskeni++;
                        }

                        for (int x = 0; x < Sutun; x++)
                        {
                            if (x != i)
                            {
                                k1 = TxAMatris[x, i];
                                for (j = 0; j < Sutun; j++)
                                {
                                    TxAMatris[x, j] = TxAMatris[x, j] - (TxAMatris[i, j] * k1);
                                    cikarmadegiskeni++;
                                    cmatris[x, j] = cmatris[x, j] - (cmatris[i, j] * k1);
                                    cikarmadegiskeni++;
                                }
                            }

                        }
                    }


                    Console.Write("gauss carpımı :");

                    for (i = 0; i < cmatris.GetLength(0); i++)
                    {
                        for (j = 0; j < cmatris.GetLength(1); j++)
                        {
                            Console.Write(cmatris[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }


                    Console.WriteLine();


                    for (i = 0; i < cmatris.GetLength(0); i++)
                    {
                        for (j = 0; j < cmatris.GetLength(1); j++)
                        {
                            matrixString6 += cmatris[i, j].ToString() + "\t";
                            matrixString6 += " ";
                        }
                        Console.WriteLine();

                        matrixString6 += Environment.NewLine;
                    }




                    //gauss matris ile transpoz matrisin carpımı
                    //yani satir >sutun ise TxAMatris var burda

                    if (cmatris.GetLength(1) == TMatris.GetLength(0))
                    {
                        c1matris = new double[cmatris.GetLength(0), TMatris.GetLength(1)];
                        for (i = 0; i < c1matris.GetLength(0); i++)
                        {
                            for (j = 0; j < c1matris.GetLength(1); j++)
                            {
                                c1matris[i, j] = 0;
                                for (int k = 0; k < cmatris.GetLength(1); k++) // OR k<b.GetLength(0)
                                    c1matris[i, j] = c1matris[i, j] + cmatris[i, k] * TMatris[k, j];
                                    toplamadegiskeni++;
                                    carpmadegiskeni++;
                            }
                        }
                    }



                    else
                    {
                        Console.WriteLine("\n Mmatrisini sutun sayisi ile TMatrisinin satir sayisi eşit olmak zorundadir...");
                        Console.WriteLine("\n lutfen dogru girin");
                        Environment.Exit(-1);
                    }



                    Console.Write("gauss matris ile transpoz matrisin carpımı :");

                    for (i = 0; i < c1matris.GetLength(0); i++)
                    {
                        for (j = 0; j < c1matris.GetLength(1); j++)
                        {
                            Console.Write(c1matris[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }



                    for (i = 0; i < c1matris.GetLength(0); i++)
                    {
                        for (j = 0; j < c1matris.GetLength(1); j++)
                        {
                            matrixString8 += c1matris[i, j].ToString() + "\t";
                            matrixString8 += " ";
                        }
                        Console.WriteLine();

                        matrixString8 += Environment.NewLine;
                    }

                }
                carpmadegiskeni = carpmadegiskeni + bölmedegiskeni;
                toplamadegiskeni = toplamadegiskeni + cikarmadegiskeni;


            }

            tumfonk();//tüm islemlerin yapildiği fonk

            

                //stringe cevirme 
                string matrixString = "";
            for (i = 0; i < Matris.GetLength(0); i++)
            {
                for (j = 0; j < Matris.GetLength(1); j++)
                {
                    matrixString += Matris[i, j].ToString() + "\t";
                    matrixString += " ";
                }
                Console.WriteLine();

                matrixString += Environment.NewLine;
            }


            string matrixString2 = "";
            for (i = 0; i < TMatris.GetLength(0); i++)
            {
                for (j = 0; j < TMatris.GetLength(1); j++)
                {
                    matrixString2 += TMatris[i, j].ToString() + "\t";
                    matrixString2 += " ";
                }
                Console.WriteLine();

                matrixString2 += Environment.NewLine;
            }

            //textboxa islemleri yazdırmak ıcın
            this.textBox1.Text = matrixString;     
            this.textBox2.Text = matrixString2;
            this.textBox3.Text = matrixString3 + matrixString4;
            this.textBox4.Text = matrixString5 + matrixString6;
            this.textBox5.Text = matrixString7 + matrixString8 + "\n bu işlem sonucunda " + carpmadegiskeni + "  carpım degiskeni " + "\nve " + toplamadegiskeni + "  toplama degiskeni kullanıldı:";

        }

        private static readonly Random getrandom = new Random();

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public static int RandomSayiUret(int minimum, int maksimum)
        {
             
                return getrandom.Next(minimum, maksimum);
            
        }
    }
}
