using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Entreprise")]
    public class Entreprise : IEntreprise
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Telephone { get; set; }
        public string Description { get; set; }
        [Required]
        public Adresse Adresse { get; set; }
    }
}
