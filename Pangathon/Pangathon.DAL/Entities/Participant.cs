using using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Participant")]
    public class Participant : IParticipant<Guid>
    {
        [Required]
        public ITache<Guid> Tache { get; set; }
        [Required]
        public IUtilisateur<Guid> Utilisateur { get; set; }
    }
}
