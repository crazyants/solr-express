﻿using Xunit;
using SolrExpress.Core.Query.Result;

namespace SolrExpress.Core.Tests
{
    public class SimpleResolverTests
    {
        /// <summary>
        /// Where   Using a SimpleResolver instance with mapping between IDocumentResult<> and TestDocumentResult<>
        /// When    Invoking the method "GetInstance" using interface IDocumentResult<TestDocument>
        /// What    Returns TestDocumentResult<TestDocument> class
        /// </summary>
        [Fact]
        public void SimpleResolver001()
        {
            // Arrange
            var resolver = new SimpleResolver();
            resolver.Mappings.Add(typeof(IDocumentResult<>), typeof(TestDocumentResult<>));

            // Act
            var result = resolver.GetInstance<IDocumentResult<TestDocument>>();

            // Assert
            Assert.IsInstanceOfType(result, typeof(TestDocumentResult<TestDocument>));
        }

        /// <summary>
        /// Where   Using a SimpleResolver instance without mapping between IDocumentResult<> and TestDocumentResult<>
        /// When    Invoking the method "GetInstance" using interface IDocumentResult<TestDocument>
        /// What    Throw UnexpectedDependencyInjectionMappingException exception
        /// </summary>
        [Fact]
        [ExpectedException(typeof(UnexpectedDependencyInjectionMappingException))]
        public void SimpleResolver002()
        {
            // Arrange
            var resolver = new SimpleResolver();

            // Act / Assert
            var result = resolver.GetInstance<IDocumentResult<TestDocument>>();
        }
    }
}
