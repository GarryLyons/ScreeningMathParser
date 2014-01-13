using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL = MathParserBL;


namespace MathParseTester
{
    
        //    Rules:
        //a = '+', b = '-', c = '*', d = '/', e = '(', f = ')'

    
    [TestClass]
    public class MathParserUnitTest
    {
        [TestMethod]
        public void Calculate_3a2c4()
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate("3a2c4");
            Assert.IsTrue(ro.Answer== 20);
        }
        [TestMethod]
        public void Calculate_32a2d2()
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate("32a2d2");
            Assert.IsTrue(ro.Answer== 17);
        }


        [TestMethod]
        public void Calculate_500a10b66c32()
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate("500a10b66c32");
            Assert.IsTrue(ro.Answer == 14208);
        }


        [TestMethod]
        public void Calculate_3ae4c66fb32()
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate("3ae4c66fb32");
            Assert.IsTrue(ro.Answer == 235);
        }

        [TestMethod]
        public void Calculate_3c4d2aee2a4c41fc4f()
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate("3c4d2aee2a4c41fc4f");
            Assert.IsTrue(ro.Answer == 990);
        }

        [TestMethod]
        public void Calculate_InvalidCal()
        {
            BL.MathParser mp = new BL.MathParser();
            BL.MPReturnObject ro = mp.Calculate("3a2c4f");
            Assert.IsTrue(ro.IsValid == false);
        }
        

    }
}
