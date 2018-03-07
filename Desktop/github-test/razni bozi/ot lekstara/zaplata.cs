using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ot_lekstara
{
    class zaplata
    {
        static void Main(string[] args)
        {
            //   Заплатите на служителите във фирма се формират по следния начин: за всяка година се начисляват 6 % процента прослужено време.
            //   На всеки 5 години, заплатата се увеличава със 100лв, а на всеки 10 години - с 200лв.
            //   Ако служителят е синдикален член, се удържа членски внос в размер от 1 % от годишната заплата при всяка година,
            //   която не е 5 - та или 10 - та.
            //   Пример: При година
            //   Заплатите във фирмата имат таван от 5000 лева.Ако заплатата на служител достигне тавана, тя повече не нараства и не се удържа
            //   членски внос.Ако тя стане по-голяма, да се приравни на 5000.00.
            //   Напишете програма, която по въведена основна заплата, години прослужено време и текст дали служителят е синдикален член,
            //   определя текущата заплата и след колко години ще достигне максимална заплата.
            //       Вход
            //   От конзолата се четат 2 числа и текст, по едно на ред:
            //На първи ред - основна заплата в лева - число с плаваща запетая в интервала[0.00..5000.00]
            //На втори ред - прослужено време - цяло  число в интервала[0...45]
            //На трети ред - текст, указващ дали служителят е синдикален член, с възможни стойности: "Yes" и "No"

            Console.Write("Enter salary  ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Enter years  ");
            int years = int.Parse(Console.ReadLine());
            Console.Write("Enter sindikat ");
            string sindikat = Console.ReadLine();
            int petiletka = years / 5;
            int desetak = years / 10;
            for (int i = 1; i <= years; i++)
            {
                salary = salary * 1.06;
                switch (i)
                {
                    case  5:
                    case 15:
                    case 25:
                    case 35:
                    case 45:                  
                        salary = salary + 100;
                        break;

                    case 10:
                    case 20:
                    case 30:
                    case 40:
                        salary = salary + 200;
                        break;
                        
                    
                }
               
                if (sindikat == "yes")
                {

                    if (i == 5 || i == 10 || i == 15 || i == 20 || i == 25 || i == 35 || i == 40)
                    {

                        salary = salary * 1;

                        //break;
                    }
                    else
                    {
                        salary = salary * 0.99;
                    }


                }

            }

            Console.WriteLine(salary);

          


        }


    }
}
