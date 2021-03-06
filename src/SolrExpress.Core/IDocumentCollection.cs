﻿using SolrExpress.Core.DependencyInjection;
using SolrExpress.Core.Search;
using SolrExpress.Core.Update;

namespace SolrExpress.Core
{
    /// <summary>
    /// Signatures to SOLR document collection
    /// </summary>
    public interface IDocumentCollection<TDocument>
        where TDocument : IDocument
    {
        /// <summary>
        /// Solr queryable instance to provide create queries in SOLR
        /// </summary>
        ISolrSearch<TDocument> Select();

        /// <summary>
        /// Solr queryable instance to provide create queries in SOLR
        /// </summary>
        ISolrAtomicUpdate<TDocument> Update();

        /// <summary>
        /// SolrExpress options
        /// </summary>
        DocumentCollectionOptions<TDocument> Options { get; }

        /// <summary>
        /// Services container
        /// </summary>
        IEngine Engine { get; }
    }
}
