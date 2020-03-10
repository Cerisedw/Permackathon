namespace Pangathon.DAL.Interfaces
{
    public interface IVille<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
    }
}
