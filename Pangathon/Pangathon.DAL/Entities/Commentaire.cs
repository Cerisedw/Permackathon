using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Commentaire")]
    public class Commentaire : ICommentaire<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        [Required]
        public string Contenu { get; set; }
        [Required]
        public ITache<Guid> Tache { get; set; }
        [Required]
        public IUtilisateur<Guid> Utilisateur { get; set; }
    }
}
