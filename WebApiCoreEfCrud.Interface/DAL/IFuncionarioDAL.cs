using System.Collections.Generic;
using WebApiCoreEfCrud.Models.Funcionario;

namespace WebApiCoreEfCrud.Interface.DAL
{
    public interface IFuncionarioDAL
    {
        IEnumerable<Funcionario> ObterFuncionarios();
    }
}