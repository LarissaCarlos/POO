using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP1
{
    public class FornecedorRepositorio 
    {
        public class FornecedorRepository
    {
        private readonly List<Fornecedor> _fornecedores = new List<Fornecedor>();

        public void Adicionar(Fornecedor fornecedor)
        {
            fornecedor.Id = ProximoId();
            _fornecedores.Add(fornecedor);
        }

        public IEnumerable<Fornecedor> Listar()
        {
            return _fornecedores;
        }

        public Fornecedor ObterPorId(int id)
        {
            return _fornecedores.FirstOrDefault(f => f.Id == id);
        }

        public int ProximoId()
        {
            return _fornecedores.Count + 1;
        }

        public void ListarFornecedores()
            {
                if (_fornecedores == null || _fornecedores.Count == 0)
                {
                    Console.WriteLine("Nenhum fornecedor cadastrado.");
                }
                else
                {
                    Console.WriteLine("Fornecedores cadastrados:");
                    foreach (var fornecedor in _fornecedores)
                    {
                        Console.WriteLine($"- ID: {fornecedor.Id}, Nome: {fornecedor.Nome}, CNPJ: {fornecedor.Cnpj}");
                    }
                }
            }
    }
    }
}