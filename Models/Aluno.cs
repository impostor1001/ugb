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
        public int PersonId;

        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Curso")]
        [Required]
        public string Course { get; set; }

        [Display(Name = "Matricula")]
        [Required]
        public string StudentRegistration { get; set; }
    
        [Display(Name = "Rua")]
        public string Street { get; set; }

        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Display(Name = "Estado")]
        public string State { get; set; }

        [Display(Name = "Telefone")]
        [Required]
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