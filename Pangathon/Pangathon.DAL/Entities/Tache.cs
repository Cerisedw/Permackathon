using Pangathon.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Tache")]
    public class Tache : ITache
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime DateCreation { get; set; }
        public DateTime? DateDeadline { get; set; }
        public DateTime? DateRealisation { get; set; }
        [Required]
        public Utilisateur Createur { get; set; }
        [Required]
        public Priorite Priorite { get; set; }
        [Required]
        public Statut Statut { get; set; }
        [Required]
        public Entreprise Entreprise { get; set; }
        [Required]
        public TypeTache TypeTache { get; set; }
        public List<Participant> Participants { get; set; }
        public List<Commentaire> Commentaires { get; set; }
    }
}
