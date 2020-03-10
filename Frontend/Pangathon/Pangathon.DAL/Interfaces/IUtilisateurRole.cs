using Pangathon.DAL.Entities;
using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateurRole
    {
        Guid IdUtilisateur { get; set; }
        Utilisateur Utilisateur { get; set; }
        Guid IdRole { get; set; }
        Role Role { get; set; }
    }
}
