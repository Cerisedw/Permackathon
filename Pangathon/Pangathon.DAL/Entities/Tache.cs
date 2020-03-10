using Pangathon.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Tache")]
    public class Tache : ITache<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        public DateTime DateDeadline { get; set; }
        [Required]
        public IUtilisateur<Guid> Createur { get; set; }
        [Required]
        public IPriorite<Guid> Priorite { get; set; }
        [Required]
        public IStatut<Guid> Statut { get; set; }
        [Required]
        public IEntreprise<Guid> Entreprise { get; set; }
        [Required]
        public IType<Guid> Type { get; set; }
        public List<IParticipant> Participants { get; set; }
        public List<ICommentaire<Guid>> Commentaires { get; set; }
    }
}
