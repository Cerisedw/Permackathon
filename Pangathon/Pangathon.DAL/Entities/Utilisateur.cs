using Pangathon.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Utilisateur")]
    public class Utilisateur : IUtilisateur<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Image { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public IEntreprise<Guid> Entreprise { get; set; }
        [Required]
        public IPoste<Guid> Poste { get; set; }
        public List<IRole<Guid>> Roles { get ; set ; }
        public List<IParticipant> Participations { get; set; }
    }
}
