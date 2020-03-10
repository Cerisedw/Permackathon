using System;
using System.Collections.Generic;
using System.Text;

namespace Pangathon.DAL.Interfaces
{
    public interface IPriorite<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        int Niveau { get; set; }
    }
}
