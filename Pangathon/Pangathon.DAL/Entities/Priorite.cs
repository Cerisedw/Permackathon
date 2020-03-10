using System;
using Pangathon.DAL.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Priorite")]
    public class Priorite : IPriorite<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public int Niveau { get; set; }
    }
}
