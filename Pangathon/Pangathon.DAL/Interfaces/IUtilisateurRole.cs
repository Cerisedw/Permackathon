using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateurRole
    {
        Guid UtilisateurId { get; set; }
        Utilisateur Utilisateur { get; set; }
        Guid RoleId { get; set; }
        Role Role { get; set; }
    }
}
