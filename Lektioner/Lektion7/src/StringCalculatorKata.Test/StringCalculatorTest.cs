using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorKata.Test
{
    public class StringCalculatorTest
    {
        [Test]
        public void Add_EmptyStringAsParam_ReturnsZero()
        {
            
            NUnit.Framework.Assert.AreEqual(0, StringCalculator.Add(""));
        }
        
    }

    //public void Sum()
    //{
    //    throw new NotSupportedException();
    //}
}
