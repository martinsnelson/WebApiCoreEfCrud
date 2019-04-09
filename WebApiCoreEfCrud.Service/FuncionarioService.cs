using System.Collections.Generic;
using WebApiCoreEfCrud.Interface.DAL;
using WebApiCoreEfCrud.Interface.Service;
using WebApiCoreEfCrud.Models.Funcionario;

namespace WebApiCoreEfCrud.Service
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioDAL _iFuncionarioDAL;
        public FuncionarioService(IFuncionarioDAL iFuncionarioDAL)
        {
            _iFuncionarioDAL = iFuncionarioDAL;
        }

        public IEnumerable<Funcionario> ObterFuncionarios()
        {
            return _iFuncionarioDAL.ObterFuncionarios();
        }

    }
}
