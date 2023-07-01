//NEOmachine
using System;
using System.Threading;


namespace Clock
{
    internal class Display : Bloques
    {
        //Clase que dibuja el caracter
        public void DijiClock()
        {
            Numeros obj = new Numeros();
            Console.WriteLine("________________");
            Maquina();
            void Maquina()
            {
                while (true)
                {
                    DateTime fe_ti = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);
                    Thread.Sleep(400);
                    string HoMi = fe_ti.ToString("hh" + "mm");
                    Plantilla(HoMi[0], 10, 5);
                    Plantilla(HoMi[1], 25, 5);
                    Plantilla(':', 44, 5);
                    Plantilla(HoMi[2], 55, 5);
                    Plantilla(HoMi[3], 72, 5);
                    Thread.Sleep(400);
                    Console.Clear();
                }
            }
            void Plantilla(Char n, int x, int y)
            {
                switch (n)
                {
                    case '0':
                        obj.Cero(x, y);
                        break;
                    case '1':
                        obj.Uno(x, y);
                        break;
                    case '2':
                        obj.Dos(x, y);
                        break;
                    case '3':
                        obj.Tres(x, y);
                        break;
                    case '4':
                        obj.Cuatro(x, y);
                        break;
                    case '5':
                        obj.Cinco(x, y);
                        break;
                    case '6':
                        obj.Seis(x, y);
                        break;
                    case '7':
                        obj.Siete(x, y);
                        break;
                    case '8':
                        obj.Ocho(x, y);
                        break;
                    case '9':
                        obj.Nueve(x, y);
                        break;
                    case ':':
                        obj.Separador(x, y);
                        break;
                }

            }
        }
    }
}
