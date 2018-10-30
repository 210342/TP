﻿//____________________________________________________________________________
//
//  Copyright (C) Year of Copyright, Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community at GITTER: https://gitter.im/mpostol/TP
//____________________________________________________________________________

namespace TP.StructuralData.LINQ_to_object
{

  public interface ICDCatalog
  {
    string Country { get; set; }
    int Id { get; set; }
    decimal Price { get; set; }
    string Title { get; set; }
    ushort Year { get; set; }
  }

}