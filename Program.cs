using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace exam
{
    class Program
    {
        

        public static void Main(string[] args)
        {
            Console.Write("Enter the no.of rows:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the no.of columns:");
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[N,M];

            for (int i = 0; i<N ; i++)
            {
                for(int j=0; j<M;j++)
                {
                 Console.Write("element - [{0},{1}] : ", i, j);
                 arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe matrix is : \n");
                for (int i = 0; i < N; i++)
                {
                    Console.Write("\n");
                    for (int j = 0; j < M; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\n\n");
                //Repetition count
                 Console.WriteLine("repetition count from user");
                int r= int.Parse(Console.ReadLine());

                //flattening 2D to 1D
                var inputList = new List<int>();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    inputList.Add(arr1[i, j]);
                }
            }

            var count1 = 0;
            var result1 = new List<int>();

            for (int key = 0; key < inputList.Count; key++)
            {
                var initialValue = inputList[key];
                if (!result1.Contains(initialValue))
                {
                    for (int innerKey = 0; innerKey < inputList.Count; innerKey++)
                    {
                        if (key != innerKey)
                        {
                            if (initialValue == inputList[innerKey])
                            {
                                count1 = count1 + 1;
                                
                            }
                        }
                    }
                    if (count1 == r - 1)
                                {
                                    if (!result1.Contains(initialValue))
                                    {
                                        result1.Add(initialValue);
                                    }
                                }
                }
                count1 = 0;
            }
            foreach(var el in result1)
                        {
                            Console.WriteLine("repeated element:"+ el.ToString());
                            Console.ReadLine();
                        }
        }
                
    }
}