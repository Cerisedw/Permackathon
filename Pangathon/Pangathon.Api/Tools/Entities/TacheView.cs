using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools.Entities
{
    public class TacheView
    {
        private System.Guid _id;
        private string _nom;
        private string _description;
        private DateTime _dateCreation;
        private DateTime? _dateDeadLine;
        private UtilisateurView _createur;
        private PrioriteView _priorite;
        private string _statut;
        private EntrepriseView _entreprise;
        private TypeView _type;
        private List<UtilisateurView> _participants;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public DateTime DateCreation
        {
            get
            {
                return _dateCreation;
            }

            set
            {
                _dateCreation = value;
            }
        }

        public DateTime? DateDeadLine
        {
            get
            {
                return _dateDeadLine;
            }

            set
            {
                _dateDeadLine = value;
            }
        }

        public UtilisateurView Createur
        {
            get
            {
                return _createur;
            }

            set
            {
                _createur = value;
            }
        }

        public PrioriteView Priorite
        {
            get
            {
                return _priorite;
            }

            set
            {
                _priorite = value;
            }
        }

        public string Statut
        {
            get
            {
                return _statut;
            }

            set
            {
                _statut = value;
            }
        }

        public EntrepriseView Entreprise
        {
            get
            {
                return _entreprise;
            }

            set
            {
                _entreprise = value;
            }
        }

        public TypeView Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public Guid Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public List<UtilisateurView> Participants
        {
            get
            {
                return _participants;
            }

            set
            {
                _participants = value;
            }
        }
    }
}
