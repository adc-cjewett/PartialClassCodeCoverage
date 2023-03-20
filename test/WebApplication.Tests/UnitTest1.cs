using CodeCoverageRepro.CoverageFormats.BitbucketFormat;

namespace WebApplication.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bitbucket bitbucket1 = new Bitbucket(1);
            Bitbucket bitbucket2 = new Bitbucket(1, 2);
            Bitbucket bitbucket3 = new Bitbucket(1, 2, 3);
            Bitbucket bitbucket4 = new Bitbucket(1, 2, 3, 4);
        }
    }
}