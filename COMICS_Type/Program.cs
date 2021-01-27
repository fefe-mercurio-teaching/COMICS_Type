using System;
using System.Collections.Generic;

namespace COMICS_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listaGenerica = new List<object>();

            listaGenerica.Add(10);
            listaGenerica.Add(1.1f);
            listaGenerica.Add("Prova");
            listaGenerica.Add(true);

            Aggiungi1AgliElementi(listaGenerica);
            Aggiungi1AgliElementi(listaGenerica);

            foreach (object oggetto in listaGenerica)
            {
                Console.WriteLine(oggetto.ToString());
            }
        }

        static void Aggiungi1AgliElementi(List<object> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].GetType() == typeof(int))
                {
                    lista[i] = (int)lista[i] + 1;
                }
                else if (lista[i].GetType() == typeof(float))
                {
                    lista[i] = (float)lista[i] + 1;
                }
            }
        }
    }
}
