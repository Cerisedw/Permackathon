using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("UtilisateurRole")]
    public class UtilisateurRole : IUtilisateurRole
    {
        public Guid UtilisateurId { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
