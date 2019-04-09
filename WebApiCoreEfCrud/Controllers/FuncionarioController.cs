using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoreEfCrud.Interface.Service;
using WebApiCoreEfCrud.Models.Funcionario;

namespace WebApiCoreEfCrud.Controllers
{
    [Route("V1/api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioService _iFuncionarioService;
        public FuncionarioController(IFuncionarioService iFuncionarioService)
        {
            _iFuncionarioService = iFuncionarioService;
        }

        [HttpGet]
        public IEnumerable<Funcionario> ObterFuncionarios()
        {
            return _iFuncionarioService.ObterFuncionarios();
        }
    }
}