/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2     
**				ÖĞRENCİ ADI............: İsmail Üçel    
**				ÖĞRENCİ NUMARASI.......: G201210352
**              DERSİN ALINDIĞI GRUP...: 2.Öğretim A Grubu
****************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Odev2_Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //değişken tanımlamaları yapıldı

        public static int satırA;
        public static int sütunA;
        public static int satırB;
        public static int sütunB;
        public static double[,] matrixA;
        public static string yazdIrMA;
        public static string yazdIrMB;
        public static string yazdIrMC;
        public static double[,] matrixB;
        public static double[,] matrixC;
        public static string yol = Environment.CurrentDirectory + @"\log.txt";  //yazdırılan işlemlerin gönderildiği yer


        //olustur butonuna tıklandığında yapılacaklar
        private void btnOlusturA_Click(object sender, EventArgs e)
        {
            //eger degerler gecerli ise
            if (GecerliMiA())
            {
                try
                {
                    yazdIrMA = "";                                          //yazdırılacak string
                    satırA = Convert.ToInt32(txtSatırA.Text);
                    sütunA = Convert.ToInt32(txtSütunA.Text);               //oluşturalacak satır, sütun sayısı alınıyor
                    matrixA = new double[satırA, sütunA];                   //matris oluşturulacak
                    Matrisİslemleri.matrisOlustur(satırA, sütunA, matrixA); //matris oluşturuluyor
                    txtMatrixA.Text = Matrisİslemleri.matrisYazdır(satırA, sütunA, yazdIrMA, matrixA);      //yazdırma işlemi


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        //olustur butonuna tıklandığında yapılacaklar
        private void btnOlusturB_Click(object sender, EventArgs e)
        {
            //eger degerler gecerli ise
            if (GecerliMiB())
            {
                try
                {


                    yazdIrMB = "";                                  //yazdırılacak string
                    satırB = Convert.ToInt32(txtSatırB.Text);
                    sütunB = Convert.ToInt32(txtSütunB.Text);       //oluşturalacak satır, sütun sayısı alınıyor
                    matrixB = new double[satırB, sütunB];           //matris oluşturulacak
                    Matrisİslemleri.matrisOlustur(satırB, sütunB, matrixB);         //matris oluşturuluyor
                    txtMatrixB.Text = Matrisİslemleri.matrisYazdır(satırB, sütunB, yazdIrMB, matrixB);      //yazdırma işlemi


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        //birim matris yap butonuna tıklandığında yapılacaklar
        private void btnBBirim_Click(object sender, EventArgs e)
        {
            //eger degerler gecerli ise
            if (GecerliMiB())
            {
                try
                {
                    yazdIrMB = "";                                      //yazdırılacak string
                    satırB = Convert.ToInt32(txtSatırB.Text);
                    sütunB = Convert.ToInt32(txtSütunB.Text);           //oluşturalacak satır, sütun sayısı alınıyor
                    matrixB = new double[satırB, sütunB];               //matris oluşturulacak            
                    Matrisİslemleri.birimMatris(satırB, sütunB, matrixB);       //matris oluşturuluyor
                    txtMatrixB.Text = Matrisİslemleri.matrisYazdır(satırB, sütunB, yazdIrMB, matrixB);      //yazdırma işlemi

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Hesapla butonuna tıklandığında yapılacaklar
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //eğer toplama radiobutton basıldıysa
            if (rdbtnTopla.Checked == true)
            {
                //eger toplama için kullanılacak degerler gecerli ise
                if (Matrisİslemleri.toplamaKontrol(satırA, satırB, sütunA, sütunB))
                {
                    yazdIrMC = "";                                          //yazdırılacak string
                    matrixC = new double[satırA, satırB];                    //matris oluşturulacak       
                    Matrisİslemleri.matrisEkle(satırA, satırB, sütunA, sütunB, matrixA, matrixB, matrixC); //ekleme işlemi yapılıyor
                    txtMatrixC.Text = Matrisİslemleri.matrisYazdır(satırA, sütunA, yazdIrMC, matrixC);      //yazdırma işlemi
                }
            }

            //eğer iz radiobutton basıldıysa
            if (rdbtnİz.Checked == true)
            {
                //eger iz için kullanılacak degerler gecerli ise
                if (Matrisİslemleri.izKontrol(satırA, sütunA))
                {
                    yazdIrMC = "";                                  //yazdırılacak string
                    double sum = 0;                                 //toplama değeri oluşturuluyor
                    matrixC = new double[satırA, sütunA];           //matris oluşturulacak 
                    Matrisİslemleri.matrisizBul(sum, satırA, sütunA, matrixA);      //iz işlemi yapılıyor

                }
            }

            //eğer ters radiobutton basıldıysa
            if (rdbtnTers.Checked == true)
            {
                //eger ters için kullanılacak degerler gecerli ise
                if (Matrisİslemleri.tersKontrol(satırA, sütunA))
                {
                    yazdIrMC = "";                                 //yazdırılacak string
                    matrixC = new double[satırA, sütunA];           //matris oluşturulacak 
                    Matrisİslemleri.matrisTers(matrixA, matrixC, satırA);   //ters işlemi yapılıyor
                    txtMatrixC.Text = Matrisİslemleri.matrisYazdır(satırA, sütunA, yazdIrMC, matrixC);  //yazdırma işlemi
                }
            }

            //eğer transpoze radiobutton basıldıysa
            if (rdbtnTranspoze.Checked == true)
            {
                //eger transpoze için kullanılacak degerler gecerli ise
                if (Matrisİslemleri.transpozeKontrol(satırA, sütunA))
                {
                    yazdIrMC = "";                                //yazdırılacak string
                    matrixC = new double[satırA, sütunA];           //matris oluşturulacak 
                    Matrisİslemleri.matrisTranspoze(satırA, sütunA, matrixA, matrixC);      //transpoze işlemi yapılıyor
                    txtMatrixC.Text = Matrisİslemleri.matrisYazdır(satırA, sütunA, yazdIrMC, matrixA);   //yazdırma işlemi
                }
            }


            //eğer cıkarma radiobutton basıldıysa
            if (rdbtnCıkarma.Checked == true)
            {
                //eger çıkarma için kullanılacak degerler gecerli ise
                if (Matrisİslemleri.toplamaKontrol(satırA, satırB, sütunA, sütunB))
                {
                    yazdIrMC = "";                                //yazdırılacak string
                    matrixC = new double[satırA, satırB];           //matris oluşturulacak 
                    Matrisİslemleri.matrisCıkar(satırA, satırB, sütunA, sütunB, matrixA, matrixB, matrixC);      //çıkarma işlemi yapılıyor
                    txtMatrixC.Text = Matrisİslemleri.matrisYazdır(satırA, sütunA, yazdIrMC, matrixC);      //yazdırma işlemi
                }
            }

            //eğer çarpma radiobutton basıldıysa
            if (rdbtnCarp.Checked == true)
            {
                //eger çarpma için kullanılacak degerler gecerli ise
                if (Matrisİslemleri.carpmaKontrol(satırA, sütunB))
                {
                    yazdIrMC = "";                                //yazdırılacak string
                    matrixC = new double[satırA, sütunB];          //matris oluşturulacak 
                    Matrisİslemleri.matrisCarpma(satırA, satırB, sütunA, sütunB, matrixA, matrixB, matrixC);      //çarpma işlemi yapılıyor
                    txtMatrixC.Text = Matrisİslemleri.matrisYazdır(satırA, sütunB, yazdIrMC, matrixC);      //yazdırma işlemi
                }
            }

        }

        //Matris Sil butonuna tıklandığında yapılacaklar
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSatırA.Text = "3";
            txtSütunA.Text = "3";
            txtSatırB.Text = "3";       //satır ve sütun sayısı default olarak 3
            txtSütunB.Text = "3";

            matrixA = new double[satırA, sütunA];
            matrixB = new double[satırB, sütunB];

            txtMatrixA.Text = "";
            txtMatrixB.Text = "";
            txtMatrixC.Text = "";
        }


        //programdan çıkış yapma butonuna tıklandığında yapılacaklar
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //satır a sayısı değiştiğinde yapılacaklar
        private void txtSatırA_TextChanged(object sender, EventArgs e)
        {
            if (txtSatırA.Text != "")
            {
                try
                {
                    Int32.Parse(txtSatırA.Text);    //integeri al
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İnteger gir. " + ex.ToString());       //integer girilmezse bu uyarıyı verir
                }
            }
        }

        //sütun a sayısı değiştiğinde yapılacaklar
        private void txtSütunA_TextChanged(object sender, EventArgs e)
        {
            if (txtSütunA.Text != "")
            {
                try
                {
                    Int32.Parse(txtSütunA.Text);        //integeri al
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İnteger gir. " + ex.ToString());       //integer girilmezse bu uyarıyı verir
                }
            }
        }

        //satır b sayısı değiştiğinde yapılacaklar
        private void txtSatırB_TextChanged(object sender, EventArgs e)
        {
            if (txtSatırB.Text != "")
            {
                try
                {
                    Int32.Parse(txtSatırB.Text);        //integeri al
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İnteger gir. " + ex.ToString());       //integer girilmezse bu uyarıyı verir
                }
            }
        }

        //sütun b sayısı değiştiğinde yapılacaklar
        private void txtSütunB_TextChanged(object sender, EventArgs e)
        {
            if (txtSütunB.Text != "")
            {
                try
                {
                    Int32.Parse(txtSütunB.Text);        //integeri al
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İnteger gir. " + ex.ToString());       //integer girilmezse bu uyarıyı verir
                }
            }
        }

        //tüm değerler girildi mi kontrol ediyor
        static public bool TamMı(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " doldurma eksik.", "Giris Hatası");      //girilmediyse hata veriyor
                textBox.Focus();
                return false;
            }
            return true;
        }

        //tüm değerler int mi kontrol ediyor
        static public bool IntMi(TextBox textBox, string name)
        {
            Int32 number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " integer gir.", "Giris Hatası");
                textBox.Focus();
                return false;
            }
        }

        //B Matrisinin değerlerinin düzgün olup olmadığını kontrol ediyor
        public bool GecerliMiB()
        {
            return

                TamMı(txtSatırB, "B'nin satır uzunluğu ") &&
                IntMi(txtSatırB, "B'nin satır uzunluğu ") &&
                TamMı(txtSütunB, "B'nin sütun uzunluğu ") &&
                IntMi(txtSütunB, "B'nin sütun uzunluğu ");
        }

        //A Matrisinin değerlerinin düzgün olup olmadığını kontrol ediyor
        public bool GecerliMiA()
        {
            return

                TamMı(txtSatırA, "A'nin satır uzunluğu ") &&
                IntMi(txtSatırA, "A'nin satır uzunluğu ") &&
                TamMı(txtSütunA, "A'nin sütun uzunluğu ") &&
                IntMi(txtSütunA, "A'nin sütun uzunluğu");

        }



        //Yazdır butonuna tıkladığımda yapılacaklar
        private void button1_Click(object sender, EventArgs e)
        {

            //dosya belirtilen yolda varsa
            if (!File.Exists(yol))
            {
                //dosya oluşturma
                File.CreateText(yol);
                MessageBox.Show("Dosya oluşturuldu.");
            }

            //eğer toplama radiobutton basıldıysa
            if (rdbtnTopla.Checked == true)
            {
                StreamWriter sw = File.AppendText(yol);
                sw.WriteLine("A Matrixi: ");

                sw.WriteLine();

                //A matrisi yazdırılıyor
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {

                        sw.Write(matrixA[i, j].ToString() + " , ");

                    }
                    sw.WriteLine();
                }

                sw.WriteLine();

                sw.WriteLine("B Matrixi: ");

                sw.WriteLine();

                //B matrisi yazdırılıyor
                for (int i = 0; i < matrixB.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {

                        sw.Write(matrixB[i, j].ToString() + " , ");
                    }
                    sw.WriteLine();

                }

                sw.WriteLine();
                sw.WriteLine("İşlem = Toplama");



                sw.WriteLine("C Matrixi: ");

                sw.WriteLine();

                //C(Sonuç) matrisi yazdırılıyor
                for (int i = 0; i < matrixC.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixC.GetLength(1); j++)
                    {

                        sw.Write(matrixC[i, j].ToString() + " , ");
                    }
                    sw.WriteLine();

                }
                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();
            }

            //eğer çarpma radiobutton basıldıysa
            if (rdbtnCarp.Checked == true)
            {
                StreamWriter sw = File.AppendText(yol);
                sw.WriteLine("A Matrixi: ");

                sw.WriteLine();

                //A matrisi yazdırılıyor
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {

                        sw.Write(matrixA[i, j].ToString() + " , ");

                    }
                    sw.WriteLine();
                }

                sw.WriteLine();

                sw.WriteLine("B Matrixi: ");

                sw.WriteLine();

                //B matrisi yazdırılıyor
                for (int i = 0; i < matrixB.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {

                        sw.Write(matrixB[i, j].ToString() + " , ");
                    }
                    sw.WriteLine();

                }

                sw.WriteLine();
                sw.WriteLine("İşlem = Çarpma");



                sw.WriteLine("C Matrixi: ");

                sw.WriteLine();

                //C(Sonuç) matrisi yazdırılıyor
                for (int i = 0; i < matrixC.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixC.GetLength(1); j++)
                    {

                        sw.Write(matrixC[i, j].ToString() + " , ");
                    }
                    sw.WriteLine();

                }
                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();
            }
            //eğer çıkarma radiobutton basıldıysa
            if (rdbtnCıkarma.Checked == true)
            {
                StreamWriter sw = File.AppendText(yol);
                sw.WriteLine("A Matrixi: ");

                sw.WriteLine();
                //A matrisi yazdırılıyor
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {

                        sw.Write(matrixA[i, j].ToString() + " , ");

                    }
                    sw.WriteLine();
                }

                sw.WriteLine();

                sw.WriteLine("B Matrixi: ");

                sw.WriteLine();

                //B matrisi yazdırılıyor
                for (int i = 0; i < matrixB.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {

                        sw.Write(matrixB[i, j].ToString() + " , ");
                    }
                    sw.WriteLine();

                }

                sw.WriteLine();
                sw.WriteLine("İşlem = Çıkarma");



                sw.WriteLine("C Matrixi: ");

                sw.WriteLine();

                //C(Sonuç) matrisi yazdırılıyor
                for (int i = 0; i < matrixC.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixC.GetLength(1); j++)
                    {

                        sw.Write(matrixC[i, j].ToString() + " , ");
                    }
                    sw.WriteLine();

                }

                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();
            }

            //eğer transpoze radiobutton basıldıysa
            if (rdbtnTranspoze.Checked == true)
            {
                StreamWriter sw = File.AppendText(yol);
                sw.WriteLine("Transpozesi alınan matris");
                sw.WriteLine("A Matrixi: ");

                //A(Sonuç) matrisi yazdırılıyor
                sw.WriteLine();
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {

                        sw.Write(matrixA[i, j].ToString() + " , ");

                    }
                    sw.WriteLine();
                }

                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();

            }

            //eğer ters radiobutton basıldıysa
            if (rdbtnTers.Checked == true)
            {
                StreamWriter sw = File.AppendText(yol);
                sw.WriteLine("Tersi alınan matris");
                sw.WriteLine("A Matrixi: ");

                //A(Sonuç) matrisi yazdırılıyor
                sw.WriteLine();
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {

                        sw.Write(matrixA[i, j].ToString() + " , ");

                    }
                    sw.WriteLine();
                }


                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();

            }

            //eğer iz radiobutton basıldıysa
            if (rdbtnİz.Checked == true)
            {
                StreamWriter sw = File.AppendText(yol);
                double sum = 0;
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {

                    sum += matrixA[i, i];                   //iz hesaplanıyor

                }
                sw.WriteLine("İZ: ");
                sw.WriteLine(sum.ToString());                  //iz yazdırılıyor
                sw.WriteLine("----------------------------------------------------------------------------------------");
                sw.WriteLine();
                sw.Close();
            }


        }

        //Okuma butonuna tıkladığımda yapılacaklar
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(yol);
            TextReader reader = new StreamReader(yol);

            richTextBox1.Text = reader.ReadToEnd();  //okunan metin programdaki richTextBox'a yazılır

            reader.Close();
        }


    }
}

