﻿using Newtonsoft.Json.Linq;
using SolrExpress.Core.Search;
using SolrExpress.Core.Search.Result;
using SolrExpress.Solr5.Search.Result;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SolrExpress.Solr5.UnitTests.Search.Result
{
    public class DocumentResultTests
    {
        /// <summary>
        /// Where   Using a DocumentResult instance
        /// When    Invoking the method "Execute" using a valid JSON
        /// What    Parse to informed concret classes
        /// </summary>
        [Fact]
        public void DocumentResult001()
        {
            // Arrange
            var jsonStr = @"
            {
              ""response"":{""numFound"":7722,""start"":0,""maxScore"":1.0,""docs"":[
                  {
                    ""_id_"":""ITEM01"",
                    ""_score_"":1.5}]
              }
            }";
            var parameters = new List<ISearchParameter>();
            var jsonObject = JObject.Parse(jsonStr);
            var result = (IConvertJsonObject)new DocumentResult<TestDocument>();
            List<TestDocument> lst;

            // Act
            result.Execute(parameters, jsonObject);

            // Assert
            lst = ((IDocumentResult<TestDocument>)result).Data.ToList();
            Assert.Equal(1, lst.Count);
            Assert.Equal("ITEM01", lst[0].Id);
            Assert.Equal(1.5M, lst[0].Score);
        }

        /// <summary>
        /// Where   Using a DocumentResult instance
        /// When    Invoking the method "Execute" using a invvalid JSON
        /// What    Throws UnexpectedJsonFormatException
        /// </summary>
        [Fact]
        public void DocumentResult002()
        {
            // Arrange
            var jsonStr = @"
            {
              ""responseX"":{""numFound"":7722,""start"":0,""maxScore"":1.0,""docs"":[
                  {
                    ""_id_"":""ITEM01"",
                    ""_score_"":1.5}]
              }
            }";
            var parameters = new List<ISearchParameter>();
            var jsonObject = JObject.Parse(jsonStr);
            var result = (IConvertJsonObject)new DocumentResult<TestDocument>();

            // Act / Assert
            Assert.Throws<UnexpectedJsonFormatException>(() => result.Execute(parameters, jsonObject));
        }

        /// <summary>
        /// Where   Using a DocumentResult instance
        /// When    Invoking the method "Execute" using a valid JSON with a geo coordinate value
        /// What    Parse to informed concret classes
        /// </summary>
        [Fact]
        public void DocumentResult003()
        {
            // Arrange
            var jsonStr = @"
            {
              ""response"":{""numFound"":7722,""start"":0,""maxScore"":1.0,""docs"":[
                  {
                    ""_spatial_"":""-1.5,2.5""}]
              }
            }";
            var parameters = new List<ISearchParameter>();
            var jsonObject = JObject.Parse(jsonStr);
            var result = (IConvertJsonObject)new DocumentResult<TestDocument>();
            List<TestDocument> lst;

            // Act
            result.Execute(parameters, jsonObject);

            // Assert
            lst = ((IDocumentResult<TestDocument>)result).Data.ToList();
            Assert.Equal(1, lst.Count);
            Assert.Equal(-1.5M, lst[0].Spatial.Latitude);
            Assert.Equal(2.5M, lst[0].Spatial.Longitude);
        }

        /// <summary>
        /// Where   Using a DocumentResult instance
        /// When    Invoking the method "Execute" using a valid JSON and a concrect class using SolrFieldAttribute
        /// What    Parse to informed concret classes
        /// </summary>
        [Fact]
        public void DocumentResult004()
        {
            // Arrange
            var jsonStr = @"
            {
              ""response"":{""numFound"":7722,""start"":0,""maxScore"":1.0,""docs"":[
                  {
                    ""_dummy_"":""Dummy""}]
              }
            }";
            var parameters = new List<ISearchParameter>();
            var jsonObject = JObject.Parse(jsonStr);
            var result = (IConvertJsonObject)new DocumentResult<TestDocument>();
            List<TestDocument> lst;

            // Act
            result.Execute(parameters, jsonObject);

            // Assert
            lst = ((IDocumentResult<TestDocument>)result).Data.ToList();
            Assert.Equal(1, lst.Count);
            Assert.Equal("Dummy", lst[0].Dummy);
        }
    }
}
