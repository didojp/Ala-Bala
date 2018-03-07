using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneti
{
    class moneti
    {
        static void Main(string[] args)
        {
            //оператори за управление на масиви, списъци и речници:
            int neshtoSi = int.Parse(Console.ReadLine()); // Парсваме число въведено от конзолата, парснато
            int[] TotalText = new int[neshtoSi]; //- масив с големина прочетеното число
            for (int i = 0; i < neshtoSi; i++)
            {
                TotalText[i]= Console.ReadLine(); //пълниме масив със стойности чрез обхождане с цикъл
            }
            // по същия начин е и печатането с цикъл например, важно е да се обходят данните
            for (int i = 0; i < neshtoSi; i++)
            {
                Console.WriteLine(TotalText[i]+" ");
            }
            // за да получим отделна съставна(клетка) от масив(Лист)
            string result = string.Join(" ", TotalText); // Join е валиден само за стрингове;
            //обхождане на масиви(списъци) и вадене на отделен стрингов елемент:
            foreach (var item in TotalText)
            {
                Console.WriteLine(item);

            }
            Array.Reverse(TotalText); // ревърсва масива
            List.Reverese(TotalText); // ривърсва списъка
            TotalText = TotalText.Reverse().ToArray(); //revers-ваме масива

            //операции със списъци
            List<string> Gosho = new List<string>();
            Gosho.Insert(x, y); // в списък Гошо на индекс х вмъкваме стойност y
            Gosho.Contains(x); //Проверяваме в списък Гошо дали има ст-ст х;
            Gosho.Count(); // проверяваме дължината на списъка(броя на елементите);
            Gosho.Add(X or "name");// добавяме елемент към списъка;
            Gosho.Remove(X or "name"); //махаме елемент от списъка. маха само по един. ако има повтарящите се другите си стоят.
            Gosho.RemoveAll(X or "name"); //маха всички Х или string с посоченото име;
            //печатание на списък 
            Console.WriteLine(String.Join(",",Gosho));// дори и да е int-ов списъка пак требе да има Стринг.
            Gosho.AddRange(x, y, z); //иска колекция от данни.шиба ги в края на списъка
            Gosho.InsertRange(x, Array[]); //вмъква колекция от данни на определена позиция
            Gosho.Sort(); //Сортира елементите в списъка
            Gosho.Reverse();
            Gosho.Take(i); //взема елемент с индекс i;
            Gosho.Skip(i); // подминава индекс от масива;
            Gosho.Skip(i).Take(i + 1);// propuska i и взема i+1;
            Gosho.Sum(); // за интов масив дава сумата му;
            Gosho.Split();  // дели данните. сплитва ги по даден критерий.
            Gosho.Add(word.Substring(0, drunDrun)); // оформяне на Substring

            //---------------------------------------------------------------------------------------

            Gosho.Insert(x,y)
                Gosho.Contains(x);
            Gosho.Count();
            Gosho.Add(X or "name");
            Gosho.Remove(X or "name");
            Gosho.RemoveAt(x);
            Gosho.RemoveAll(x or "name");
            Gosho.AddRange(x, y, z);
            Gosho.InsertRange(x, Array[]);
            Gosho.Sort();
            Gosho.Reverse();
            Gosho.Skip();
            Gosho.Skip(i).Take(i + 1);
            Gosho.Sum()
            Gosho.Split();
            Gosho.Add(word.Substring(0, drunDrun))






            //Gosho tosho pesho kiro na bairo i baba mu


        }
    }
}
