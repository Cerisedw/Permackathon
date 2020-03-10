using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Participant")]
    public class Participant : IParticipant
    {
        public Guid IdTache { get; set; }
        public Tache Tache { get; set; }
        public Guid IdUtilisateur { get; set; }
        public Utilisateur Utilisateur { get; set; }
    }
}
