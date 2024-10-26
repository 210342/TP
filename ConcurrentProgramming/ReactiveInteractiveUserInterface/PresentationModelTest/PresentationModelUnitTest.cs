﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using TP.ConcurrentProgramming.PresentationModel;

namespace TP.ConcurrentProgramming.PresentationModelTest
{
  [TestClass]
  public class PresentationModelUnitTest
  {
    [TestMethod]
    public void ConstructorTest()
    {
      Model newInstance = new();
      IList<IDisposable>? BallsToDisposeList = null;
      newInstance.CheckIfBalls2DisposeIsAssigned(x => BallsToDisposeList = x);
      Assert.IsNotNull(BallsToDisposeList);
      int numberOfBalls = 0;
      newInstance.CheckIfBalls2DisposeIsAssigned(x => BallsToDisposeList = x);
      newInstance.CheckBalls2Dispose(x => numberOfBalls = x);
      Assert.AreEqual<int>(0, numberOfBalls);
      newInstance.Start(10);
      newInstance.CheckBalls2Dispose(x => numberOfBalls = x);
      Assert.AreEqual<int>(10, numberOfBalls);
      newInstance.Dispose();
      newInstance.CheckBalls2Dispose(x => numberOfBalls = x);
      Assert.AreEqual<int>(0, numberOfBalls);
    }
  }
}