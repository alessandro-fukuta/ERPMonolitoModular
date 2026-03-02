using ERP.Interfaces.Repositories;
using ERP.Models.Entities;

namespace ERP.Repositories.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private static List<Cliente> clientes = new();

        public List<Cliente> Listar()
        {
            return clientes;
        }

        public void Adicionar(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1;

            clientes.Add(cliente);
        }

    }
}