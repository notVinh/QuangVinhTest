using System;

namespace timptxuathiennhieunhat
{
    class TestCsharp
    {
        public static void Main()
        {

            string[] arr1 = new string[100];
            int[] fr1 = new int[100];
            int n, i, j, bien_dem;


            Console.Write("\nPhan tu xuat hien nhieu nhat trong mang\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToString(Console.ReadLine());
                fr1[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        bien_dem++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = bien_dem;
                }
            }

            int mx = fr1[0];
            for (i = 1; i < n; i++)
            {
                if (fr1[i] > mx)
                {
                    mx = fr1[i];
                }



            }

            for (i = 0; i < n; i++)
            {
                if (mx == fr1[i])
                {
                    Console.Write("Phan tu xuat hien nhieu nhat trong mang la ' {0} ' voi so lan xuat hien la {1} lan\n", arr1[i], mx);

                }
            }

            Console.ReadKey();
        }
    }
}
