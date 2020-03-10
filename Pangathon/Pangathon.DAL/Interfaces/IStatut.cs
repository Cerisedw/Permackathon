namespace Pangathon.DAL.Interfaces
{
    public interface IStatut<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
    }
}
