using CafeApplication.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Service
{
    public interface IService
    {
        
        IConsommation ObtenirConsommation(int id);

        IConsommation ObtenirConsommationParClient(int idClient);

        void AjouterConsommationCafe(IConsommation cons);

        void AjouterConsommationChocolat(IConsommation cons);

        void AjouterConsommationTea(IConsommation cons);


    }
}
