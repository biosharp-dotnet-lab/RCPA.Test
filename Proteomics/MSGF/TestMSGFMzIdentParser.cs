﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RCPA.Proteomics.MSGF
{
  [TestFixture]
  public class TestMSGFMzIdentParser
  {
    [Test]
    public void Test()
    {
      var parser = new MSGFMzIdentParser();
      var peptides = parser.ReadFromFile("../../../data/msgf.mzid");
      Assert.AreEqual(4, peptides.Count);
      Assert.AreEqual(-9.0, peptides[0].Score);
      Assert.AreEqual(19.0, peptides[0].SpScore);
      Assert.AreEqual(1.1130518E-6, peptides[0].ExpectValue);
      Assert.AreEqual(11.768287, peptides[0].Probability);
      Assert.AreEqual(1, peptides[0].IsotopeError);
      Assert.AreEqual(302.09814, peptides[0].MatchedTIC);
    }
  }
}