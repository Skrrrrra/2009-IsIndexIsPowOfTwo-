using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace isIndexIsPowOfTwo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool Pow2(int k)
            {           //Проверка индекса на степень двойки.
                int m = 1;
                while (m <= k)
                {
                    if (k == m) return true;
                    m *= 2;
                }
                return false;
            }
            //путь

            string inputpath = "D:\\SolutionsForSpaceApp\\2009\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2009\\output.txt";

            //создание файлов
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.Create);
            fsout.Close();

            int amount;
            using (var reader = new StreamReader(inputpath))
            {
                amount = Convert.ToInt32(reader.ReadLine());  // записываем в переменную
            }

            string secondLine;
            using (var reader = new StreamReader(inputpath))
            {
                reader.ReadLine(); //пропуск 1 строки
                secondLine = reader.ReadLine();  // записываем в переменную
            }
            //запись из строки в массив строк с разделением
            string[] secondLineToInt = secondLine.Split(' ');

            int[] A;
            A = new int[amount+1];
            int count = 1;
            foreach (var s in secondLineToInt)
            {
                A[count] = Convert.ToInt32(s);
                count++;
            }

            List<int> listOfIndex = new List<int>();

            for (int i = 1; i < amount+1; i++)
            {
                if (Pow2(i) == true)
                {

                    listOfIndex.Add(A[i]);
                }
            }

            int sum = listOfIndex.Sum();
            


            File.AppendAllText(outputpath, sum.ToString());

        }
    }
}
