﻿using Newtonsoft.Json.Linq;

namespace SolrExpress.Query
{
    public class SolrQueryResult
    {
        private readonly JObject _jsonObject;

        /// <summary>
        /// Default constructor of the class
        /// </summary>
        /// <param name="jsonObject">Result of the SOLR</param>
        public SolrQueryResult(JObject jsonObject)
        {
            this._jsonObject = jsonObject;
        }

        /// <summary>
        /// Get a instance of the informed type with parsead json resulted from the search
        /// </summary>
        /// <typeparam name="T">Concrect class than implements the IResultBuilder interface</typeparam>
        /// <returns>Instance of T ready to be used</returns>
        public T Get<T>(T builder)
            where T : IResultBuilder
        {
            builder.Execute(this._jsonObject);

            return builder;
        }
    }
}
