using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Euler22
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"D:\Visual Studio 2019\Euler22\p022_names.txt", Encoding.UTF8);
            string[] namesList = text.Split('\"');
            List<String> alphabetical = new List<String>();
            for (int i = 1; i < namesList.Length; i += 2)
            {
                alphabetical.Add(namesList[i].ToString());
            }
            alphabetical.Sort();
            string[] alphabeticalArr = alphabetical.ToArray();

            long total = 0;
            for (int i = 0; i < alphabeticalArr.Length; i++)
            {
                int localTotal = 0;
                for (int j = 0; j < alphabeticalArr[i].Length; j++)
                {
                    localTotal += char.ToUpper(alphabeticalArr[i][j]) - 64;
                }
                int score = (i + 1) * localTotal;
                total += score;
            }

            Console.WriteLine(total);
        }

        static public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        static public void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }



    }
}
