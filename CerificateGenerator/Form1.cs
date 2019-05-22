using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CerificateGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTemplateUrl.Text = $"{Application.StartupPath}\\CertificateTemplate.pdf";
        }

        private void BtnBrowseTemplate_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtTemplateUrl.Text = openFileDialog1.FileName;
            }
        }

        private void BtnBrowseFont_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFintName.Text = fontDialog1.Font.FontFamily.Name;
                txtFontSize.Text = fontDialog1.Font.Size.ToString();
            }
        }

        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputFolderUrl.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BtnBroseExcelList_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtExcelListNamesUrl.Text = openFileDialog1.FileName;
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                try
                {
                    UpdateProgress(1, 0);

                    //Get Table format
                    MemoryStream ms = new MemoryStream();
                    using (FileStream file = new FileStream(txtExcelListNamesUrl.Text, FileMode.Open, FileAccess.Read))
                        file.CopyTo(ms);

                    var peopleList = HelperFunctions.GetDataTableFromExcel(ms, true);

                    if (peopleList != null && peopleList.Rows.Count > 0)
                    {
                        UpdateProgress(1, peopleList.Rows.Count);

                        for(int i = 0; i < peopleList.Rows.Count; i++)
                        {
                            UpdateProgress(i+1, peopleList.Rows.Count);

                            AddTextToPdfStamper(peopleList.Rows[i]);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        public void AddTextToPdfStamper(DataRow dataRow)
        {
            FontFactory.RegisterDirectory("C:\\WINDOWS\\Fonts");

            //variables
            string pathin = txtTemplateUrl.Text;
            string pathout = $"{txtOutputFolderUrl.Text}\\{dataRow[0].ToString()}.pdf";

            //create PdfReader object to read from the existing document
            using (PdfReader reader = new PdfReader(pathin))
            //create PdfStamper object to write to get the pages from reader 
            using (PdfStamper stamper = new PdfStamper(reader, new FileStream(pathout, FileMode.Create)))
            {
                //select two pages from the original document
                reader.SelectPages("1-2");

                //gettins the page size in order to substract from the iTextSharp coordinates
                var pageSize = reader.GetPageSize(1);

                // PdfContentByte from stamper to add content to the pages over the original content
                PdfContentByte pbover = stamper.GetOverContent(1);

                //add content to the page using ColumnText
                var fontName = FontFactory.GetFont(txtFintName.Text, float.Parse(txtFontSize.Text));
                fontName.Size = float.Parse(txtFontSize.Text);

                //setting up the X and Y coordinates of the document
                int x = int.Parse(txtXPosition.Text);
                int y = int.Parse(txtYPosition.Text);

                y = (int)(pageSize.Height - y);

                if (!string.IsNullOrEmpty(dataRow[0].ToString()))
                {
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_CENTER, new Phrase(dataRow[0].ToString(), fontName), x, y, 0);
                }

                var fontDate = FontFactory.GetFont(txtFintName.Text, float.Parse(txtFontSizeDate.Text));
                fontDate.Size = float.Parse(txtFontSizeDate.Text);

                //setting up the X and Y coordinates of the document
                x = int.Parse(txtDateXPostion.Text);
                y = int.Parse(txtDateYPosition.Text);

                y = (int)(pageSize.Height - y);

                if (!string.IsNullOrEmpty(dataRow[1].ToString()))
                {
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_CENTER, new Phrase(dataRow[1].ToString(), fontDate), x, y, 0);
                }

                var fontNumbers = FontFactory.GetFont(txtFintName.Text, float.Parse(txtFontSizeNumbers.Text));
                fontNumbers.Size = float.Parse(txtFontSizeNumbers.Text);

                //setting up the X and Y coordinates of the document
                x = int.Parse(txtXPositionSace.Text);
                y = int.Parse(txtYPositionSace.Text);

                y = (int)(pageSize.Height - y);

                if (!string.IsNullOrEmpty(dataRow[2].ToString()))
                {
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_LEFT, new Phrase("SACE No: " + dataRow[2].ToString(), fontNumbers), x, y, 0);
                }

                fontNumbers = FontFactory.GetFont(txtFintName.Text, float.Parse(txtFontSizeNumbers.Text));
                fontNumbers.Size = float.Parse(txtFontSizeNumbers.Text);

                //setting up the X and Y coordinates of the document
                x = int.Parse(txtXPosHPCSA.Text);
                y = int.Parse(txtYPosHPCSA.Text);

                y = (int)(pageSize.Height - y);

                if (!string.IsNullOrEmpty(dataRow[3].ToString()))
                {
                    ColumnText.ShowTextAligned(pbover, Element.ALIGN_LEFT, new Phrase("HPCSA No: " + dataRow[3].ToString(), fontNumbers), x, y, 0);
                }
            }
        }

        private void UpdateProgress(int value, int max)
        {
            this.BeginInvoke(new Action(() => {
                progressBar1.Minimum = 1;
                progressBar1.Value = value;
                progressBar1.Maximum = max;

                lblProgress.Text = $"{value}/{max}";
            }));
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtFontSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
