using System;
using System.Collections.Generic;
using System.Text;

namespace Pangathon.DAL.Interfaces
{
    public interface IType<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Description { get; set; }
        IType<Guid> Parent { get; set; }
    }
}
