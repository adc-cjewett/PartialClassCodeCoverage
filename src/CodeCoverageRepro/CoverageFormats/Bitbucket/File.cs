namespace CodeCoverageRepro.CoverageFormats.Bitbucket
{
    public class File
    {
        public string Path { get; }
        public string Coverage { get; }

        public File(string path, string coverage)
        {
            Path = path.Replace(@"\", @"/");
            Coverage = coverage;
        }
    }
}
