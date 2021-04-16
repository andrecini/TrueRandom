using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DataRandom
{
    class TrueRandom
    {
        private Stopwatch sw = new Stopwatch();
        private Random rdm = new Random();

        #region Set Binary
        public int SetBinary()
        {
            return int.Parse(SetInterval().ToString()) % 2;
        }

        private double SetInterval()
        {
            sw.Start();
            Delay();
            sw.Stop();

            double interval = sw.ElapsedTicks;

            VerifyInterval(ref interval);

            return interval;
        }
        
        private void Delay()
        {
            sw.Start();
            sw.Stop();

            double interval = sw.ElapsedTicks;

            VerifyInterval(ref interval);

            for (int i = 0; i < interval; i++)
            {
                continue;
            }
        }

        private void VerifyInterval(ref double interval)
        {
            if (interval > 5)
            {
                interval = rdm.Next(5);
            }
        }
        #endregion

        #region Set Integer
        public long SetInteger(int max)
        {
            long maxValue = DecimalToBinary(max.ToString());
            string value;
            
            do
            {
                value = SetValue(maxValue.ToString().Length);
            } while (double.Parse(value) > maxValue);

            return BinaryToDecimal(value);
        }

        public long SetInteger(int min, int max)
        {
            long maxValue = DecimalToBinary(max.ToString());
            long minValue = DecimalToBinary(min.ToString());
            string value;

            do
            {
                value = SetValue(maxValue.ToString().Length);
            } while (double.Parse(value) > maxValue || double.Parse(value) < minValue);

            return BinaryToDecimal(value);
        }

        private long DecimalToBinary(string numero)
        {

            string valor = "";

            int dividendo = Convert.ToInt32(numero);

            if (dividendo == 0 || dividendo == 1)
            {

                return dividendo;

            }

            else
            {

                while (dividendo > 0)
                {

                    valor += Convert.ToString(dividendo % 2);

                    dividendo = dividendo / 2;

                }

                return long.Parse(InvertString(valor));

            }

        }

        private int BinaryToDecimal(string valorBinario)
        {

            int expoente = 0;

            int numero;

            int soma = 0;

            string numeroInvertido = InvertString(valorBinario);

            for (int i = 0; i < numeroInvertido.Length; i++)
            {

                //pega dígito por dígito do número digitado

                numero = Convert.ToInt32(numeroInvertido.Substring(i, 1));

                //multiplica o dígito por 2 elevado ao expoente, e armazena o resultado em soma

                soma += numero * (int)Math.Pow(2, expoente);

                // incrementa o expoente

                expoente++;

            }

            return soma;

        }

        private string InvertString(string str)
        {
            int tamanho = str.Length;

            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }

            return new string(caracteres);
        }

        private string SetValue(int length)
        {
            string value = string.Empty;

            for (int i = 0; i < length; i++)
            {
                value += SetBinary();
            }

            return value;
        }
        #endregion

        #region Commum

        #endregion
    }
}
