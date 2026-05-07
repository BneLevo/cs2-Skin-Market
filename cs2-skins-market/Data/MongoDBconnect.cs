/**************************************************************************
* Nom du fichier : MongoDBconnect.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Fournit un client MongoDB unique (Singleton).
**************************************************************************/

using MongoDB.Driver;

namespace cs2_skins_market.Data
{
    /// <summary>
    /// Singleton responsable de fournir une instance unique de MongoClient.
    /// </summary>
    public sealed class MongoDBconnect
    {

        /// <summary>
        /// Constructeur public (l'instance MongoClient est gérée en statique).
        /// </summary>
        public MongoDBconnect(){ }

        private static MongoClient _instance;
        private static readonly object _lock = new object();
         
        /// <summary>
        /// Retourne l'instance unique de MongoClient.
        /// </summary>
        public static MongoClient Instance()
        {
            if (_instance == null)
            {

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MongoClient("mongodb://localhost:27018");
                    }
                }

            }

            return _instance;
        }



    }
}
