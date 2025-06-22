using System;

namespace FactoryMethodPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentFactory wordFactory = new WordDocumentFactory();
            IDocument wordDoc = wordFactory.CreateDocument();
            wordDoc.Open();

            DocumentFactory pdfFactory = new PdfDocumentFactory();
            IDocument pdfDoc = pdfFactory.CreateDocument();
            pdfDoc.Open();

            DocumentFactory excelFactory = new ExcelDocumentFactory();
            IDocument excelDoc = excelFactory.CreateDocument();
            excelDoc.Open();

            Console.ReadLine();
        }
    }
}
