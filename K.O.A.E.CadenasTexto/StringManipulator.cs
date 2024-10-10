using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K.O.A.E.CadenasTexto
{
    public class StringManipulator
    {
        // Implementa la inversion de la cadena 
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] array = input.ToCharArray();
            System.Array.Reverse(array);
            return new string(array);
        }

        //Implementa la eliminacion de espacios en blanco
        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
