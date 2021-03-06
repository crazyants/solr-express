﻿using SolrExpress.Core.Utility;

namespace SolrExpress.Core.Search.Parameter
{
    public abstract class BaseFacetQueryParameter<TDocument> : IFacetQueryParameter<TDocument>, IValidation
        where TDocument : IDocument
    {
        /// <summary>
        /// True to indicate multiple instances of the parameter, otherwise false
        /// </summary>
        public bool AllowMultipleInstances { get; } = true;

        /// <summary>
        /// Name of the alias added in the query
        /// </summary>
        public string AliasName { get; private set; }

        /// <summary>
        /// Query used to make the facet
        /// </summary>
        public ISearchParameterValue Query { get; private set; }

        /// <summary>
        /// Sort type of the result of the facet
        /// </summary>
        public FacetSortType? SortType { get; private set; }

        /// <summary>
        /// List of tags to exclude in facet calculation
        /// </summary>
        public string[] Excludes { get; private set; }
        
        /// <summary>
        /// Check for the parameter validation
        /// </summary>
        /// <param name="isValid">True if is valid, otherwise false</param>
        /// <param name="errorMessage">The error message, if applicable</param>
        public void Validate(out bool isValid, out string errorMessage)
        {
            isValid = true;
            errorMessage = string.Empty;

            var queryValidation = this.Query as IValidation;

            queryValidation?.Validate(out isValid, out errorMessage);
        }

        /// <summary>
        /// Configure current instance
        /// </summary>
        /// <param name="aliasName">Name of the alias added in the query</param>
        /// <param name="query">Query used to make the facet</param>
        /// <param name="sortType">Sort type of the result of the facet</param>
        /// <param name="excludes">List of tags to exclude in facet calculation</param>
        public IFacetQueryParameter<TDocument> Configure(string aliasName, ISearchParameterValue query, FacetSortType? sortType = null, params string[] excludes)
        {
            Checker.IsNullOrWhiteSpace(aliasName);
            Checker.IsNull(query);

            this.AliasName = aliasName;
            this.Query = query;
            this.SortType = sortType;
            this.Excludes = excludes;

            return this;
        }
    }
}
