using System;
using TrabalhandoComListas.Consultas;

namespace TrabalhandoComListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listaDeFornecedores = BuscarFornecedor.BuscarTodos();

            //1. Buscar Fornecedores que o nome se inicie com a letra 'A'

            //2. Buscar Fornecedores que o nome se termine com a letra 'S'

            //3. Buscar Fornecedores que o sobrenome se inicie com a letra 'B'

            //4. Buscar Fornecedores que o sobrenome se termine com a letra 'O'

            //5. Buscar Fornecedores que moram na rua guaporé

            //6. Buscar Fornecedores que o contato comece com '93' sem contar com o DDD

            //7. Buscar Fornecedores exclusivos

            Console.WriteLine();
        }
    }
}
