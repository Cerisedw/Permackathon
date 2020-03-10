namespace Pangathon.DAL.Interfaces
{
    public interface IEntity<TIdType>
    {
        TIdType Id { get; set; }
    }
}
