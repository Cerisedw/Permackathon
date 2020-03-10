using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pangathon.Api.Tools.Entities
{
    public class UtilisateurView 
    {

        private string _nom;
        private string _prenom;
        private string _email;
        private string _img;
        private string _telephone;
        private EntrepriseView _entreprise;
        private string _poste;

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

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Img
        {
            get
            {
                return _img;
            }

            set
            {
                _img = value;
            }
        }

        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
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

        public string Poste
        {
            get
            {
                return _poste;
            }

            set
            {
                _poste = value;
            }
        }
    }
}
