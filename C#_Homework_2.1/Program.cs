using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            #region ЗАДАНИЕ 1
            // Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива
            int[] arr1 = new int[10];
            Random rnd1 = new Random();
            Console.WriteLine("Исходный целочисленный массив: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd1.Next(-20, 20);
                Console.Write("{0}\t", arr1[i]);
            }
            Console.WriteLine();

            int pos = 0;
            int neg = 0;
            int uniq = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    pos++;
                }
                else if (arr1[i] < 0)
                {
                    neg++;
                }
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 1; j < arr1.Length; j++)
                {
                    if (i != j)
                    {
                        uniq++;
                    }
                }
            }
            Console.Write("Количество положительных элементов: ");
            Console.Write(pos);
            Console.WriteLine();
            Console.Write("Количество отрицательных элементов: ");
            Console.Write(neg);
            Console.WriteLine();
            Console.Write("Количество уникальных элементов: ");
            Console.Write(uniq);
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 2
            // Создайте приложение, отображающее количество значений в массиве меньше заданного параметра пользователем

            int[] arr2 = new int[10];
            Random rnd2 = new Random();
            Console.WriteLine("Исходный целочисленный массив: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd2.Next(-20, 20);
                Console.Write("{0}\t", arr2[i]);
            }
            Console.WriteLine();

            Console.Write("Введите параметр (целое число): ");
            int a;
            a = int.Parse(Console.ReadLine());

            int smal = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < a)
                {
                    smal++;
                }
            }
            Console.Write("Количество элементов, меньших, чем введённый параметр: ");
            Console.Write(smal);
            Console.WriteLine();


            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 3
            // Пользователь вводит с клавиатуры три числа. Необходимо подсчитать сколько раз последовательность из этих трёх чисел встречается в массиве. 

            Console.Write("Введите 1-е число: ");
            int b;
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число: ");
            int c;
            c = int.Parse(Console.ReadLine());
            Console.Write("Введите 3-е число: ");
            int d;
            d = int.Parse(Console.ReadLine());

            int[] arr3 = new int[12] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0}\t", arr3[i]);
            }
            Console.WriteLine();

            int seq = 0;

            for (int j = 0; j < arr3.Length; j++)
            {
                if (arr3[j] == b || arr3[j + 1] == c || arr3[j + 2] == d)
                {
                    seq++;
                }
            }

            Console.Write("Количество последовательностей в массиве: ");
            Console.Write(seq);
            Console.WriteLine();

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 4
            // Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.

            int[] arr4 = new int[] { 1, 2, 3 };
            for (int i = 0; i < arr4.Length; i++)
            {
                Console.Write("{0}\t", arr4[i]);
            }

            Console.WriteLine();

            int[] arr5 = new int[] { 1, 0, 3, 4, 2 };
            for (int x = 0; x < arr5.Length; x++)
            {
                Console.Write("{0}\t", arr5[x]);
            }
            int[] temp = new int[3];

            Console.WriteLine();

            for (int i = 0; i < arr5.Length; i++)
            {
                for (int j = 0; j < arr4.Length; i++)
                {
                    if (arr5[i] == arr4[j])
                    {
                        temp[i] = arr5[i];
                    }
                }
            }

            for (int y = 0; y < temp.Length; y++)
            {
                Console.Write("{0}\t", temp[y]);
            }

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 5
            //Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве.

            //int[,] arr6 = new int[5, 5];
            //Random rnd3 = new Random();

            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr6.GetLength(1); j++)
            //    {
            //        arr6[i,j] = rnd3.Next(-20, 20);
            //        Console.Write("{0}\t", arr6[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //int min = 20;
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr6.GetLength(1); j++)
            //    {
            //        if (arr6[i,j] < min)
            //        {
            //            min = arr6[i, j];
            //        }
            //    }
            //}

            //int max = -20;
            //for (int i = 0; i < arr6.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr6.GetLength(1); j++)
            //    {
            //        if (arr6[i, j] > max)
            //        {
            //            max = arr6[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine();

            //Console.Write("Минимальное значение: ");
            //Console.Write(min);
            //Console.WriteLine();
            //Console.Write("Максимальное значение: ");
            //Console.Write(max);
            //Console.WriteLine();


            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 6
            // Пользователь вводит предложение с клавиатуры. Вам необходимо подсчитать количество слов в нём.

            Console.WriteLine("Введите предложение: ");
            string s1 = Console.ReadLine();
            int count = 0;
            char space = ' ';
            foreach (char a in s1)
            {
                if (a == space)
                {
                    count++;
                }
            }
            Console.Write("Количество слов в вашем предложении: ");
            Console.Write(count);
            Console.WriteLine();

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 7
            // Пользователь вводит предложение с клавиатуры. Вам необходимо перевернуть каждое слово предложения и отобразить результат на экран.

            Console.WriteLine("Введите предложение: ");
            string s2 = Console.ReadLine();
            string[] words = s2.Split();
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = new string(words[i].Reverse().ToArray());
            }
            Console.Write(string.Join(" ", words));

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 8
            // Пользователь вводит с клавиатуры предложение. Приложение должно посчитать количество гласных букв в нём.

            Console.WriteLine("Введите предложение: ");
            string s3 = Console.ReadLine();
            char[] vowels = new char[20] { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
            int count = 0;
            for (int i = 0; i < s3.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j] == s3[i])
                    {
                        count++;
                    }
                }
            }
            Console.Write("Количество гласных в вашем предложении: ");
            Console.Write(count);
            Console.WriteLine();

            #endregion

            Console.WriteLine();

            #region ЗАДАНИЕ 9
            // Реализуйте приложение для подсчёта количества вхождений подстроки в строку.

            Console.WriteLine("Введите строку: ");
            string s4 = Console.ReadLine();
            Console.WriteLine("Введите подстроку: ");
            string s5 = Console.ReadLine();
            int count = 0;
            foreach (string a in s4)
            {
                if (a == s5)
                {
                   count++;
                }
            }
            Console.Write("Количество вхождений подстроки в строку: ");
            Console.Write(count);
            Console.WriteLine();

            #endregion

        }
    }
}




