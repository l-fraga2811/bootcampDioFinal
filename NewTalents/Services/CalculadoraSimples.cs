using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewTalents.Services
{
    public class CalculadoraSimples
    {
        private List<string> listaHistorico;

        public CalculadoraSimples() 
        {
            listaHistorico = new List<string>();
        }
        public int Soma(int num1, int num2)
        {
            int resultado = num1 + num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int Subtrarir (int num1, int num2)
        {
            var resultado = num1 - num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int Multiplicar (int num1, int num2)
        {
            var resultado = num1 * num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public float Dividir (int num1, int num2)
        {
            var resultado = num1 / num2;
            listaHistorico.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public List<string> Historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}