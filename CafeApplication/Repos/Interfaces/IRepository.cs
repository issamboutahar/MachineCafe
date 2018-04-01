using System.Collections.Generic;

namespace CafeApplication.Repos.Interfaces
{
    /// <summary>
    /// Interface représentant l'implémentation d'un repository.
    /// </summary>
    /// <typeparam name="TEntite">Entité.</typeparam>
    /// <typeparam name="TCle">Clé unique de l'entité.</typeparam>
    public interface IRepository<TEntite, TCle>
    {
        #region Méthodes

        /// <summary>
        /// Obtenir tous les enregistrements de la table.
        /// </summary>
        /// <returns>Enumérable d'entités.</returns>
        IEnumerable<TEntite> Obtenir();


        /// <summary>
        /// Obtenir un enregistrement précis.
        /// </summary>
        /// <param name="cleUnique">Clé unique identifiant l'entité.</param>
        /// <returns>Entité unique.</returns>
        TEntite Obtenir(TCle cleUnique);


        void MettreAJour(TEntite entite);

        void Supprimer(TCle cleUnique);


        void Ajouter(TEntite entite);

     
        #endregion Méthodes
    }
}