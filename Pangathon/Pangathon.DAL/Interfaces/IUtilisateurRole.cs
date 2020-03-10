using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateurRole
    {
        IUtilisateur<Guid> Utilisateur { get; set; }
        IRole<Guid> Role { get; set; }
    }
}
