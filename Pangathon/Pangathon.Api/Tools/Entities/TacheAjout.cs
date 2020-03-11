using Pangathon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools.Entities
{
    public class TacheAjout
    {

        private string _nom;
        private string _description;
        private DateTime? _dateDeadLine;
        private Utilisateur _createur;
        private string _priorite;
        private string _entreprise;
        private string _type;

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

     

        public string Priorite
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

        public string Entreprise
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

        public string Type
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

        public Utilisateur Createur
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
    }
}
