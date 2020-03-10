using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Adresse")]
    public class Adresse : IAdresse<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Rue { get; set; }
        [Required]
        public string Numero { get; set; }
        public string Boite { get; set; }
        [Required]
        public string CodePostal { get; set; }
        [Required]
        public IVille<Guid> Ville { get; set; }
    }   
}
