using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelimeAyıklama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanımlamalar

            string okumaYolu = @"C:\Users\ozanb\Desktop\anlamlarİlk.txt";
          //  Kelimeye yazmak için bu yolu
            string kelimeyeYazmaYolu = @"C:\Users\ozanb\Desktop\kelimeListesiTemizlendiYeni.txt";
            
          //  string anlamaYazmaYolu = @"C:\Users\ozanb\Desktop\kelimeListesiAnlamlarTemizlendi.txt";
          
            // kelime yazarken kullanılacak hangi satırlarda yok yazdığını tutup kelime yazarken bu satırları otomatik atlatıyoruz
           
           
            string[] lines = System.IO.File.ReadAllLines(okumaYolu);
            List<char> yazılacakArray = new List<char>();
            List<string> yazılacakString = new List<string>();
            char[] karakterler;
            int kelimeSayısı = 0;


            // Dosyaya Yazabilmek için gereken tanımlamalar
            FileStream fs = new FileStream(kelimeyeYazmaYolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            
         

            // KELİME YAZARKEN KULLANILACAK
            /*
             *  string jYazmaYolu = @"C:\Users\ozanb\Desktop\j.txt";
             *  string[] jArray = File.ReadAllLines(jYazmaYolu);
            List<int> hangiSatır = new List<int>();
            FileStream ts = new FileStream(jYazmaYolu, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter aw = new StreamWriter(ts);
            */

            // Veri Çektiğimiz txt dosyasını okuyoruz

            foreach (string line in lines)
            {
                //  satır *yok içeriyorsa direk satırı atlıyoruz
                if (line.Contains("*yok"))
                    continue;
               
              // Her Karakteri Char Arraya çevirip harf harf okuyoruz
                karakterler = line.ToCharArray();
                foreach(char karakter in karakterler)
                {
                    // ANLAM YAZARKEN KULLANILACAK
                    
                    /*
                    if (karakter == '*')
                     yazılacakArray.Clear();
                      */


                     //KELİME YAZARKEN KULLANILACAK
                    if (karakter == '*')
                        break;

                    // Char Arraye harf harf yazıyoruz
                    yazılacakArray.Add(karakter);
             
                }
                // Char arrayini string e çevirip string listesine yazıyoruz
                String yazı = new String(yazılacakArray.ToArray());
                yazılacakString.Add(yazı);
                yazılacakArray.Clear();
                // ANLAM YAZARKEN KULLANILACAK

                // if(yazı.Contains("*yok"))
                //{
                //  KELİME YAZARKEN KULLANILACAK
                /*
                    hangiSatır.Add(j);
                    Console.WriteLine(j);
                    aw.WriteLine(j);
                  */
                // }
                //else 
                //{

                //  yazılacakString.Add(yazı);

                // }




                // KELİME YAZARKEN KULLANILACAK <<
                /*
                  if(jArray.Contains(i.ToString()))
                {
                  

                }
                else 
                {
                    
                    yazılacakString.Add(yazı);
                    
                }
                  */
            }
         
            // Dosyaya yazma İşlemi
            foreach(string yaz in yazılacakString)
            {
                kelimeSayısı++;
                Console.WriteLine(yaz);
                sw.WriteLine(yaz);
                
            }

            Console.WriteLine(kelimeSayısı);
            
            
            sw.Flush();
            //Veriyi tampon bölgeden dosyaya aktardık.
            sw.Close();
            fs.Close();



            // Consolu Açık Tutma
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
