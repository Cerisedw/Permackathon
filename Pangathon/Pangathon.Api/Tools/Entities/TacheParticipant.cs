using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools.Entities
{
    public class TacheParticipant
    {
        public Guid TacheId { get; set; }
        public Guid UtilisateurId { get; set; }
    }
}
