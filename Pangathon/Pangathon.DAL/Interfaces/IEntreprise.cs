using System;
using System.Collections.Generic;
using System.Text;

namespace Pangathon.DAL.Interfaces
{
    public interface IEntreprise<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Telephone { get; set; }
        string Description { get; set; }
        IAdresse<Guid> Adresse { get; set; }
    }
}
