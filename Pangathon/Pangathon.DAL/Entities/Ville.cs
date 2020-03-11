using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Ville")]
    public class Ville : IVille
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
    }
}
