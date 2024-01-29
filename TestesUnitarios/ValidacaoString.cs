using System;

namespace TestesUnitarios
{
    public class ValidacaoString
    {
        public bool VerificarStringVazia(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        public int ObterComprimentoString(string input)
        {
            return input.Length;
        }

        public string ConcatenarStrings(string str1, string str2)
        {
            return str1 + str2;
        }
    }
}
