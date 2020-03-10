using System;
using System.Collections.Generic;
using System.Text;

namespace Pangathon.DAL.Interfaces
{
    public interface IPoste<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Description { get; set; }
    }
}
