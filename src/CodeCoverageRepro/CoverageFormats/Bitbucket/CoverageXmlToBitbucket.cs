using File = CodeCoverageRepro.CoverageFormats.Bitbucket.File;

namespace CodeCoverageRepro.CoverageFormats.BitbucketFormat
{
    public partial class Bitbucket
    {
        public Bitbucket(int a, int b)
        {
            Console.WriteLine("Hello");
        }

        public List<File> MoreFiles { get; set; }
    }
}