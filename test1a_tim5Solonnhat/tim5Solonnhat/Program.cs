using System;

namespace timsolonnhat
{
    class TestCsharp
    {
        public static void Main()
        {

            int n, i, so1, so2, so3, so4, so5;
            int[] arr1 = new int[50];

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());


            }
            int j = 0;
            so1 = 0;

            for (i = 0; i < n; i++)
            {
                if (so1 < arr1[i])
                {
                    so1 = arr1[i];
                    j = i;
                }
            }
            
            so2 = 0;
            int k = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (so2 < arr1[i])
                    {
                        so2 = arr1[i];
                        k = i;
                    }
                }
            }
            int x=0;
            so3 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == k || i == j )
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (so3 < arr1[i])
                    {
                        so3 = arr1[i];
                        x = i;
                    }
                }
            }
            int v = 0;
            so4 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == k || i == j || i == x)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (so4 < arr1[i])
                    {
                        so4 = arr1[i];
                        v=i;
                    }
                }
            }
            so5 = 0;
            for (i = 0; i < n; i++)
            {
                if (i == k || i == j || i == x || i==v)
                {
                    i++;  
                    i--;
                }
                else
                {
                    if (so5 < arr1[i])
                    {
                        so5 = arr1[i];

                    }
                }
            }

            Console.Write("5 Phan tu lon thu nhat trong mang la:  {0} {1} {2} {3} {4}\n\n", so1 ,so2, so3, so4, so5) ;
           

            Console.ReadKey();
        }
    }
}