using Pangathon.DAL.Entities;

namespace Pangathon.DAL.Interfaces
{
    public interface IAdresse<TIdType> : IEntity<TIdType>
    {
        string Rue { get; set; }
        string Numero { get; set; }
        string Boite { get; set; }
        string CodePostal { get; set; }
        Ville Ville { get; set; }
    }
}
