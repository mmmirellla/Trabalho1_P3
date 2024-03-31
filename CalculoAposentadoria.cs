using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class CalculoAposentadoria
    {
        public static void Aposentadoria(int idade)
        {
            int idadeAposentadoria = 65;
            if (idade >= idadeAposentadoria) 
            {
                Console.WriteLine("Você ja está apto para aposentar!");
            }

            else 
            {
                Console.WriteLine($"Você não tem idade suficiente para aposentar! \nFaltam { idadeAposentadoria - idade} anos para você se aposentar.");
            }
        }
     }
}
