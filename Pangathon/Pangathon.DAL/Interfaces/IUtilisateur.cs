﻿using System;

namespace Pangathon.DAL.Interfaces
{
    public interface IUtilisateur<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Image { get; set; }
        string Telephone { get; set; }
        IEntreprise Entreprise { get; set; }
        IPoste Poste { get; set; }
    }
}
