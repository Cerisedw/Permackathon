using Pangathon.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Pangathon.DAL.Interfaces
{
    public interface ITache<TIdType> : IEntity<TIdType>
    {
        string Nom { get; set; }
        string Description { get; set; }
        DateTime DateCreation { get; set; }
        DateTime DateDeadline { get; set; }
        Utilisateur Createur { get; set; }
        Priorite Priorite { get; set; }
        Statut Statut { get; set; }
        Entreprise Entreprise { get; set; }
        TypeTache TypeTache { get; set; }
        List<Participant> Participants { get; set; }
        List<Commentaire> Commentaires { get; set; }
    }
}
