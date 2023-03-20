using File = CodeCoverageRepro.CoverageFormats.Bitbucket.File;

namespace CodeCoverageRepro.CoverageFormats.BitbucketFormat
{
    public partial class Bitbucket
    {
        public Bitbucket()
        { }

        public List<File> Files { get; set; } = new List<File>();
    }
}