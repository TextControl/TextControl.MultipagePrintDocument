using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tx_multipledocumentprint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // load a sample document
            textControl1.Load("Word2007RTFSpec9.docx",
                TXTextControl.StreamType.WordprocessingML);
        }

        private void OpenPrintPreview(MultipagePrintDocument.PagePerSheet pagesPerSheet)
        {
            // create a new instance of the MultipagePrintDocument
            MultipagePrintDocument mpPrintDocument = new MultipagePrintDocument(
                textControl1,
                pagesPerSheet,
                true);

            // use a PrintPreviewDialog to preview the created PrintDocument
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = mpPrintDocument;
            dlg.ShowDialog();
        }

        private void PrintMenuItem(object sender, EventArgs e)
        {
            // event handler to call different print layouts
            OpenPrintPreview((MultipagePrintDocument.PagePerSheet)Enum.Parse(
                typeof(MultipagePrintDocument.PagePerSheet),
                (string)((ToolStripMenuItem)sender).Tag));
        }
    }
}
