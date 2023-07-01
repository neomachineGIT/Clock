//NEOmachine
using System;

namespace Clock
{
    internal class Bloques
    {
        //LOS PARAMETROS DEFINEN: numero-renglones, ancho de linea del bloque,
        //                        posicion del borde superior, pocicion del bloque-ejeX,

        public void Lineas(int lin, int ancho, int altur, int ejeX)
        {
            int cont = altur;

            for (int i = 1; i <= lin; i++)
            {
                Console.SetCursorPosition(ejeX, cont);
                Escritura(ancho);
                cont++;
            }
            void Escritura(int veces)
            {
                DateTime fe_ti = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);

                string AmPm = fe_ti.ToString("HH");
                int ampm = int.Parse(AmPm);
                for (int i = 1; i <= veces; i++)
                {
                    Color();
                    Console.Write("X");
                }
                void Color() //Método que permite cambiar color a nocturno  a la hora fijada 
                             //por los if() 
                {
                    if (ampm < 06)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    if(ampm > 19 )
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                }
            }
        }
    }
}

