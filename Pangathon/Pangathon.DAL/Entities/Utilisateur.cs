using Pangathon.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Utilisateur")]
    public class Utilisateur : IUtilisateur
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
        public Entreprise Entreprise { get; set; }
        [Required]
        public Poste Poste { get; set; }
        public List<UtilisateurRole> UtilisateurRoles { get; set; }
        public List<Participant> Participations { get; set; }
    }
}
