using System.Collections.Generic;
using TrabalhandoComListas.Modelos;

namespace TrabalhandoComListas.Consultas
{
    static class BuscarFornecedor
    {
        public static List<Fornecedor> BuscarTodos()
        {
            var listaComTodosOsFornecedores = new List<Fornecedor>()
            {
                new Fornecedor(1, "Anderson", "Iankovisk", "R. Venezuela, 1475", "69984576424", false),
                new Fornecedor(2, "Vinicius", "Onofre", "R. Imigrantes, 512", "6993848199", false),
                new Fornecedor(3, "Roberta", "Brito", "R. Guaporé, 120", "6934986200", true),
                new Fornecedor(4, "Joana", "Monteiro", "R. Mamoré, 1620", "6914279123", false),
                new Fornecedor(5, "Paulina", "Ferreira", "R. Calama, 1530", "6955908321", true),
                new Fornecedor(6, "Andreia", "Vieira", "R. Guaporé, 3314", "6900892744", true),
                new Fornecedor(7, "Maico", "Braga", "R. Buenos Aires, 7689", "6935670912", false),
                new Fornecedor(8, "Jorge", "Silva", "R. Campo Sales, 3041", "6914798539", true),
                new Fornecedor(9, "Lucas", "Tavares", "R. Vitória Régia, 6331", "6993954898", true),
            };

            return listaComTodosOsFornecedores;
        }
    }
}
