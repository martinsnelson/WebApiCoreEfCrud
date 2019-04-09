using System.ComponentModel.DataAnnotations;

namespace WebApiCoreEfCrud.Models.Funcionario
{
    public class Funcionario
    {
        [Key]
        public int ID { get; set; }
        public string FNome { get; set; }
        public string FSobreNome { get; set; }
        public string email { get; set; }
        public string genero { get; set; }
    }
}
