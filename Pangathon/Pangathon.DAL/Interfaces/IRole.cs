using Pangathon.DAL.Entities;
using System.Collections.Generic;

namespace Pangathon.DAL.Interfaces
{
    public interface IRole : IEntity
    {
        string Nom { get; set; }
        string Description { get; set; }
        List<UtilisateurRole> UtilisateurRoles { get; set; }
    }
}
