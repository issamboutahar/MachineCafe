using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeApplication.Models.Interfaces;

namespace CafeApplication.Service
{
    public class Service : IService
    {
        public void AjouterConsommationCafe(IConsommation cons)
        {
            throw new NotImplementedException();
        }

        public void AjouterConsommationChocolat(IConsommation cons)
        {
            throw new NotImplementedException();
        }

        public void AjouterConsommationTea(IConsommation cons)
        {
            throw new NotImplementedException();
        }

        public IConsommation ObtenirConsommation(int id)
        {
            throw new NotImplementedException();
        }

        public IConsommation ObtenirConsommationParClient(int idClient)
        {
            throw new NotImplementedException();
        }
    }
}
