using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Extensions.Configuration;


namespace AlgorithmLibrary
{
    /// <summary>
    /// Dependencies --> 1.)Merchant Accounts 2.)Delegate list or dictionary, 3.)IConfig
    /// </summary>    
    public class Algorithm1 : IAlgorithm// transient
    {
        private readonly IConfiguration _config;
        private IAlgorithm algorithm;
        //public Algorithm1(IConfiguration config, IDataAccess da) dependency --> da class calls the db. Needs to be injected here.
        //DataAccessLibrary should be accessed via intermediate class which does proper validation before executing the query on the database. 
        public Algorithm1(IConfiguration config)
        {
            this._config = config; //direct db access or API acess. Bad practice to put here probably.          
        }

        public IList<T> RunAlgorithm<T, U>(IList<T> list, Dictionary<string, U> dict)
        {
            List<T> merchantAccountPassRateList = new List<T>();
            return merchantAccountPassRateList;
        }
        /// <summary>
        /// Recieves all the merchant accounts on which checks will be run.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public IList<T> RunAlgorithm<T>(IList<T> list)
        {
            //todo
            // function will have access to a data access library model class. which will
            //take an sql parameter and return some dataset. 
            //This model class will actually call the db directly and not the algorithm class.
            List<T> list1 = new List<T>();
            return list1;
        }
    }


}
