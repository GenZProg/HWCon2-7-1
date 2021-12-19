using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCon2_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Иван Иванович", email = "IvanII@mail.ru";
            byte age = 27;
            double scorProg = 33.31;
            double scorMath = 70.98;
            double scorPhys = 53.64;
            string pattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

            double mediumScor;
            double sumScor;

            mediumScor = (scorProg + scorMath + scorPhys) / 3;
            sumScor = scorProg + scorMath + scorPhys;
            string mediumBallFaorm = mediumScor.ToString("#.##");

            Console.WriteLine(pattern, fullName, age, email, scorProg, scorMath, scorPhys);
            Console.ReadKey();

            Console.WriteLine($"Сумма баллов: {sumScor}");
            Console.WriteLine($"Средний балл: {mediumBallFaorm}");
            Console.ReadKey();




        }
    }
}
