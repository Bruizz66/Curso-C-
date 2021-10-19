using System;
using System.Collections;

namespace bitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray myBA1 = new BitArray( new byte[] {1,2,4,8,16 });
            BitArray myBA2 = new BitArray(5, true);
            mostrarBitArray(myBA1);

            bool[] myBools = new bool[4] {true, true, false, false};
            BitArray myBA3 = new BitArray(myBools);

            Console.WriteLine("\n");

            //Cantidad de elementos de mi arreglo
            //Como se tiene un arreglo de byte´s entonces cada numero corresponde a un bit. Por lo tanto 5*8=40 elementos 
            Console.WriteLine(myBA1.Count);
            
        }

        public static void mostrarBitArray(BitArray arreglo)
        {
            int contador = 0;
            foreach(bool obj in arreglo)
            {
                contador++;

                if (obj)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("0");
                }

                if(contador%8 == 0)
                {
                    Console.Write("\r");
                }
            }
        }
    }
}
