
using CafeApplication.Data.Models;
using CafeApplication.Service.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeApplication.Service.Service
{
    public interface IService
    {
        
        IBreuvage ObtenirConsommation(int id);

        Consommateur ObtenirConsommateur(int id);

        IEnumerable<IBreuvage> ObtenirConsommationAll();

        IEnumerable<Consommateur> ObtenirConsommateurAll();

        IBreuvage ObtenirDerniereConsommationParClient(int idClient);

        void AjouterConsommation(IBreuvage cons, int test);

        void MettreAJourConsommateur(int ConsommateurID);

        


    }
}
