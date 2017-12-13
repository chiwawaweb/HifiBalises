
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HifiBalises
{
    public class ITextEvents : PdfPageEventHelper
    {
        private float[] widthRepartition;
        private int fontSize=10, tabWidth=565;

        PdfContentByte cb;
        BaseFont fontHelvetN, fontHelvetB, fontCourierN, fontCourierB, fontCourierTitle = null;

        public ITextEvents(string bal1, string bal2, string bal3, string bal4,
            string bal5, string bal6, string bal7, string bal8, string bal9,
            string bal10, string bal11, string bal12, string bal13, string bal14)
        {
                
        }

        #region Fields 

        private string _header;

        #endregion

        #region Properties 

        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        #endregion

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            try
            {
                fontHelvetN = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                fontHelvetB = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                fontCourierN = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                fontCourierB = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                fontCourierTitle = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                cb = writer.DirectContent;
            }
            catch (DocumentException de) { }
            catch (System.IO.IOException ioe) { }
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            fontSize = 10;
            tabWidth = 565;
            widthRepartition = new float[] { 115, 230, 60, 80, 80 };

            string footerL1 = "HIFI INTERNATIONAL SA - Route de Luxembourg - B.P. 1 - L-3201 BETTEMBOURG";
            string footerL2 = "Tél.: (352) 40 24 24 - Fax: (352) 40 22 33 - www.hifi.lu - E-mail : info@hifi.lu";
            string footerL3 = "N° TVA LU 190 388 17 - RC Luxembourg B 13.377 - CELLLULL LU044 0141 4148 0170 0000 - BGLLLULL LU50 0030 5353 4541 1000";

            cb.SetColorStroke(new BaseColor(255, 0, 0));
            cb.MoveTo(20, document.PageSize.GetBottom(55));
            cb.LineTo(document.PageSize.Width - 20, document.PageSize.GetBottom(55));
            cb.Stroke();

            cb.SetFontAndSize(fontHelvetN, 8);

            cb.BeginText();
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, footerL1, 297, 40, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, footerL2, 297, 30, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, footerL3, 297, 20, 0);
            cb.EndText();


        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
        }
    }
}

