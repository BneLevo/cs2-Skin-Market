using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;

namespace cs2_skins_market
{
    public sealed class MongoDBconnect
    {

        public MongoDBconnect(){ }

        private static MongoClient _instance;
        private static readonly object _lock = new object();
         
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
