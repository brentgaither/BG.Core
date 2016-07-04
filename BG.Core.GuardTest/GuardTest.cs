using NUnit.Framework;
using System;
using BG.Core;

namespace BG.Core.GuardTest
{

    [TestFixture]
    public class GuardTest
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullOrEmpty_WithEmptyString_ThrowsArgumentException()
        {
            var paramterTest = string.Empty;
           
               Guard.NotNullOrEmpty(paramterTest);

        }
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void NotNullOrEmpty_With_Null_ThrowsArgumentException()
        {
            string paramterTest = null;
            Guard.NotNullOrEmpty(paramterTest);
        }

        [Test]
        public void NotNullOrEmpty_WithValidString_Passes()
        {
            var paramterTest = "test";
            Guard.NotNullOrEmpty(paramterTest);
        }
        
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NotNull_WithNull_ThrowsArgumentNullException()
        {
            object testObject = null;
            Guard.NotNull(testObject);
        }

        [Test]
        public void NotNull_WithObject_Passes()
        {
            object testObject = new object();
            Guard.NotNull(testObject);
        }
    }
}
