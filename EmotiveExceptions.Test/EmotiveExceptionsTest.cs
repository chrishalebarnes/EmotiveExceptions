using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmotiveExceptions;

namespace EmotiveExceptions.Test
{
    [TestClass]
    public class EmotiveExceptionsTest
    {
        [TestMethod]
        [ExpectedException(typeof(ಠ_ಠ))]
        public void Throwsಠ_ಠException()
        {
            throw new ಠ_ಠ { };
        }

        [TestMethod]
        [ExpectedException(typeof(O_o))]
        public void ThrowsO_oException()
        {
            throw new O_o { };
        }

        [TestMethod]
        [ExpectedException(typeof(O﹏O))]
        public void ThrowsO﹏OException()
        {
            throw new O﹏O { };
        }

        [TestMethod]
        [ExpectedException(typeof(ಠ益ಠ))]
        public void Throwsಠ益ಠException()
        {
            throw new ಠ益ಠ { };
        }

        [TestMethod]
        [ExpectedException(typeof(ಠﭛಠ))]
        public void ThrowsಠﭛಠException()
        {
            throw new ಠﭛಠ { };
        }
    }
}
