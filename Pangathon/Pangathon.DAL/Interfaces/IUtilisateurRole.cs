using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateurRole
    {
        Guid IdUtilisateur { get; set; }
        IUtilisateur<Guid> Utilisateur { get; set; }
        Guid IdRole { get; set; }
        IRole<Guid> Role { get; set; }
    }
}
