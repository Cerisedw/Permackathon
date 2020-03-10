using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    public class Entreprise : IEntreprise<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Telephone { get; set; }
        public string Description { get; set; }
        [Required]
        public IAdresse<Guid> Adresse { get; set; }
    }
}
