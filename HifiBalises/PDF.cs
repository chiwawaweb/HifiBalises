using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace HifiBalises
{
    public partial class PDF : Form
    {
        private string PDF_FileName, PDF_Directory;

        public PDF(string bal1, string bal2, string bal3, string bal4, 
            string bal5, string bal6, string bal7, string bal8, string bal9, 
            string bal10, string bal11, string bal12, string bal13, string bal14)
        {


            PDF_Directory = @"temp\";
            PDF_FileName = "balises" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".pdf";

            /* Création du répertoire temporaire */
            Directory.CreateDirectory(PDF_Directory);
            string path = @"temp\";
            string[] filenames = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly);
            foreach (string fName in filenames)
            {
                File.Delete(fName);
            }

            Document doc = new Document(PageSize.A4, 0, 0, 0, 15);
            try
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(PDF_Directory + PDF_FileName, FileMode.Create));
                writer.ViewerPreferences = PdfWriter.FitWindow;
                writer.PageEvent = new ITextEvents(bal1, bal2, bal3, bal4, bal5, bal6, bal7, bal8, bal9, bal10, bal11, bal12, bal13, bal14);

                /* entête du fichier */
                doc.AddTitle("Balises");
                doc.AddAuthor("Chiwawaweb.com");
                doc.Open();

                doc.Add(new Phrase("\n"));

                /* Clôture du document */
                doc.Close();
                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK);
            }

            InitializeComponent();

            /* Affichage du pdf */
            PdfBalises.LoadFile(PDF_Directory + PDF_FileName);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PdfBalises.printWithDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testPdf();
        }

        private void testPdf()
        {
            using (MemoryStream myMemoryStream = new MemoryStream())
            {
                Document myDocument = new Document();
                PdfWriter myPDFWriter = PdfWriter.GetInstance(myDocument, myMemoryStream);

                myDocument.Open();

                // Add to content to your PDF here... 
                PdfPTable table = new PdfPTable(2);
                PdfPCell header = new PdfPCell(new Phrase("Your Heading"));
                header.Colspan = 2;
                header.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                table.AddCell(header);
                table.AddCell("ID: xxx");
                myDocument.Add(table);
                myDocument.Close();

                byte[] content = myMemoryStream.ToArray();

                // Write out PDF from memory stream. 
                using (FileStream fs = File.Create("test.pdf"))
                {
                    fs.Write(content, 0, (int)content.Length);
                }

                

                Process.Start("test.pdf");
            }
        }
    }
}
