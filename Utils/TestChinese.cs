using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace RCPA.Utils
{
  [TestFixture]
  public class TestChinese
  {
    [Test]
    [ExpectedException("System.ArgumentNullException")]
    public void TestGetSpellsException()
    {
      Chinese.GetSpells(null);
    }

    [Test]
    public void TestGetSpells()
    {
      Assert.AreEqual("", Chinese.GetSpells(""));
      Assert.AreEqual("ZHRMGHAG123ABC", Chinese.GetSpells("�л����񹲺�A��123ABC"));
      Assert.AreEqual("ZHRMGHG", Chinese.GetSpells("�л����񣨹��͹���"));
    }
  }
}
