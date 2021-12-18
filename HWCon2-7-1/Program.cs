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
            double ballProg = 33.31;
            double ballMath = 70.98;
            double ballPhys = 53.64;
            string pattern = "ФИО: {0} \nВозраст: {1} \nEmail: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике: {5}";

            double mediumBall;
            double sumBall;

            mediumBall = (ballProg + ballMath + ballPhys) / 3;
            sumBall = ballProg + ballMath + ballMath;
            string mediumBallFaorm = mediumBall.ToString("#.##");

            Console.WriteLine(pattern, fullName, age, email, ballProg, ballMath, ballPhys);
            Console.ReadKey();

            Console.WriteLine($"Сумма баллов: {sumBall}");
            Console.WriteLine($"Средний балл: {mediumBallFaorm}");
            Console.ReadKey();




        }
    }
}
