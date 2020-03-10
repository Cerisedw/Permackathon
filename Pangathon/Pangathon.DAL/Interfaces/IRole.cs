namespace Pangathon.DAL.Interfaces
{
    public interface IRole<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Description { get; set; }
    }
}
