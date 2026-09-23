using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos

        private int _tope;
        private int[] _arreglo;

        private bool ascendente;

        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        //Propiedades 
        public int N  { get; }
        public bool EstaVacio => _tope == 0;
        public bool EstaLleno => _tope == N;

        //Métodos
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
           
            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);
            }
            _tope = N;
        }

        //Metodo Ordenar
        public void Ordenar()
        {
            Ordenar(true);
        }

        //Metodo Ordenar
        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
                    else
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                    }
             
                }
            }
        }
      
        //Metodo Cambiar
        public void Cambiar(ref int a,  ref int b)
        {
            int aux = a;
            a = b;
            b = aux;

        }

        public override string ToString()
        {

            if (EstaVacio)
            {
               return "El arreglo está vacío";
            }

            string salida = string.Empty;

            int contador = 0;

            for (int i = 0; i < _tope; i++)
            {
                salida += $"{_arreglo[i]} ";
                contador++;

                if (contador > 9)
                {
                    contador = 0;
                    salida += "\n";
                }
            }
            return salida;
        }
    }
}
