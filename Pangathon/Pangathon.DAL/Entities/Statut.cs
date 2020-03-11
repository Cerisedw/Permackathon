using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Statut")]
    public class Statut : IStatut
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
    }
}
