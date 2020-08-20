namespace Web
{
    public interface IFileCompression
    {
        void Compress(string targetFileName, string[] fileList);
        void Uncompress(string compressedFileName, string expanddirectoryName);
    }
}