using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("UtilisateurRole")]
    public class UtilisateurRole : IUtilisateurRole
    {
        public Guid IdUtilisateur { get; set; }
        public IUtilisateur<Guid> Utilisateur { get; set; }
        public Guid IdRole { get; set; }
        public IRole<Guid> Role { get; set; }
    }
}
