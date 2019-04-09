using System;
using System.Collections.Generic;
using System.Text;
using WebApiCoreEfCrud.Models.Funcionario;

namespace WebApiCoreEfCrud.Interface.Service
{
    public interface IFuncionarioService
    {
        IEnumerable<Funcionario> ObterFuncionarios();
    }
}
