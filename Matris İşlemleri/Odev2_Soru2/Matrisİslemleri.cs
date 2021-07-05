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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Odev2_Soru2
{
    static class Matrisİslemleri
    {

        //matrisi birim matrise çeviren fonksiyon
        static public double[,] birimMatris(int satır, int sütun, double[,] matris)
        {
            if (aynıSatırSütun(satır, sütun))               //eğer satır ve sütun sayıları aynı ise
            {
                for (int i = 0; i < satır; i++)
                {
                    for (int j = 0; j < sütun; j++)
                    {
                        if (i == j)
                        {
                            matris[i, j] = 1.0;             //ana köşegenleri 1 olur  
                        }
                        else
                        {
                            matris[i, j] = 0.0;            //geri kalanları 0 olur
                        }
                    }
                }
            }
            return matris;                                 //matris geri döner
        }

        //çarpma boyut kontrolü
        static public bool carpmaKontrol(int satırA, int sütunB)
        {
            if (satırA != sütunB)                                       //a matrisinin satırı ve b matrisinin sütunu aynı boyutta değilse 
                                                                        //işleme izin vermez ve çıkar değilse devam eder
            {
                MessageBox.Show("Boyut tercihleriniz hatalı.");
                return false;
            }
            return true;
        }

        //matrislerin aynı satır ve sütunda olup olmadığını kontrol eder
        static public bool aynıSatırSütun(int satır, int sütun)
        {
            if (satır != sütun)                                            //satır ve sütun uzunlukları aynı değilse hata verir ve çıkar değilse devam
            {
                MessageBox.Show("Satır ve sütun sayıları eşit değil.");
                return false;
            }
            return true;
        }

        // matris oluşturma fonksiyonu
        static public double[,] matrisOlustur(int satır, int sütun, double[,] matrix)
        {
            Random rastgele_Sayi = new Random();                            //matris elemanları için rastgele sayı oluşturuyoruz

            for (int i = 0; i < satır; i++)
            {
                for (int j = 0; j < sütun; j++)
                {
                    matrix[i, j] = rastgele_Sayi.NextDouble() * 10.0;   //rastgele değerleri matrise atıyoruz


                }
            }
            return matrix;                                              //matrisi döndürüyoruz
        }


        //matris yazdırma fonksiyonu
        static public string matrisYazdır(int satır, int sütun, string test, double[,] matris)
        {
            test = "";
            for (int i = 0; i < satır; i++)
            {
                test += "\r\n";
                for (int j = 0; j < sütun; j++)
                {
                    test += String.Format("{0:0.00}", matris[i, j]) + "\t";            //matris değerlerini string olarak yazdırıyoruz



                }
            }
            return test;                     //string değerini döndürüyoruz
        }

        //matris çarpma fonksiyonu
        static public double[,] matrisCarpma(int satırA, int satırB, int sütunA, int sütunB, double[,] matrisA, double[,] matrisB, double[,] matrisC)
        {
            for (int i = 0; i < satırA; i++)
            {
                for (int j = 0; j < sütunB; j++)
                {
                    matrisC[i, j] = 0;                      //matrisC elemanlarını çarpma işlemi için sıfırla
                    for (int k = 0; k < sütunA; k++)
                    {
                        matrisC[i, j] += matrisA[i, k] * matrisB[k, j];   //çarpma işlemi
                    }
                }
            }
            return matrisC;             //çarpılmış matris değerini döndürüyoruz
        }

        //matris toplama fonksiyonu
        static public double[,] matrisEkle(int satırA, int satırB, int sütunA, int sütunB, double[,] matrisA, double[,] matrisB, double[,] matrisC)
        {
            for (int i = 0; i < satırA; i++)
            {
                for (int j = 0; j < sütunA; j++)
                {
                    matrisC[i, j] = matrisA[i, j] + matrisB[i, j];   //toplama işlemi

                }
            }

            return matrisC;                      //toplanmış matris değerini döndürüyoruz
        }


        //matris çıkarma fonksiyonu
        static public double[,] matrisCıkar(int satırA, int satırB, int sütunA, int sütunB, double[,] matrisA, double[,] matrisB, double[,] matrisC)
        {
            for (int i = 0; i < satırA; i++)
            {
                for (int j = 0; j < sütunA; j++)
                {
                    matrisC[i, j] = matrisA[i, j] - matrisB[i, j];          //silme işlemi

                }
            }

            return matrisC;                 //silme işlemi uygulanmış matris değerini döndürüyoruz
        }





        //matris toplama işlemi için kontrol
        static public bool toplamaKontrol(int satırA, int satırB, int sütunA, int sütunB)
        {

            if (satırA != satırB || sütunA != sütunB)
            {
                MessageBox.Show("Boyut tercihleriniz hatalı.");   //boyutlar hatalı ise uyarı mesajı çıkarır değilse devam eder
                return false;
            }

            return true;

        }

        //matris transpoze işlemi için kontrol
        static public bool transpozeKontrol(int satır, int sutun)
        {

            if (satır != sutun)
            {
                MessageBox.Show("Transpoze işlemi için kare matris olmalı.");   //boyutlar hatalı ise uyarı mesajı çıkarır değilse devam eder
                return false;
            }

            return true;

        }

        //matris tersini alma işlemi için kontrol
        static public bool tersKontrol(int satır, int sutun)
        {

            if (satır != sutun)
            {
                MessageBox.Show("Tersini alma işlemi için kare matris olmalı.");     //boyutlar hatalı ise uyarı mesajı çıkarır değilse devam eder
                return false;
            }



            return true;

        }



        //matris transpoze fonksiyonu
        static public double[,] matrisTranspoze(int satır, int sütun, double[,] matrisA, double[,] matrisC)
        {
            for (int i = 0; i < satır; i++)
            {
                for (int j = i; j < sütun; j++)
                {
                    double gecici = matrisA[i, j];
                    matrisA[i, j] = matrisA[j, i];          //kova tekniği kullanılarak transpoze işlemi gerçekleştiriliyor
                    matrisA[j, i] = gecici;

                }

            }

            matrisC = matrisA;
            return matrisC;                                 //transpozesi alınmış matris döndürülüyor
        }



        //matris iz bulma fonksiyonu
        static public void matrisizBul(double toplam, int satır, int sütun, double[,] matrisA)
        {
            toplam = 0;

            for (int i = 0; i < satır; i++)
                toplam += matrisA[i, i];                        //iz işlemini yapar ve double değişkenine atar

            MessageBox.Show(toplam.ToString());                 //sonucu döndürür
        }

        //matris iz kontrol fonksiyonu
        static public bool izKontrol(int satır, int sutun)
        {

            if (satır != sutun)
            {
                MessageBox.Show("İz alma işlemi için kare matris olmalı.");   //boyutlar hatalı ise uyarı mesajı çıkarır değilse devam eder
                return false;
            }



            return true;

        }


        //ters işlemi için determinant hesaplama  fonksiyonu
        static public double detHesapla(double[,] matris, int boyut)
        {
            int i, j, k;
            double isaret = 1.0;
            double determinant = 0;
            if (boyut <= 2)
            {
                return matris[0, 0] * matris[1, 1] - matris[1, 0] * matris[0, 1];  //boyut ikiden küçükse hesaplama
            }
            else
            {
                double[,] geciciMatris = new double[boyut - 1, boyut - 1]; // gecici matris oluşturuyoruz
                for (i = 0; i < boyut; i++) // en üst satırdaki elementin indeksi
                {
                    for (j = 0; j < boyut - 1; j++) // ikinci satırdan iniyor
                    {
                        for (k = 0; k < boyut - 1; k++) // elementleri gecicimatrise atıyoruz
                        {
                            if (j < i)
                                geciciMatris[j, k] = matris[j, k + 1];
                            else
                                geciciMatris[j, k] = matris[j + 1, k + 1];
                        }
                    }
                    determinant = determinant + isaret * detHesapla(geciciMatris, boyut - 1) * matris[i, 0];  //determinant hesaplama işlemi
                    isaret = -isaret;
                }
                return determinant;         //determinantı döndürüyoruz
            }
        }


        //matris tersi alma fonksiyonu
        static public double[,] matrisTers(double[,] matrisA, double[,] matrisC, int boyut)
        {
            double det = detHesapla(matrisA, boyut);    //determinantı hesaplıyoruz

            int x, y, j, k;
            double isarety = 1.0;
            double isaretx = 1.0;
            if (det != 0)                               //eğer determinant 0 değilse
            {
                if (boyut <= 2)                         //boyut 2den küçükse
                {
                    if (boyut == 2)                                 //boyut 2 ise
                    {
                        matrisC[0, 0] = matrisA[1, 1] / det;
                        matrisC[0, 1] = -matrisA[0, 1] / det;       //2 boyutlu olan matrislerin tersini alıyoruz
                        matrisC[1, 0] = -matrisA[1, 0] / det;
                        matrisC[1, 1] = matrisA[0, 0] / det;
                    }
                }
                else
                {
                    double[,] geciciMatris = new double[boyut - 1, boyut - 1]; // geçiçi matris oluşturuyoruz
                    for (x = 0; x < boyut; x++)
                    {
                        isarety = 1.0;
                        for (y = 0; y < boyut; y++) // en üst satırdaki elementin indeksi
                        {
                            for (j = 0; j < boyut - 1; j++) // ikinci satırdan iniyor
                            {
                                for (k = 0; k < boyut - 1; k++) // elementleri gecicimatrise atıyoruz
                                {
                                    if (j < y)
                                    {
                                        if (k < x)
                                            geciciMatris[j, k] = matrisA[j, k];
                                        else
                                            geciciMatris[j, k] = matrisA[j, k + 1];
                                    }
                                    else
                                    {
                                        if (k < x)
                                            geciciMatris[j, k] = matrisA[j + 1, k];
                                        else
                                            geciciMatris[j, k] = matrisA[j + 1, k + 1];
                                    }
                                }
                            }
                            matrisC[x, y] = isarety * isaretx * detHesapla(geciciMatris, boyut - 1) / det;  //matrisin tersini hesaplıyoruz
                            isarety = -isarety;
                        }
                        isaretx = -isaretx;
                    }
                }
            }

            return matrisC;         //tersi alınmış matrisi alıştırıyoruz
        }
    }
}
