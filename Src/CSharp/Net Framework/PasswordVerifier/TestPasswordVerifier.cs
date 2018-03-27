using NUnit.Framework;

namespace TDD_Katas_project.PasswordVerifier
{
    [TestFixture]
    [Category("TestPasswordVerifierKata")]
    public class TestPasswordVerifier
    {
        #region Setup/TearDown

        #endregion

        #region TestMethods

        [TestCase("")]
        [TestCase(null)]
        [TestCase("1234567")]
        [Test]
        public void ShouldThrowExceptionIfPasswordDoesNotMeetTheRules(string password)
        {
            
        }
        
        #endregion

        #region Private Methods

        #endregion
    }
}
