﻿//__________________________________________________________________________________________
//
//  Copyright 2022 Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and to get started
//  comment using the discussion panel at
//  https://github.com/mpostol/TP/discussions/182
//  with an introduction of yourself and tell us about what you do with this community.
//__________________________________________________________________________________________

using System.Data;
using TP.InformationComputation.PartialDefinitionsTest.Instrumentation;

namespace TP.InformationComputation.PartialDefinitions
{
  [TestClass]
  public class CatalogTest
  {
    [TestMethod]
    public void CatalogConstructorTest()
    {
      using (Catalog _newCatalog = new Catalog())
      {
        Assert.AreEqual<int>(0, _newCatalog.Person.Count);
        Assert.AreEqual<int>(0, _newCatalog.CDCatalogEntity.Count);
        Assert.AreEqual<int>(1, _newCatalog.Relations.Count);
        DataRelation _relation = _newCatalog.Relations["ArtistRelation"];
        Assert.IsNotNull(_relation);
        Assert.AreEqual<string>(_newCatalog.Person.TableName, _relation.ParentTable.TableName);
        Assert.AreEqual<string>(_newCatalog.CDCatalogEntity.TableName, _relation.ChildTable.TableName);
        _newCatalog.AddContent(TestDataGenerator.PrepareData());
        Assert.AreEqual<int>(3, _newCatalog.Person.Count);
        Assert.AreEqual<int>(15, _newCatalog.CDCatalogEntity.Count);
      }
    }

    [TestMethod]
    public void FilterPersonsByLastName_ForEachTest()
    {
      using (Catalog _newCatalog = new Catalog())
      {
        _newCatalog.AddContent(TestDataGenerator.PrepareData());
        IEnumerable<Catalog.PersonRow> _filtered = _newCatalog.Person.FilterPersonsByLastName_ForEach("Person");
        Type _returnedType = _filtered.GetType();
        Assert.AreEqual<string>("System.Collections.Generic.List`1", $"{_returnedType.Namespace}.{_returnedType.Name}");
        Assert.AreEqual<string>("System.Collections.Generic.List`1[TP.InformationComputation.PartialDefinitions.Catalog+PersonRow]", _filtered.ToString());
        Assert.AreEqual(2, _filtered.Count());
        foreach (Catalog.PersonRow p in _filtered)
          Assert.AreEqual("Person", p.LastName);
      }
    }

    [TestMethod]
    public void FilterPersonsByLastName_MethodSyntaxTest()
    {
      using (Catalog _newCatalog = new Catalog())
      {
        _newCatalog.AddContent(TestDataGenerator.PrepareData());
        IEnumerable<Catalog.PersonRow> _filtered = _newCatalog.Person.FilterPersonsByLastName_MethodSyntax("Person");
        Type _returnedType = _filtered.GetType();
        Assert.AreEqual<string>("System.Linq.WhereEnumerableIterator`1", $"{_returnedType.Namespace}.{_returnedType.Name}");
        Assert.AreEqual<string>("System.Linq.Enumerable+WhereEnumerableIterator`1[TP.InformationComputation.PartialDefinitions.Catalog+PersonRow]", _filtered.ToString());
        Assert.AreEqual(2, _filtered.Count());
        foreach (Catalog.PersonRow p in _filtered)
          Assert.AreEqual("Person", p.LastName);
      }
    }

    [TestMethod]
    public void FilterPersonsByLastName_QuerySyntaxTest()
    {
      using (Catalog _newCatalog = new Catalog())
      {
        _newCatalog.AddContent(TestDataGenerator.PrepareData());
        IEnumerable<Catalog.PersonRow> _filtered = _newCatalog.Person.FilterPersonsByLastName_QuerySyntax("Person");
        Type _returnedType = _filtered.GetType();
        Assert.AreEqual<string>("System.Linq.WhereEnumerableIterator`1", $"{_returnedType.Namespace}.{_returnedType.Name}");
        Assert.AreEqual<string>("System.Linq.Enumerable+WhereEnumerableIterator`1[TP.InformationComputation.PartialDefinitions.Catalog+PersonRow]", _filtered.ToString());
        Assert.AreEqual(2, _filtered.Count());
        foreach (Catalog.PersonRow p in _filtered)
          Assert.AreEqual("Person", p.LastName);
      }
    }
  }
}