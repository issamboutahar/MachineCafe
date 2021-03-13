using AutoMapper;
using CafeApplication.Data;
using CafeApplication.Data.Models;
using CafeApplication.Service.Enumeration;
using CafeApplication.Service.Factory;
using CafeApplication.Service.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CafeApplication.Service.Service
{
    public class Service : IService
    {
        private IRepository<Consommateur> _repoConsommateur;

        private IRepository<Consommation> _repoConsommation;

        private readonly IMapper _mapper;

        public Service(IRepository<Consommateur> repoConsommateur, IRepository<Consommation> repoConsommation, IMapper mapper)
        {
            _repoConsommateur = repoConsommateur;
            _repoConsommation = repoConsommation;
            _mapper = mapper;


        }
        public void AjouterConsommation(IBreuvage cons, int test)
        {
            IBreuvage breuvage = null;

            if (cons.TypeBoisson == (int)TypeBoisson.Cafe)
            {
                breuvage = BreuvageFactory.PreparerBreuvage(cons.TypeBoisson);

            }
            else if(cons.TypeBoisson == (int)TypeBoisson.Chocolat)
            {
                breuvage = BreuvageFactory.PreparerBreuvage(cons.TypeBoisson);

            }
            else if(cons.TypeBoisson == (int)TypeBoisson.LeThe)
            {

                breuvage = BreuvageFactory.PreparerBreuvage(cons.TypeBoisson);
            }

            var retour = _mapper.Map<Consommation>(RemplirObjet(breuvage, cons));
            retour.AddedDate = DateTime.Now;
            _repoConsommation.Insert(retour);
            var consom = _repoConsommateur.Get(cons.ConsommateurID);
            consom.DerniereSelection = cons.DerniereSelection;
            consom.ModifiedDate = DateTime.Now;
            _repoConsommateur.Update(consom);

        }

        public IBreuvage ObtenirConsommation(int id)
        {
            throw new NotImplementedException();
        }

        public Consommateur ObtenirConsommateur(int id)
        {

            return _repoConsommateur.Get(id);
        }

        public IEnumerable<Consommateur> ObtenirConsommateurAll()
        {

            return _repoConsommateur.GetAll();
        }

        public IEnumerable<IBreuvage> ObtenirConsommationAll()
        {
            return _mapper.Map<IEnumerable<IBreuvage>>(_repoConsommation.GetAll());
        }

        public IBreuvage ObtenirDerniereConsommationParClient(int idClient)
        {
            var consommations = _repoConsommation.GetAll();
            var consFiltrer = consommations.Where<Consommation>(c => c.ConsommateurID == idClient)
                .OrderByDescending(t => t.Id)
                .FirstOrDefault(); ;
            return _mapper.Map<IBreuvage>(consFiltrer);
        }

        public void MettreAJourConsommateur(int ConsommateurID)
        {
            

        }

        public IBreuvage RemplirObjet(IBreuvage breuFactory, IBreuvage source)
        {
            source.Nom = breuFactory.Nom;
            return source;
        }
    }
}
