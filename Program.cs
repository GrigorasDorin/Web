using System;

namespace Web
{
    class Program
    {
        class ZipExtension : IFileCompression, IComparable
        {
            int IComparable.CompareTo(object obj)
            {
                throw new NotImplementedException();
            }

            public void Compress(string targetFileName, string[] fileList) { }
            public void Uncompress(string compressedFileName, string expanddirectoryName) { }
        }

        static void Main(string[] args)
        {
            ZipExtension ext = new ZipExtension();
            ext.Compress("", new string[] { "", "" });

            // Cast the ZipExtension object otherwise a compile error pops-up
            ((IComparable)ext).CompareTo(new ZipExtension());
        }
    }
}
