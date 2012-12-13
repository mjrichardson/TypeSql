﻿using System.Collections;
using Xunit;

namespace TypeSql.DbTests.Roslyn
{
    public class OneOutput : DapperTemplateViaRoslyn
    {
        public const string Name = @"CustomerFirstNameQuery";
        public const string Sql = @"SELECT FirstName:string FROM SalesLT.Customer";

        public OneOutput() : base(Name, Sql)
        {
            Session.Execute("var query = new CustomerFirstNameQuery(\"AdventureWorks\");") ;
            var results = Session.Execute("var results = query.Execute().ToList();");
        }



        [Fact]
        public void ReturnsCorrectCount()
        {
            Assert.Equal(847,
                Session.Execute<int>("results.Count();"));
        }

        //[Fact]
        //public void ResultTypeHasExpectedProperty()
        //{
        //}


    }
}