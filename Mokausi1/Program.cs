using System;

namespace Mokausi1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ////1p. 1u.

            //while (true)

            //{

            //    Console.WriteLine("Iveskite spalva");

            //    string spalva = Console.ReadLine();

            //    Console.WriteLine($"Mano irgi megstamiausia spalva {spalva}");



            //}





            //1p. 2u.



            //int a = 17, b = 23;

            //int addition = a + b;





            //Console.WriteLine(addition);



            //1p. 3u.



            //Double a = 24, b = 5;

            //Double division = a / b;



            //Console.WriteLine(division);



            ////1p. 4u.



            //int task1 = -6 + 3 * 5;

            //int task2 = (13 - 2) * 7;

            //int task3 = (5 + (-2)) + (20 / 10);



            //Console.WriteLine(task1);

            //Console.WriteLine(task2);

            //Console.WriteLine(task3);



            ////1p. 5u.



            //Console.WriteLine("parasykite pirma skaiciu");

            //string input1 = Console.ReadLine();

            //int a1 = int.Parse(input1);



            //Console.WriteLine("parasykite antra skaiciu");

            //string input2 = Console.ReadLine();

            //int a2 = int.Parse(input2);



            //Console.WriteLine($"{a1 + a2}, {a1 - a2}, {a1 * a2}, {a1 / a2}");





            ////1p. 6u.



            //Console.WriteLine("Iveskite skaiciu");

            //string input = Console.ReadLine();

            //int a = int.Parse(input);



            //Console.WriteLine($"{a * 0},{a * 1},{a * 2},{a * 3},{a * 4},{a * 5},{a * 6},{a * 7},{a * 8},{a * 9},{a * 10}");







            ////1p. 7u.



            //Console.WriteLine("Iveskite pirma skaiciu");

            //string input1 = Console.ReadLine();

            //double a1 = int.Parse(input1);





            //Console.WriteLine("Iveskite antra skaiciu");

            //string input2 = Console.ReadLine();

            //double a2 = int.Parse(input2);



            //Console.WriteLine("Iveskite trecia skaiciu");

            //string input3 = Console.ReadLine();

            //double a3 = int.Parse(input3);



            //Console.WriteLine("Iveskite ketvirta skaiciu");

            //string input4 = Console.ReadLine();

            //double a4 = int.Parse(input4);



            //Console.WriteLine((a1+a2+a3+a4)/4);





            ////1p. 8u.





            //Console.WriteLine("Iveskite pirma skaiciu");

            //string input1 = Console.ReadLine();

            //double a1 = int.Parse(input1);





            //Console.WriteLine("Iveskite antra skaiciu");

            //string input2 = Console.ReadLine();

            //double a2 = int.Parse(input2);



            //Console.WriteLine("Iveskite trecia skaiciu");

            //string input3 = Console.ReadLine();

            //double a3 = int.Parse(input3);



            //Console.WriteLine($"{(a1+a2)*a3}, {a1*a3+a2*a3}");





            //2p. 1u.



            //int x = 6;

            //int y = 5;

            //int temporary;



            //Console.WriteLine($"{x},{y}");



            //temporary = x;

            //x = y;

            //y = temporary;



            //Console.WriteLine($"{x},{y}");



            ////2p. 2u.



            //string schoolName = "CodeAcademy";

            //string courseName = "NET";

            //int studentCount = 17;

            //DateTime dateNow = DateTime.Now;



            //Console.WriteLine($"{schoolName}, {courseName}, {studentCount}, {dateNow}");







            //ND



            ////4. uzduotis



            //Console.WriteLine("Iveskite pirma skaiciu");

            //string input1 = Console.ReadLine();





            //bool vaild1 = Int32.TryParse(input1,out int number1);





            //if (vaild1)



            //{

            //    Console.WriteLine("Iveskite antra skaiciu");

            //    string input2 = Console.ReadLine();



            //    bool vaild2 = Int32.TryParse(input2, out int number2);



            //    if (vaild2)

            //    {

            //        bool isEqual = number1 == number2;



            //        Console.WriteLine($"Sie skaiciai {number1}, {number2} yra {isEqual}");



            //    }

            //    else

            //    {

            //        Console.WriteLine("klaida");

            //    }



            //}





            ////5 uzduotis





            //Console.WriteLine("Iveskite pirma skaiciu");

            //string input1 = Console.ReadLine();

            //bool vaild = Int32.TryParse(input1, out int number1);



            //if (vaild)



            //{



            //    Console.WriteLine("Iveskite antra skaiciu");

            //    string input2 = Console.ReadLine();

            //    bool vaild2 = Int32.TryParse(input2, out int number2);



            //    if (vaild2)



            //    {



            //        Console.WriteLine($"{++number1}, {--number2}");

            //    }

            //    else



            //    {



            //        Console.WriteLine("Klaida");

            //    }

            //}



            ////6 uzduotis



            //Console.WriteLine("Iveskite teksta");

            //string input = Console.ReadLine();

            //bool isVaild = string.IsNullOrWhiteSpace(input);



            //if (isVaild)

            //{

            //    Console.WriteLine($"tekstas yra ivestas{isVaild}");

            //}

            //else

            //{

            //    Console.WriteLine(input);

            //}



            ////7 uzduotis



            //Console.WriteLine("iveskite skaiciu");

            //string input = Console.ReadLine();

            //bool vaild = Int32.TryParse(input, out int number1);



            //if (vaild)

            //{

            //    bool isVaild = number1 > 0;







            //    Console.WriteLine($"sis skaicius {number1} yra {isVaild}");

            //}







            //else

            //{



            //    Console.WriteLine("klaida");

            //}



            ////8 uzduotis



            //string inputVardas = "JoNaS";

            //string vardas = "Jonas";



            //string pavarde = "Jonauskas";

            //string inputPavarde = "joNAuskaS";





            //bool arSutampaVardas = string.Equals(inputVardas, vardas, StringComparison.OrdinalIgnoreCase);

            //bool arSutampaPavarde = string.Equals(inputPavarde, pavarde, StringComparison.OrdinalIgnoreCase);



            //if (arSutampaVardas)

            //{

            //    Console.WriteLine("Vardas sutampa");

            //}



            //if (arSutampaPavarde)



            //{

            //    Console.WriteLine("Pavarde sutampa");

            //}



            ////3p. 1u.



            //Console.WriteLine("Iveskite atstuma metrais");

            //string input1 = Console.ReadLine();

            //double meters = Convert.ToDouble(input1);





            //Console.WriteLine("Iveskite laika sekundemis");

            //string input2 = Console.ReadLine();

            //double seconds = Convert.ToDouble(input2);



            //double greitis = meters / seconds;

            //double greitisKMH = greitis * 3.6;



            //Console.WriteLine($"Greitis Km/h: {greitisKMH}");



            ////3p. 2 u.



            //Console.WriteLine("Iveskite kvadrato krastines ilgi");

            //string input1 = Console.ReadLine();

            //double side = Convert.ToDouble(input1);



            //double plotas = side * side;

            //double turis = side * side * side;



            //Console.WriteLine($"Kvadrato plotas yra {plotas}, o  turis yra {turis}");









            ////3p. 3u.



            //Console.WriteLine("Iveskite pirma skaiciu");

            //string input1 = Console.ReadLine();

            //bool valid = Int32.TryParse(input1, out int number1);



            //Console.WriteLine("Iveskite antra skaiciu");

            //string input2 = Console.ReadLine();

            //bool valid1 = Int32.TryParse(input2, out int number2);





            //if (number1 % 2 == 0)

            //{

            //    Console.WriteLine($"number {number1} is eaven");



            //}

            //else

            //{



            //    Console.WriteLine($"number {number1} is odd");

            //}



            //if (number2 % 2 == 0)

            //{

            //    Console.WriteLine($"number {number2} is eaven");

            //}

            //else

            //{



            //    Console.WriteLine($"number {number2} is odd");

            //}



            ////3p. 4u.







            //string username, password;

            //int count = 0;

            //do

            //{

            //    Console.WriteLine("Enter username");

            //    username = Console.ReadLine();



            //    Console.WriteLine("Enter password");

            //    password = Console.ReadLine();



            //    if (username != "abcd" || password != "1234")



            //    {

            //        count++;

            //    }





            //    else

            //        count = 1;

            //    Console.WriteLine("try again");



            //}



            //while ((username != "abcd" || password != "1234") && (count != 3));

            //if (count == 3)

            //    Console.WriteLine("Login fail");









            ////3p. 5u.



            ////double d = 1234567890.9d;

            ////int i = (int)d;

            ////console.writeline(i);



            ////short s = (short)d;

            ////console.writeline(s);



            ////byte b = (byte)d;

            ////console.writeline(b);

            ////4p. u1.



            //Console.WriteLine("Iveskite nariu skaiciu");

            //int skaicius = Convert.ToInt32(Console.ReadLine());



            ///

            //if (skaicius == 1)

            //{

            //    Console.WriteLine("tai solo atlikejas");

            //}

            //else if (skaicius == 2)

            //{

            //    Console.WriteLine("Tai duetas");

            //}

            //else if (skaicius > 2 && skaicius < 10)

            //{

            //    Console.WriteLine("Tai ansamblis");

            //}

            //else if (skaicius > 10)

            //{

            //    Console.WriteLine("Tai kamerinis orkestras");

            //}

            //else

            //{

            //    Console.WriteLine("klaida");

            //}



            //switch (skaicius)

            //{

            //    case 1:

            //        Console.WriteLine("tai solo atlikejas");

            //        break;



            //    case 2:

            //        Console.WriteLine("Tai duetas");

            //        break;



            //    case 3:

            //    case 4:

            //    case 5:

            //    case 6:

            //    case 7:

            //    case 8:

            //    case 9:

            //        Console.WriteLine("Tai ansamblis");

            //        break;



            //}



            ////4p. 2u.



            //Console.WriteLine("Iveskite isdirbtas valandas");

            //int valandos = Convert.ToInt32(Console.ReadLine());



            //if (valandos == 160)

            //{

            //    Console.WriteLine("Isdirbtas pilnas etatas");

            //}

            //else if (valandos < 160)

            //{

            //    Console.WriteLine($"Jums liko isdirbti {160-valandos}");

            //}

            //else if (valandos > 160)

            //{

            //    Console.WriteLine($"Jusu virsvalandziai {valandos-160}");

            //}

            //else

            //{

            //    Console.WriteLine("Klaida");

            //}







            ////4p. 3u.



            //Console.WriteLine("Iveskite egzamino pazimi");

            //int pazimys = Convert.ToInt32(Console.ReadLine());



            //switch (pazimys)

            //{

            //    case 0: case 1: case 2: case 4:

            //        Console.WriteLine("NEPATENKINAMAI");

            //        break;

            //    case 5:

            //        Console.WriteLine("Silpnai");

            //        break;

            //    case 6:

            //        Console.WriteLine("Patenkinamai");

            //        break;

            //    case 7:

            //        Console.WriteLine("Vidutiniskai");

            //        break;

            //    case 8:

            //        Console.WriteLine("Gerai");

            //        break;

            //    case 9:

            //        Console.WriteLine("Labai gerai");

            //        break;

            //    case 10:

            //        Console.WriteLine("puikiai");

            //        break;

            //    default:

            //        Console.WriteLine("klaida");

            //        break;



            //}

            //// 5p 1u.





            //Console.WriteLine("Iveskite skaiciu");

            //int skaicius = Convert.ToInt32(Console.ReadLine());

            //int result = 0;



            //for (int i = 0; i <= skaicius; i = i+1)

            //{

            //    result = result + i;

            //    Console.WriteLine($"skaicius yra {result + i}" );

            //}







            ////5p. 2u.



            //console.writeline("iveskite skaiciu");

            //int skaicius = convert.toint32(console.readline());



            //for (int i = 0; i <= skaicius; i++)

            //{

            //    if (i %2 == 0)

            //        {

            //        console.writeline($"skaiciai yra {i}");

            //        }



            ////}



            ////5 p. 3 u. Pirmas variantas



            console.writeline("iveskite sakini");

            int sakinys = convert.toint32(console.readline());

            string sakinys;

            sakinys = console.readline();



            char[] apsuksakini = sakinys.tochararray();

            array.reverse(apsuksakini);

            foreach (char i in apsuksakini)

            {

                console.writeline(i);

            }




            ////5p. 4u.



            //        Console.WriteLine("Iveskite pirma skaiciu");

            //        int numb1 = Convert.ToInt32(Console.ReadLine());



            //        Console.WriteLine("Iveskite antra skaiciu");

            //        int numb2 = Convert.ToInt32(Console.ReadLine());



            //        Console.WriteLine("Iveskite simboli");

            //        string simbol = (Console.ReadLine());



            //        if (simbol == "+")

            //        {

            //            Console.WriteLine(numb1 + numb2);



            //        }

            //        else if (simbol == "-")

            //        {

            //            Console.WriteLine(numb1 - numb2);

            //        }

            //        else if (simbol == "/")

            //{

            //    Console.WriteLine(numb1 / numb2);

            //}

            //else if (simbol == "*")

            //{

            //    Console.WriteLine(numb1 * numb2);

            //Console.WriteLine("sakyk labas");
            //console.readline();
        }
    }
}
