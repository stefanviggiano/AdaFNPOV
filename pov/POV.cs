using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POV
{
    public class POV
    {
        static void Main()
        {
        Console.WriteLine(funcaoRetornaQuantidadePOV(0.1M, 90));
        Console.WriteLine(funcaoRetornaQuantidadePOV(0.1M, 100));
        Console.WriteLine(funcaoRetornaQuantidadePOV(0.2M, 70));
        }

        public static int funcaoRetornaQuantidadePOV(decimal porcentagem,
                int totalNegociado)
            => (int) ((totalNegociado*porcentagem)/(1-porcentagem));
    }

}



