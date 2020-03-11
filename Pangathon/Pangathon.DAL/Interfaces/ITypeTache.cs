using Pangathon.DAL.Entities;

namespace Pangathon.DAL.Interfaces
{
    public interface ITypeTache : IEntity
    {
        string Nom { get; set; }
        string Description { get; set; }
        TypeTache Parent { get; set; }
    }
}
