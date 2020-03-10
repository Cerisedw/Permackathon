﻿using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Participant")]
    public class Participant : IParticipant
    {
        public Guid IdTache { get; set; }
        public ITache<Guid> Tache { get; set; }
        public Guid IdUtilisateur { get; set; }
        public IUtilisateur<Guid> Utilisateur { get; set; }
    }
}
