using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoLenguajeHacker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> LenguajeHacker = new Dictionary<char, string>();
            char[] abecedario = new char[26];
            
            CrearCadenaAbecedario(abecedario);
            ArmarDiccionarioHacker(LenguajeHacker, abecedario, CrearCadenaSimbolosHacker());
            

            string texto = "texto a encriptar";
            texto=  texto.ToUpper();
            Console.WriteLine(texto);
            Console.WriteLine();
            Console.WriteLine(EncriptarTexto(LenguajeHacker,texto));

            Console.ReadLine();
        }

        private static string EncriptarTexto(Dictionary<char, string> lenguajeHacker, string texto)
        {
            string textoEncriptado="";

            foreach (var letra in texto)
            {
                string value;
                bool hasValue = lenguajeHacker.TryGetValue(letra, out value);
                if (hasValue)
                {
                    textoEncriptado += value;
                }
            }
            return textoEncriptado;
        }

        private static string[] CrearCadenaSimbolosHacker()
        {
            string cadenaValores = @"4-I3-[-)-3-|=-&-#-1-,_/->|-1-/\/\-^/-0-|*- (_,)-l2-5-7-(_)-\/-\/\/-><-j-2";
            string[] cadenaValoresSeparada = cadenaValores.Split('-');
            return cadenaValoresSeparada;
        }

        private static void CrearCadenaAbecedario(char[] abecedario)
        {
            var contador = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                abecedario[contador] = i;
                contador++;
            }        
        }

        private static void ArmarDiccionarioHacker(Dictionary<char, string>diccionario, char[] abecedario, string[] cadenaCodigos)
        {
            var contador = 0;
            foreach (var letra in abecedario)
            {
                diccionario.Add(letra, cadenaCodigos[contador]);
                contador++;
            }
        }
    }
}