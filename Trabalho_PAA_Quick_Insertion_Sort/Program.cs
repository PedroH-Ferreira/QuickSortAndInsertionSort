using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace Trabalho_PAA_Quick_Insertion_Sort
{
    internal class Program
    {
        public class QuicksortInsertionSort
        {
            static int contador = 0;
            static int movimentos = 0;

            #region Quick Sort
            public static void Sort(int[] list, int start, int end)
            {
                contador++;
                var insertion = end - start;

                if (start < end)
                {
                    if (insertion < 9)
                    {
                        InsertionSort(list, start, end + 1);
                    }
                    else
                    {
                        int pivot = Partition(list, start, end);

                        if (pivot > 1)
                        {
                            Sort(list, start, pivot - 1);
                        }
                        if (pivot + 1 < end)
                        {
                            Sort(list, pivot + 1, end);
                        }
                    }
                }
            }
            #endregion

            #region Insertin Sort
            private static void InsertionSort(int[] list, int start, int end)
            {
                for (int x = start + 1; x < end; x++)
                {
                    contador++;
                    int val = list[x];
                    int j = x - 1;

                    while (j >= 0 && val < list[j])
                    {
                        list[j + 1] = list[j];
                        j--;
                        movimentos++;
                    }

                    list[j + 1] = val;
                }
            }
            #endregion

            #region Partition
            private static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[left];
                while (true)
                {

                    while (arr[left] < pivot)
                    {
                        left++;
                    }

                    while (arr[right] > pivot)
                    {
                        right--;
                    }

                    if (left < right)
                    {
                        if (arr[left] == arr[right]) return right;

                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                        movimentos++;
                    }
                    else
                    {
                        return right;
                    }
                }
            }
            #endregion

            #region Funções Complementares
            public static int[] CreateRandomArray(int size)
            {
                var array = new int[size];
                var rand = new Random();

                for (int i = 0; i < size; i++)
                    array[i] = rand.Next(0, size - 1);

                return array;
            }

            public enum Arrays
            {
                Mil = 1000,
                DezMil = 10000,
                VinteMil = 20000,
                CinquentaMil = 50000,
                CemMil = 100000
            }

            public static int GetMovimentos() { return movimentos; }
            public static int ZeraMovimentos() { return movimentos = 0; }
            public static int GetCont() { return contador; }
            public static int ZeraCont() { return contador = 0; }
            #endregion
        }

        static void Main(string[] args)
        {
            Stopwatch tempoExecucao1 = new Stopwatch();
            Stopwatch tempoExecucao2 = new Stopwatch();
            Stopwatch tempoExecucao3 = new Stopwatch();
            Stopwatch tempoExecucao4 = new Stopwatch();
            Stopwatch tempoExecucao5 = new Stopwatch();

            var array1 = QuicksortInsertionSort.CreateRandomArray((int)QuicksortInsertionSort.Arrays.Mil);
            var array10 = QuicksortInsertionSort.CreateRandomArray((int)QuicksortInsertionSort.Arrays.DezMil);
            var array20 = QuicksortInsertionSort.CreateRandomArray((int)QuicksortInsertionSort.Arrays.VinteMil);
            var array50 = QuicksortInsertionSort.CreateRandomArray((int)QuicksortInsertionSort.Arrays.CinquentaMil);
            var array100 = QuicksortInsertionSort.CreateRandomArray((int)QuicksortInsertionSort.Arrays.CemMil);

            Console.WriteLine("Início da Execução");
            Console.WriteLine("==================\n");            

            #region Array 1000
            Console.WriteLine("Array 1.000\n");

            tempoExecucao1.Start();

            QuicksortInsertionSort.Sort(array1, 0, array1.Length - 1);

            tempoExecucao1.Stop();

            Console.WriteLine("Tempo de Execução: " + tempoExecucao1.Elapsed);
            Console.WriteLine("Comparações: " + QuicksortInsertionSort.GetCont()); ;
            Console.WriteLine("Movimentações: " + QuicksortInsertionSort.GetMovimentos());
            Console.WriteLine("====================\n");
            QuicksortInsertionSort.ZeraMovimentos();
            QuicksortInsertionSort.GetCont();
            #endregion

            #region Array 10.000
            Console.WriteLine("Array 10.000\n");

            tempoExecucao2.Start();

            QuicksortInsertionSort.Sort(array10, 0, array10.Length - 1);

            tempoExecucao2.Stop();

            Console.WriteLine("Tempo de Execução: " + tempoExecucao2.Elapsed);
            Console.WriteLine("Comparações: " + QuicksortInsertionSort.GetCont()); ;
            Console.WriteLine("Movimentações: " + QuicksortInsertionSort.GetMovimentos());
            Console.WriteLine("====================\n");
            QuicksortInsertionSort.ZeraMovimentos();
            QuicksortInsertionSort.GetCont();
            #endregion

            #region Array 20.000
            Console.WriteLine("Array 20.000\n");

            tempoExecucao3.Start();

            QuicksortInsertionSort.Sort(array20, 0, array20.Length - 1);

            tempoExecucao3.Stop();

            Console.WriteLine("Tempo de Execução: " + tempoExecucao3.Elapsed);
            Console.WriteLine("Comparações: " + QuicksortInsertionSort.GetCont()); ;
            Console.WriteLine("Movimentações: " + QuicksortInsertionSort.GetMovimentos());
            Console.WriteLine("====================\n");
            QuicksortInsertionSort.ZeraMovimentos();
            QuicksortInsertionSort.GetCont();
            #endregion

            #region Array 50.000
            Console.WriteLine("Array 50.000\n");

            tempoExecucao4.Start();

            QuicksortInsertionSort.Sort(array50, 0, array50.Length - 1);

            tempoExecucao4.Stop();

            Console.WriteLine("Tempo de Execução: " + tempoExecucao4.Elapsed);
            Console.WriteLine("Comparações: " + QuicksortInsertionSort.GetCont()); ;
            Console.WriteLine("Movimentações: " + QuicksortInsertionSort.GetMovimentos());            
            Console.WriteLine("====================\n");
            QuicksortInsertionSort.ZeraMovimentos();
            QuicksortInsertionSort.GetCont();
            #endregion

            #region Array 100.00
            Console.WriteLine("Array 100.000\n");

            tempoExecucao5.Start();

            QuicksortInsertionSort.Sort(array100, 0, array100.Length - 1);

            tempoExecucao5.Stop();

            Console.WriteLine("Tempo de Execução: " + tempoExecucao5.Elapsed);
            Console.WriteLine("Comparações: " + QuicksortInsertionSort.GetCont()); ;
            Console.WriteLine("Movimentações: " + QuicksortInsertionSort.GetMovimentos());
            Console.WriteLine("====================\n");
            QuicksortInsertionSort.ZeraMovimentos();
            QuicksortInsertionSort.GetCont();
            #endregion

            Console.WriteLine("Fim da Execução");
        }
    }
}