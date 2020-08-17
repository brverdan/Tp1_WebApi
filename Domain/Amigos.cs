using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Amigos
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "O {0} precisa ter entre {2} e {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "O {0} precisa ter entre {2} e {1}")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [EmailAddress(ErrorMessage = "Insira um email válido!")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "O {0} precisa ter entre {2} e {1}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataAniversario { get; set; }

        public Amigos()
        {
        }

        public Amigos(string nome, string sobrenome, DateTime dataAniversario, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataAniversario = dataAniversario;
            Email = email;
        }
    }
}
