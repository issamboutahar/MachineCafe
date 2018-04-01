
using CafeApplication.Models.Interfaces;
using CafeApplication.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApplication.Repos
{ 
    public class ConsomateurRepos : IConsommateurRepo
    {

        

        public ConsomateurRepos()
        {

            
        }
        public void Ajouter(IConsommateur entite)
        {
            throw new NotImplementedException();
        }

        public void MettreAJour(IConsommateur entite)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IConsommateur> Obtenir()
        {
            throw new NotImplementedException();
        }

        public IConsommateur Obtenir(int cleUnique)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int cleUnique)
        {
            throw new NotImplementedException();
        }
    }
}
