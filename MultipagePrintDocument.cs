//------------------------------------------------------------------------------------------------------------
// module:          Sample MultipagePrintDocument
// file:			MultipagePrintDocument.cs
// description:	    This file contains the MultipagePrintDocument class that prints multiple pages per sheet
//
// copyright:       © Text Control GmbH
// version:         TextControl 22.0
// author:          B. Meyer
//------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tx_multipledocumentprint
{
    /*----------------------------------------------------------
    ** MultipagePrintDocument class
    **--------------------------------------------------------*/
    class MultipagePrintDocument : PrintDocument
    {
        /*------------------------------------------------------
	    ** Private data fields
	    **----------------------------------------------------*/
        private TXTextControl.TextControl m_textControl;
        private PagePerSheet m_pagesPerSheet;
        private bool m_drawPageBorders;
        private int m_toPage;
        private Size m_paperSize;
        private int m_currentPage;

        /*------------------------------------------------------
	    ** PagePerSheet enumeration
	    **----------------------------------------------------*/
        public enum PagePerSheet
        {
            OnePage = 1,
            TwoByOne = 2,
            TwoByTwo = 4,
            ThreeByTwo = 6,
            FourByTwo = 8,
            ThreeByThree = 9,
            FourByFour = 16,
            EightByFour = 32
        }

        /*------------------------------------------------------
	    ** Constructor
	    ** description:	Initializes the private data fields
	    **----------------------------------------------------*/
        public MultipagePrintDocument(TXTextControl.TextControl textControl,
            PagePerSheet pagesPerSheet,
            bool drawPageBorders)
        {
            if (textControl == null)
                throw new ArgumentNullException(
                    "An object of type TXTextControl.TextControl must be defined.");

            m_textControl = textControl;
            m_pagesPerSheet = pagesPerSheet;
            m_drawPageBorders = drawPageBorders;
        }

        /*------------------------------------------------------
	    ** OnPrintPage
	    ** description:	This method overrides the standard
        **              OnPrintPage method and implements the
        **              rendering of more pages on a single
        **              sheet
        **
	    ** parameters:	standard PrintPageEventArgs
	    **----------------------------------------------------*/
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            base.OnPrintPage(e);

            // set the internal unit to point to be compatible with Text Control's units
            e.Graphics.PageUnit = GraphicsUnit.Point;

            // retrieve the thumbnail rows and columns for selected number of pages
            ThumbnailGrid szThumbnailValuePair = GetThumbnailValuePair(m_pagesPerSheet);

            // set the thumbnail size (page size divided by number of cols / rows)
            SizeF szfThumbnailSize = new SizeF(
                HundredthsOfAnInchToPoint(m_paperSize.Width) / szThumbnailValuePair.Columns,
                HundredthsOfAnInchToPoint(m_paperSize.Height) / szThumbnailValuePair.Rows);

            // get the last thumbnail page that is printed on the current page
            int iLastPage = Math.Min(m_currentPage + (int)m_pagesPerSheet - 1, m_toPage);

            // iterate through the selected pages
            for (int iCurrentPage = m_currentPage; iCurrentPage <= iLastPage; iCurrentPage++) {
                // get the page from TextControl
                TXTextControl.Page txPage = m_textControl.GetPages()[iCurrentPage + 1];

                // get the current row and column
                int iCurrentColumn;
                int iCurrentRow = Math.DivRem(iCurrentPage - m_currentPage,
                    szThumbnailValuePair.Columns, out iCurrentColumn);

                PointF pfThumbnailLocation = new PointF(
                    iCurrentColumn * szfThumbnailSize.Width,
                    iCurrentRow * szfThumbnailSize.Height);

                // create the Metafile image from current page in TextControl
                // using the Pages collection
                Metafile mfPageImage = txPage.GetImage(TXTextControl.Page.PageContent.All);

                // calculate the scale factor
                float fScaleFactor =
                    (m_textControl.Sections[txPage.Section].Format.Landscape == true) ?
                    (szfThumbnailSize.Width / txPage.Bounds.Width) :
                    (szfThumbnailSize.Height / txPage.Bounds.Height);

                // draw the Text Control page onto the existing PrintDocument Graphics
                // at the calculated location and size
                e.Graphics.DrawImage(mfPageImage, new RectangleF(pfThumbnailLocation.X, 
                    pfThumbnailLocation.Y, 
                    txPage.Bounds.Width * fScaleFactor, 
                    txPage.Bounds.Height * fScaleFactor));
                
                // print page borders
                if (m_drawPageBorders)
                    e.Graphics.DrawRectangle(Pens.LightGray, 
                        pfThumbnailLocation.X, 
                        pfThumbnailLocation.Y, 
                        szfThumbnailSize.Width, 
                        szfThumbnailSize.Height);
            }

            // more pages?
            m_currentPage = m_currentPage + (int)m_pagesPerSheet;
            e.HasMorePages = (m_currentPage <= m_toPage);
        }

        /*------------------------------------------------------
	    ** HundredthsOfAnInchToPoint
	    ** description:	Helper function to convert 1/100 inch to
        **              points
        **
	    ** parameters:	float value to convert
	    **----------------------------------------------------*/
        private static float HundredthsOfAnInchToPoint(float value)
        {
            return (float)((value * 72) / 100);
        }

        /*------------------------------------------------------
	    ** GetThumbnailValuePair
	    ** description:	Returns a ThumbnailGrid value pair based
        **              on the enum value 'PagePerSheet'
        **
	    ** parameters:	enum PagePerSheet pagesPerSheet
	    **----------------------------------------------------*/
        private ThumbnailGrid GetThumbnailValuePair(PagePerSheet pagesPerSheet)
        {
            ThumbnailGrid szColRowSize;

            // return the number of rows and columns as a ThumbnailGrid value pair
            switch (pagesPerSheet)
            {
                case PagePerSheet.EightByFour: szColRowSize = new ThumbnailGrid(8, 4); break;
                case PagePerSheet.FourByFour: szColRowSize = new ThumbnailGrid(4, 4); break;
                case PagePerSheet.ThreeByThree: szColRowSize = new ThumbnailGrid(3, 3); break;
                case PagePerSheet.FourByTwo: szColRowSize = new ThumbnailGrid(4, 2); break;
                case PagePerSheet.ThreeByTwo: szColRowSize = new ThumbnailGrid(3, 2); break;
                case PagePerSheet.TwoByTwo: szColRowSize = new ThumbnailGrid(2, 2); break;
                case PagePerSheet.TwoByOne: szColRowSize = new ThumbnailGrid(2, 1); break;
                default: szColRowSize = new ThumbnailGrid(1, 1); break;
            }
            
            // if landscape, switch the values
            if (m_paperSize.Width < m_paperSize.Height)
                return new ThumbnailGrid(szColRowSize.Rows, szColRowSize.Columns);

            return szColRowSize;
        }

        /*------------------------------------------------------
	    ** ThumbnailGrid
	    ** description:	Helper struct to store column and row
        **              values
	    **----------------------------------------------------*/
        private struct ThumbnailGrid
        {
            public int Columns, Rows;

            public ThumbnailGrid(int rows, int columns)
            {
                Columns = columns;
                Rows = rows;
            }
        }

        /*------------------------------------------------------
	    ** OnBeginPrint
	    ** description:	This method overrides the standard
        **              OnBeginPrint method and sets the from
        **              and to page values
        **
	    ** parameters:	standard PrintEventArgs
	    **----------------------------------------------------*/
        protected override void OnBeginPrint(PrintEventArgs e)
        {
            base.OnBeginPrint(e);

            // if PrinterSettings have been specified, check the print ranges
            switch (PrinterSettings.PrintRange)
            {
                case PrintRange.AllPages:
                    m_currentPage = 0;
                    m_toPage = m_textControl.Pages - 1;
                    break;
                case PrintRange.SomePages:
                    m_currentPage = PrinterSettings.FromPage - 1;
                    m_toPage = PrinterSettings.ToPage - 1;
                    break;
                default:
                    throw new InvalidOperationException("This print range is not valid.");
            }

            m_paperSize = (PrinterSettings.DefaultPageSettings.Landscape) ?
                new Size(
                    PrinterSettings.DefaultPageSettings.PaperSize.Height,
                    PrinterSettings.DefaultPageSettings.PaperSize.Width) :
                new Size(
                    PrinterSettings.DefaultPageSettings.PaperSize.Width,
                    PrinterSettings.DefaultPageSettings.PaperSize.Height);
        }
    }
}
