using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ugb.Models
{
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Curso")]
        public string Course { get; set; }

        [Required]
        [Display(Name = "Matricula")]
        public string StudentRegistration { get; set; }
    
        [Display(Name = "Rua")]
        public string Street { get; set; }

        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Celular")]
        public string StatCellphonee { get; set; }

        [Display(Name = "Telefone")]
        public string Telephone { get; set; }

        [Display(Name = "Data")]
        public string Data { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required]
        public string Birthday { get; set; }

        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }
    }
}