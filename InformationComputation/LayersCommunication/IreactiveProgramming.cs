﻿//__________________________________________________________________________________________
//
//  Copyright 2022 Mariusz Postol LODZ POLAND.
//
//  To be in touch join the community by pressing the `Watch` button and to get started 
//  comment using the discussion panel at
//  https://github.com/mpostol/TP/discussions/182
//  with an introduction of yourself and tell us about what you do with this community.
//__________________________________________________________________________________________

using TP.InformationComputation.LayersCommunication.Logic;

namespace TP.InformationComputation.LayersCommunication
{
  public interface IReactiveProgramming : IObservable<ITracingContext>
  {
    /// <summary>
    /// Method Alpha
    /// </summary>
    void Alpha();

    /// <summary>
    /// Method Bravo
    /// </summary>
    void Bravo();

    /// <summary>
    /// Method Charlie
    /// </summary>
    void Charlie();

    /// <summary>
    /// Method Delta
    /// </summary>
    void Delta();
  }
}