﻿using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se inicializa el arrayList
            ArrayList palabras = new ArrayList();
            // Se agregan valores uno por uno
            palabras.Add("HOLA");
            palabras.Add("MUNDO");
            palabras.Add("!!!");
            palabras.Add("C#");
            palabras.Add("Brayan");
            palabras.Add(76);

            //Se agregan valores en conjunto
            palabras.AddRange(new string[] { "Alexander", "Ruiz", "Palacio" });
            palabras.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine("Extraer un solo valor del ArrayList : {0}", palabras[4]);
            palabras.Remove("Brayan"); //Se elimina el valor indicado
            Console.WriteLine("Extraer un solo valor del ArrayList : {0}", palabras[4]);
            palabras.RemoveAt(4); // Se elimina el elemento en la posicion indicada
            Console.WriteLine("Extraer un solo valor del ArrayList : {0}", palabras[4]);



            //Propiedades de mi arrayList
            Console.WriteLine("Mi arrayList 'palabras' ");
            Console.WriteLine("   count:   {0}",palabras.Count);
            Console.WriteLine("   Capacity: {0}", palabras.Capacity);
            Console.WriteLine("Valores: ");
            PrintValues(palabras);
            palabras.RemoveRange(1, 3); // Se eliminan los datos del rango
            Console.WriteLine("\n");
            Console.WriteLine("Valores: ");
            PrintValues(palabras);


        }

        // Se muestran los valores
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.Write("   {0}", obj);

        }




    }
}

