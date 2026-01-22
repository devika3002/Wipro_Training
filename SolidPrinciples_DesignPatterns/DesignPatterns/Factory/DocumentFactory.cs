namespace DesignPatterns.Factory
{
    public class DocumentFactory
    {
        public static IDocument CreateDocument(string type)
        {
            if (type == "PDF")
                return new PdfDocument();
            else if (type == "WORD")
                return new WordDocument();
            else
                throw new ArgumentException("Invalid document type");
        }
    }
}
