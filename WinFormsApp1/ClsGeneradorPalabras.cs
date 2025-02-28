using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ClsGeneradorPalabras
    {
        public int Tamaño { get; set; }

        //Separarlo con comas ,
        public char[,] Celda { get; set; }

        private Random random;

        //Constructor
        public ClsGeneradorPalabras()
        {
            Tamaño = Tamaño;
            Celda = new char[Tamaño, Tamaño]; // Instanciar
            random = new Random();
            LimpiarCelda();
        }

        //Limpiar celda, constructor
        public void LimpiarCelda()
        {
            for (int i = 0; i < Tamaño; i++)
            {
                for (int j = 0; j < Tamaño; j++)
                {
                    Celda[i, j] = ' ';
                }
            }
        }

        //Metodo para colocar una palabra en el tablero de manera aleatoria
        public bool PalabraTablero(string Palabra)
        {
            int intentos = 100;
            while (intentos > 0) //Iteracion
            {
                int direccion = random.Next(0, 4);//Para las posiciones
                int fila = random.Next(0, Tamaño);
                int col = random.Next(0, Tamaño);
                int dfila = 0, dCol = 0;

                //Para no usar tanto if, se utiliza switch:
                switch (direccion)
                {
                    case 0:
                        dfila = 0; dCol = 1; //Horizontal -
                        break;

                    case 1:
                        dfila = 1; dCol = 0; //Vertical |
                        break;

                    case 2:
                        dfila = 1; dCol = 1; //Diagonal abajo-derecha
                        break;

                    case 3:
                        dfila = 1; dCol = -1; //Diagonal abajo-izquierda
                        break;
                }

                int finFila = fila + dfila * (Palabra.Length - 1);
                int finCol = col + dCol * (Palabra.Length - 1);

                if (finFila < 0 || finFila >= Tamaño || finCol < 0 || finCol >= Tamaño)
                {
                    intentos--;
                    continue;
                }

                // Verificar palabras para la secuencia
                bool canLugar = true;
                int filaActual = fila, colActual = col;
                for (int i = 0; i < Palabra.Length; i++)
                {
                    canLugar = false;
                    break;
                }

                filaActual += dfila;
                colActual += dCol;

                if (!canLugar)
                {
                    intentos--; //No permitir esos intentos
                    continue;
                }

                // Colocar palabra en el tablero
                filaActual = fila;
                colActual = col;
                for (int i = 0; i < Palabra.Length; i++)
                {
                    Celda[filaActual, filaActual] = Palabra[i];
                    filaActual += dfila;
                    colActual += dCol;
                }
                return true;
            }
            return false;
        }

        // Rellenar todas las celdas vacias
        public void LlenarCuadricullaAleatoria()
        {
            for (int i = 0; i < Tamaño; i++)
            {
                for (int j = 0;j < Tamaño; i++)
                {
                    //Validacion
                    if (Celda[i, j] == ' ')
                        Celda[i, j] = (char)('A' + random.Next(0, 26));//Tomar todas las letras de manera aleatoria
                }
            }
        }

        //Metodo principal para generar la sopa de letras
        public void GenerarSopa(List<string> palabras)
        {
            LimpiarCelda();
            foreach(string palabra in palabras)
            {
                PalabraTablero(palabra);
            }
            LlenarCuadricullaAleatoria();
        }

        //Lenar matriz generada

        public char[,] ObtenerGrid()
        {
            return Celda;
        }
    }
}
