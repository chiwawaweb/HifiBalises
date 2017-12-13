
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
        private int fontSize, tabWidth;
        private string balise1, balise2, balise3, balise4, balise5, balise6, balise7, balise8, balise9, balise10, balise11, balise12, balise13, balise14;

        PdfContentByte cb;
        BaseFont fontHelvetN, fontHelvetB, fontCourierN, fontCourierB, fontCourierTitle = null;

        public ITextEvents(string bal1, string bal2, string bal3, string bal4,
            string bal5, string bal6, string bal7, string bal8, string bal9,
            string bal10, string bal11, string bal12, string bal13, string bal14)
        {
            balise1 = bal1;
            balise2 = bal2;
            balise3 = bal3;
            balise4 = bal4;
            balise5 = bal5;
            balise6 = bal6;
            balise7 = bal7;
            balise8 = bal8;
            balise9 = bal9;
            balise10 = bal10;
            balise11 = bal11;
            balise12 = bal12;
            balise13 = bal13;
            balise14 = bal14;

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


                cb = writer.DirectContent;
            }
            catch (DocumentException de) { }
            catch (System.IO.IOException ioe) { }
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
           

            cb.SetFontAndSize(fontHelvetB, 20);

            int posXG = 130;
            int posXD = 450;
            int posY1 = 800;
            int posY2 = 700;
            int posY3 = 600;
            int posY4 = 500;
            int posY5 = 210;
            int posY6 = 130;
            int posY7 = 50;

            balise1 = balise2 = balise3 = balise4 = balise5 = balise6 = balise7 = balise8 = balise9 = balise10 =
                balise11 = balise12 = balise13 = balise14 = "XXXXXXXXXX";

            cb.BeginText();
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise1, posXG, posY1, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise2, posXD, posY1, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise3, posXG, posY2, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise4, posXD, posY2, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise5, posXG, posY3, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise6, posXD, posY3, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise7, posXG, posY4, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise8, posXD, posY4, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise9, posXG, posY5, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise10, posXD, posY5, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise11, posXG, posY6, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise12, posXD, posY6, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise13, posXG, posY7, 0);
            cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, balise14, posXD, posY7, 0);

            cb.EndText();


        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
        }
    }
}

