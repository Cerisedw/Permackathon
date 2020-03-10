using Pangathon.DAL.Entities;

namespace Pangathon.DAL.Interfaces
{
    public interface IEntreprise<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Telephone { get; set; }
        string Description { get; set; }
        Adresse Adresse { get; set; }
    }
}
