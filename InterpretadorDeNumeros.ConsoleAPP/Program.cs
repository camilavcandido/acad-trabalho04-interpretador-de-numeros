using System;

namespace InterpretadorDeNumeros.ConsoleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dados = "     __  __      __  __  __  __  __  __ " + Environment.NewLine +
                           "   | __| __||__||__ |__    ||__||__||  |" + Environment.NewLine +
                           "   ||__  __|   | __||__|   ||__| __||__|";

            System.IO.StringReader leitor = new System.IO.StringReader(dados);

            string primeiraLinha = leitor.ReadLine();
            char[] charPrimeiraLinha = primeiraLinha.ToCharArray();
            string segundaLinha = leitor.ReadLine();
            char[] charSegundaLinha = segundaLinha.ToCharArray();
            string terceiraLinha = leitor.ReadLine();
            char[] charTerceiraLinha = terceiraLinha.ToCharArray();

            string strNumero = "";
            string strPrimeiraLinha = "";
            string strSegundaLinha = "";
            string strTerceiraLinha = "";
            int contador = 0;

            for (int i = 0; i <= 39; i++)
            {
                strPrimeiraLinha += charPrimeiraLinha[i];
                strSegundaLinha += charSegundaLinha[i];
                strTerceiraLinha += charTerceiraLinha[i];

                if (strPrimeiraLinha == "    " && strSegundaLinha == "   |" && strTerceiraLinha == "   |")
                {
                    strNumero += "1";

                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == " __|" && strTerceiraLinha == "|__ ")
                {
                    strNumero += "2";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == " __|" && strTerceiraLinha == " __|")
                {
                    strNumero += "3";
                }
                else if (strPrimeiraLinha == "    " && strSegundaLinha == "|__|" && strTerceiraLinha == "   |")
                {
                    strNumero += "4";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "|__ " && strTerceiraLinha == " __|")
                {
                    strNumero += "5";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "|__ " && strTerceiraLinha == "|__|")
                {
                    strNumero += "6";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "|__ " && strTerceiraLinha == "|__|")
                {
                    strNumero += "6";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "   |" && strTerceiraLinha == "   |")
                {
                    strNumero += "7";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "|__|" && strTerceiraLinha == "|__|")
                {
                    strNumero += "8";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "|__|" && strTerceiraLinha == " __|")
                {
                    strNumero += "9";
                }
                else if (strPrimeiraLinha == " __ " && strSegundaLinha == "|  |" && strTerceiraLinha == "|__|")
                {
                    strNumero += "0";
                }

                contador++;
                if (contador == 4)
                {
                    strPrimeiraLinha = "";
                    strSegundaLinha = "";
                    strTerceiraLinha = "";
                    contador = 0;
                }

            }

            Console.Write(strNumero);

            Console.ReadLine();
        }
    }
}
