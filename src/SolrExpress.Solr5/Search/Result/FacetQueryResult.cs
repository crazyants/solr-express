﻿using Newtonsoft.Json.Linq;
using SolrExpress.Core;
using SolrExpress.Core.Search;
using SolrExpress.Core.Search.Result;
using SolrExpress.Core.Utility;
using System.Collections.Generic;
using System.Linq;

namespace SolrExpress.Solr5.Search.Result
{
    /// <summary>
    /// Facet query data builder
    /// </summary>
    public sealed class FacetQueryResult<TDocument> : IFacetQueryResult<TDocument>, IConvertJsonObject
        where TDocument : IDocument
    {
        void IConvertJsonObject.Execute(IEnumerable<ISearchParameter> parameters, JObject jsonObject)
        {
            Checker.IsNull(parameters);

            if (jsonObject["facets"] == null)
            {
                throw new UnexpectedJsonFormatException(jsonObject.ToString());
            }

            var list = jsonObject["facets"]
                .Children()
                .Where(q =>
                    q is JProperty &&
                    q.Values().Count() == 1 && 
                    (((JProperty) q).Value as JObject)?["count"] != null)
                .ToList();

            if (list.Any())
            {
                this.Data = list.ToDictionary(
                    k => ((JProperty)k).Name,
                    v => ((JObject)((JProperty)v).Value)["count"].ToObject<long>());
            }
            else
            {
                this.Data = new Dictionary<string, long>();
            }
        }

        public IDictionary<string, long> Data { get; set; }

        public object Tag { get; set; }
    }
}
