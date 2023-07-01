//NEOmachine
namespace Clock
{

    internal class Numeros : Bloques
    {
        //Clase encargada de crear los números 
        Bloques obnum = new Bloques();
        public void Cero(int x = 1, int y = 1)
        {
            obnum.Lineas(15, 4, y, x);
            obnum.Lineas(3, 4, y, x + 4);
            obnum.Lineas(3, 4, y + 12, x + 4);
            obnum.Lineas(15, 4, y, x + 8);
        }
        public void Uno(int x = 1, int y = 1)
        {
            obnum.Lineas(15, 4, y, x + 5);
        }
        public void Dos(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 12, y, x);
            obnum.Lineas(3, 4, y + 3, x + 8);
            obnum.Lineas(3, 12, y + 6, x);
            obnum.Lineas(3, 4, y + 9, x);
            obnum.Lineas(3, 12, y + 12, x);
        }
        public void Tres(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 12, y, x);
            obnum.Lineas(3, 4, y + 3, x + 8);
            obnum.Lineas(3, 12, y + 6, x);
            obnum.Lineas(3, 4, y + 9, x + 8);
            obnum.Lineas(3, 12, y + 12, x);
        }
        public void Cuatro(int x = 1, int y = 1)
        {
            obnum.Lineas(6, 4, y, x);
            obnum.Lineas(6, 4, y, x + 8);
            obnum.Lineas(3, 12, y + 6, x);
            obnum.Lineas(6, 4, y + 9, x + 8);

        }
        public void Cinco(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 12, y, x);
            obnum.Lineas(3, 4, y + 3, x);
            obnum.Lineas(3, 12, y + 6, x);
            obnum.Lineas(3, 4, y + 9, x + 8);
            obnum.Lineas(3, 12, y + 12, x);
        }
        public void Seis(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 12, y, x);
            obnum.Lineas(3, 4, y + 3, x);
            obnum.Lineas(3, 12, y + 6, x);
            obnum.Lineas(3, 4, y + 9, x);
            obnum.Lineas(3, 4, y + 9, x + 8);
            obnum.Lineas(3, 12, y + 12, x);
        }
        public void Siete(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 12, y, x);
            obnum.Lineas(1, 4, y + 3, x + 8);
            obnum.Lineas(1, 4, y + 4, x + 7);
            obnum.Lineas(1, 4, y + 5, x + 6);
            obnum.Lineas(1, 4, y + 6, x + 5);
            obnum.Lineas(8, 4, y + 7, x + 5);
        }
        public void Ocho(int x = 1, int y = 1)
        {
            obnum.Lineas(15, 4, y, x);
            obnum.Lineas(3, 4, y, x + 4);
            obnum.Lineas(3, 4, y + 6, x + 4);
            obnum.Lineas(3, 4, y + 12, x + 4);
            obnum.Lineas(15, 4, y, x + 8);
        }
        public void Nueve(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 12, y, x);
            obnum.Lineas(3, 4, y + 3, x);
            obnum.Lineas(3, 4, y + 3, x + 8);
            obnum.Lineas(3, 12, y + 6, x);
            obnum.Lineas(3, 4, y + 9, x + 8);
            obnum.Lineas(3, 12, y + 12, x);
        }
        public void Separador(int x = 1, int y = 1)
        {
            obnum.Lineas(3, 4, y + 3, x );
            obnum.Lineas(3, 4, y + 9, x );
        }
        
    }
}
