﻿using Xunit;
using SolrExpress.Core.Extension.Internal;
using System;

namespace SolrExpress.Core.Tests.Extension.Internal
{
    public class ExpressionIDocumentExtensionTests
    {
        private class Document : IDocument
        {
            public string PropertyString { get; set; }

            public int PropertyInt { get; set; }

            public long PropertyLong { get; set; }

            public DateTime PropertyDateTime { get; set; }

            public DateTimeOffset PropertyDateTimeOffset { get; set; }

            public bool PropertyBool { get; set; }

            public int? PropertyIntNullable { get; set; }

            public long? PropertyLongNullable { get; set; }

            public DateTime? PropertyDateTimeNullable { get; set; }

            public DateTimeOffset? PropertyDateTimeOffsetNullable { get; set; }

            public bool? PropertyBoolNullable { get; set; }

            [SolrField("PropString")]
            public string PropertyStringWithAttr { get; set; }

            [SolrField("PropInt")]
            public int PropertyIntWithAttr { get; set; }

            [SolrField("PropLong")]
            public long PropertyLongWithAttr { get; set; }

            [SolrField("PropDateTime")]
            public DateTime PropertyDateTimeWithAttr { get; set; }

            [SolrField("PropDateTimeOffset")]
            public DateTimeOffset PropertyDateTimeOffsetWithAttr { get; set; }

            [SolrField("PropBool")]
            public bool PropertyBoolWithAttr { get; set; }
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a string property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension001()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyString);

            // Assert
            Assert.AreEqual("PropertyString", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a int property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension002()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyInt);

            // Assert
            Assert.AreEqual("PropertyInt", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a long property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension003()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyLong);

            // Assert
            Assert.AreEqual("PropertyLong", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a DateTime property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension004()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyDateTime);

            // Assert
            Assert.AreEqual("PropertyDateTime", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a DateTimeOffset property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension005()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyDateTimeOffset);

            // Assert
            Assert.AreEqual("PropertyDateTimeOffset", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a bool property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension006()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyBool);

            // Assert
            Assert.AreEqual("PropertyBool", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a nullable int property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension007()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyIntNullable);

            // Assert
            Assert.AreEqual("PropertyIntNullable", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a nullable long property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension008()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyLongNullable);

            // Assert
            Assert.AreEqual("PropertyLongNullable", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a nullable DateTime property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension009()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyDateTimeNullable);

            // Assert
            Assert.AreEqual("PropertyDateTimeNullable", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a nullable DateTimeOffset property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension010()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyDateTimeOffsetNullable);

            // Assert
            Assert.AreEqual("PropertyDateTimeOffsetNullable", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a nullable bool property
        /// What    Return the name of the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension011()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyBoolNullable);

            // Assert
            Assert.AreEqual("PropertyBoolNullable", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a string property with SolrFieldAttribute
        /// What    Return the name of the SolrFieldAttribute associeted with the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension012()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyStringWithAttr);

            // Assert
            Assert.AreEqual("PropString", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a int property with SolrFieldAttribute
        /// What    Return the name of the SolrFieldAttribute associeted with the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension013()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyIntWithAttr);

            // Assert
            Assert.AreEqual("PropInt", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a long property with SolrFieldAttribute
        /// What    Return the name of the SolrFieldAttribute associeted with the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension014()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyLongWithAttr);

            // Assert
            Assert.AreEqual("PropLong", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a DateTime property with SolrFieldAttribute
        /// What    Return the name of the SolrFieldAttribute associeted with the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension015()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyDateTimeWithAttr);

            // Assert
            Assert.AreEqual("PropDateTime", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a DateTimeOffset property with SolrFieldAttribute
        /// What    Return the name of the SolrFieldAttribute associeted with the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension016()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyDateTimeOffsetWithAttr);

            // Assert
            Assert.AreEqual("PropDateTimeOffset", name);
        }

        /// <summary>
        /// Where   Using ExpressionIDocumentExtension class
        /// When    Invoking the method "GetPropertyNameFromExpression" using a lambda with a bool property with SolrFieldAttribute
        /// What    Return the name of the SolrFieldAttribute associeted with the property
        /// </summary>
        [Fact]
        public void ExpressionIDocumentExtension017()
        {
            // Arrange
            string name;

            // Act
            name = ExpressionIDocumentExtension.GetFieldNameFromExpression<Document>(q => q.PropertyBoolWithAttr);

            // Assert
            Assert.AreEqual("PropBool", name);
        }
    }
}
