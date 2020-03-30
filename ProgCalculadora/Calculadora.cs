using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora
{
    public class Calculadora
    {
        private List<double> listNumero = new List<double>();

        public void addNumero(double num)
        {
            this.listNumero.Add(num);
        }

        public double somar()
        {
            double resultado = 0;
            foreach(double num in this.listNumero)
            {
                resultado += num;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double subtrair()
        {
            double resultado = this.listNumero[0];
            this.listNumero.RemoveAt(0);
            foreach(double num in this.listNumero)
            {
                resultado -= num;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double multiplicar()
        {
            double resultado = 1;
            foreach (double numero in this.listNumero)
            {
                resultado *= numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double dividir()
        {
            double resultado = this.listNumero[0];
            foreach (double numero in this.listNumero)
            {
                resultado = this.listNumero[0] / numero;
            }
            this.listNumero.Clear();
            return resultado;
        }

        public double media()
        {
            double resultado = 0;
            double media = 0;
            int cont = 0;

            foreach (double numero in this.listNumero)
            {
                resultado += numero;
                cont++;
            }

            media = resultado / cont;
            return media;
        }

    }
}
