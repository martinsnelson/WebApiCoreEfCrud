using System;
using System.Collections.Generic;
using System.Text;
using WebApiCoreEfCrud.Interface.DAL;
using WebApiCoreEfCrud.Models.Funcionario;
using WebApiCoreEfCrud.Shared.Contexts.Funcionario;

namespace WebApiCoreEfCrud.DAL
{
    public class FuncionarioDAL : IFuncionarioDAL
    {
        private readonly FuncionarioContext _funcionarioContext;

        public FuncionarioDAL(FuncionarioContext funcionarioContext)
        {
            //_FuncionarioContext = funcionarioContext;
        }

        public IEnumerable<Funcionario> ObterFuncionarios()
        {
            //return _funcionarioContext.Funcionarios;
            throw new System.NotImplementedException();
        }
    }
}
