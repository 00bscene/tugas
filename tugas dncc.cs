//c# fundamental rangkuman

//deklarasi pustaka
using System;
 
 //bagian class
 namespace HelloWorld
 {
    //bagian fungsi
    class Program
    {
        //kode: c# main function
         static void Main(string[] args) {
        Console.WriteLine("Hallo Dunia!");
       
       //Variabel (tanpa kode variabel)
        Console.WriteLine("Divisi Game DNCC UDINUS");

        //kode variabel
        string divisiDncc = "Game";

        Console.WriteLine(divisiDncc);

        //const
        const float phi = 3.14f;
        Console.WriteLine(phi);
        
//komentar      
      // ini adalah komentar single line

       /*
       ini adalah komentar
       multi line
       */
/*
//tipe data
       //tipe data number
       int angka = 10;
       double angkaDouble = 3.14;
       float angkaFloat = 10.2f;

       Console.WriteLine(angka);
       Console.WriteLine(angkaDouble);
       Console.WriteLine(angkaFloat);

        //string
       string firstName;
       string lastName = "Game";

       firstName = "Divisi ";
       Console.WriteLine(firstName);
       Console.WriteLine(lastName);

       firstName += lastName;
       Console.WriteLine(firstName);

        //kode: karakter blacklash
       string hari = "senin \tselasa \trabu \tkamis";
       string bulan = "januari \rfebruari \rmaret \rmaret";
       string film = "\"One Piece\"";

       Console.WriteLine(hari);
       Console.WriteLine(bulan);
       Console.WriteLine(film);

      //kode: manipulasi string 
       string txt = "ini adalah sebuah Text";

       Console.WriteLine(txt.ToLower());
       Console.WriteLine(txt.ToUpper());
       Console.WriteLine("panjang string tersebut adalah " + txt.Length);
       Console.WriteLine(txt + " yang di Gabungkan");

        //kode: string interpolation
       string name = "Aufa";
       var date = DateTime.Now;
       //string interpolation;
       Console.WriteLine($"Halo, {name}! hari ini adalah {date.DayOfWeek}, pukul {date:HH:mm} WIB.");

        //kode: boolean
       bool benar = true;
       //bool salah = false;

       if (benar == true)
       {
        Console.WriteLine("ini adalah pernyataan yang benar");
       }
       else
       {
        Console.WriteLine("ini adalah pernyataan yang salah");
       }

    //konversi tipe data
        //float ke int
       float first = 3.14f;
       int second = (int)first;

       Console.WriteLine(second);

        //number ke string
       int angkaSatu = 10;
       float angkaDua = 20.7f;
        Console.WriteLine($"{angkaSatu. ToString()}{angkaDua. ToString()}");

        //string ke int
        string pertama = "5";
        string kedua = "7";
        int sum = int.Parse(pertama) + int.Parse(kedua);
        Console.WriteLine(sum);

//operator aritmatika
        
        //kode: operator aritmatika
        var hasil = 10 + 14;
        var hasil1 = 50 - 29;
        var hasil2 = -23;
        var hasil3 = 5 * 4;
        var hasil4 = 20 / 4;
        var hasil5 = 30 % 4;

        Console.WriteLine(hasil);
        Console.WriteLine(hasil1);
        Console.WriteLine(hasil2);
        Console.WriteLine(hasil3);
        Console.WriteLine(hasil4);
        Console.WriteLine(hasil5);

//operator penugasan

        //kode: increment dan decrement
        int a = 3;
        Console.WriteLine(a);  //output 3
        Console.WriteLine(++a);  //output 4
        Console.WriteLine(a);  //output 4

        Console.WriteLine(a); //output 3
        Console.WriteLine(a++);  //output 3
        Console.WriteLine(a);  //output 4

        Console.WriteLine(a); //output 3
        Console.WriteLine(--a);  //output 2
        Console.WriteLine(a);  //output 2

        Console.WriteLine(a); //output 3
        Console.WriteLine(a--);  //output 3
        Console.WriteLine(a);  //output 2

//operator perbandingan

        //kurang dari <
        Console.WriteLine(7.0 < 5.1);   // output: False
        Console.WriteLine(5.1 < 5.1);   // output: False
        Console.WriteLine(0.0 < 5.1);   // output: True

        //lebih dari >
        Console.WriteLine(7.0 > 5.1);   // output: True
        Console.WriteLine(5.1 > 5.1);   // output: False
        Console.WriteLine(0.0 > 5.1);   // output: False
    
//operator logika

        //operatpr &&
        bool SecondOperand()

        {
        Console.WriteLine("Second operand is evaluated.");
        return true;
        }

        bool p = false && SecondOperand();
        Console.WriteLine(p);
        // Output:
        // False

        bool q = true && SecondOperand();
        Console.WriteLine(q);
        // Output:
        // Second operand is evaluated.
        // True

//Array

        //kode: membuat array
        string[] divisi = { "web", "mobile", "game", "mulmed", "jaringan" };

        Console.WriteLine(divisi[0]); 
        Console.WriteLine(divisi[1]); 
        Console.WriteLine(divisi[2]); 
        Console.WriteLine(divisi[3]); 
        Console.WriteLine(divisi[4]); 

            string[] names = new string[5];
            names[0] = "web";
            names[0] = "mobile";
            names[0] = "game";
            names[0] = "mulmed";
            names[0] = "jaringan";
        

        //kode: Array 2D
        int[,] number = new int [2,3];
        int[,] numbers = { { 1, 2, 3} , { 4, 5, 6  }};
        
        Console.WriteLine(numbers[0, 1]); //output 2
        Console.WriteLine(numbers[1, 2]); //output 6
    */
    /*
        //kode: array 3D
        int[,,]number = new int[ 2, 2, 3 ];
        int[,,]numbers = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

        Console.WriteLine(numbers[0, 0, 0 ]); //output 1
        Console.WriteLine(numbers[1, 1, 0 ]); //output 10

//list

        //kode: list
        var names = new List<string> { "game", "mobile", "web" };
        for (int i = 0; i < names.Count; i++)
        {
            Console.Write(names[i] + " " );
        }

        List<int> angka = new List<int>();
        angka.Add(1);
        angka.Add(2);
        angka.Add(3);

        angka.AddRange(new int[3] { 4, 5, 6 } );
        
        angka.Remove(1);

        angka.RemoveAt(0);
    */

//pengkondisian
    /* 
        //kode: if
        int i = 5;
        if ( 10 > i )
        {
            Console.WriteLine("Benar!");
        }

        //kode: else
        {
            Console.WriteLine("salah!");
        }
    */
    /*
        //kode: else if
        int nilai = 75;
        if (nilai >= 90)
        {
          Console.WriteLine("anda mendapatkan A.");
        }
        
        else if (nilai >= 80 )
        {
          Console.WriteLine("anda mendapatkan B.");
        }

        else if (nilai >= 70 )
        {
          Console.WriteLine("anda mendapatkan C.");
        }

        else
        {
          Console.WriteLine("anda mendapatkan D atau E.");
        }

    */
    //Pengkondisian - Switch

    /*
        //Kode: Switch
        int nilai = 75;
        switch (nilai)
        {

            case > 95:
                Console.WriteLine("memuaskan");
                break;
            case > 80:
                Console.WriteLine("Baik");
                break;
            case >= 75:
                Console.WriteLine("cukup");
                break;
            default:
                Console.WriteLine("kurang");
                break;
            
         }
    */

/*
//Ternary Operator

        //Kode: Ternary Operator
        int angka = 10;
        string hasil = (angka % 2 == 0 ) ? "genap" : "ganjil";
        Console.WriteLine(hasil);
*/
/*
//Perulangan

        //Kode : Perulangan For
         for (int i = 0; i < 5; i++)
        {
          Console.WriteLine("perulangan ke " + 1);
        }
*/
/*
        //Kode : perulangan While
         int i = 0; 
         while (i < 5 )
        {
          Console.WriteLine("perulangan ke " + 1);
          i++;
        }

        //Kode : Perulangan Do While
         int i = 5;
        do 
        {
          Console.WriteLine("perulangan ke " + 1);
          i++;
        } while ( i < 5);
*/
/*
        //Kode : Perulangan Foreach
        int i = 0;
        int[] number = new int [5] { 1, 2, 3, 4, 5 };
        foreach (int a in number)
        {
          Console.WriteLine("ini adalah isi array urut dari indeks ke " + i++ + " yaitu " + a);
        }
*/
/*
//Break & Continue

        //Break & Continue
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("perulangan ke " + 1);

            if (i == 5)
            {
                break;
            }
        }
*/
/*

        //Kode : Continue
         for (int i = 0; i < 10; i++)
        {
            if ( i % 2 == 0)
            {
                continue;
            }
             Console.WriteLine(i);
        }
   
      }
//function
    
        public static void Main (string[] args)
        {
            Tampil();
        }

        Public static void Tampil()
        {
            Console.WriteLine("game");
        } 


         Public static void Tampil()
        {
            int hasil = Return();
            Console.WriteLine("hasil");
        } 

         Public static int Return()
         {
            return 5;
         }

        Public static int counter(int damage)
        {
            return damage + 5;
        }
*/













    }
}
}
