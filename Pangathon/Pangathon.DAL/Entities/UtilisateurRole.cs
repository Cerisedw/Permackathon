using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("UtilisateurRole")]
    public class UtilisateurRole : IUtilisateurRole
    {
        public Guid IdUtilisateur { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public Guid IdRole { get; set; }
        public Role Role { get; set; }
    }
}
