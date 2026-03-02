using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ERP.Models.Entities;

namespace ERP.Interfaces.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> Listar();

        void Adicionar(Cliente cliente);
    }
}
