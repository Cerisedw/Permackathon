﻿using Pangathon.DAL.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pangathon.DAL.Entities
{
    [Table("Role")]
    public class Role : IRole<Guid>
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Description { get; set; }
    }
}
