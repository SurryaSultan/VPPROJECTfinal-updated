using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
namespace CVREADER
{
    public partial class Form1 : Form
    {
        public List<string> filePaths  = new List<string>();
        private string targetPath;
        string lineText = null;
        string fileName;
        // string lineText;
        List<string> targetFiles = new List<string>();
        string personName, personGendor;
        string bs = "BS";
        string bsTwo = "Bachelor";
        string bsThree = "B a c h e l o r";
        string bsFour = "Bs";
        //
        string ms = "Ms", msOne = "MS", msTwo = "Masters", msThree = "M a s t e r s";
        //
        string mphil = "M. Phil", mphilOne = "M . p h i l ";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnOD_Click(object sender, EventArgs e)
        {

            ofdCVPath.ShowDialog();
            foreach (String file in ofdCVPath.FileNames)
            {
                // Create a PictureBox.
                try
                {
                    filePaths.Add(file);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("File not exists");
                }
                //fileName = ofdCVPath.FileNames.ToString();
                //tbCVPath.Text = ofdCVPath.FileName.ToString();
            }
        }
        public string readPDF(string fileName)
        {
            StringBuilder text = new StringBuilder();

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(@fileName);

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);
                }
                pdfReader.Close();
            }
            else
            {
                MessageBox.Show("No File Found :( ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return richTextBoxFileData.Text = text.ToString();
        }
        private void tbCVPath_TextChanged(object sender, EventArgs e)
        {
            readPDF(fileName);
           
        }
        private string getLineformRichTextBox(string search)
        {

            string find = search;
            lineText = null;
            int charNum = richTextBoxFileData.Find(find, RichTextBoxFinds.WholeWord);
            // lineText = null;
            if (charNum > -1)
            {
                lineText = richTextBoxFileData.Lines[richTextBoxFileData.GetLineFromCharIndex(charNum)];
            }
            return lineText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Filter obj = new Filter();
            if (targetPath!= null)
            {
                if (addCVIntoDir())
                {
                    MessageBox.Show("Operation Successfull", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Enter required Fields");
            }
            
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            targetPath = folderBrowserDialog1.SelectedPath + @"\";
        }

        public bool findBS()
        {
            if (cbBS.Checked)
            {
                string empty = null;
                string bs1 = getLineformRichTextBox(bsThree);
                string two = getLineformRichTextBox(bs);
                
                string four = getLineformRichTextBox(bsTwo);
                string five = getLineformRichTextBox(bsFour);
                if (bs1 != empty || two != empty || four != empty || five != empty)
                {
                    return true;
                }

            }
            return false;
        }
        public bool findMS()
        {
            if (cbMS.Checked)
            {
                string empty = null;
                string one = getLineformRichTextBox(ms);
                string two = getLineformRichTextBox(msOne);
                string three = getLineformRichTextBox(msTwo);
                string four = getLineformRichTextBox(msThree);
                
                if (one != empty || two != empty || three != empty || four != empty )
                {
                    return true;
                }

            }

            return false;
        }

        public bool findMPhil()
        {
            if (cbMphil.Checked)
            {
                string empty = null;
                string one = getLineformRichTextBox(mphil);
                string two = getLineformRichTextBox(mphilOne);
                

                if (one != empty || two != empty )
                {
                    return true;
                }

            }

            return false;
        }
        public bool findbyName()
        {
            if (cbName.Checked)
            {
                personName = tbName.Text;
                string empty = null;
                string one = getLineformRichTextBox(personName);
                if (one != empty)
                {
                    return true;
                }

            }

            return false;
        }

        private void cbName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbName.Checked)
            {
                tbName.Enabled = true;
            }
            
        }

        private void cbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGender.Checked)
            {
                rbFemale.Enabled = true;
                rbMale.Enabled = true;
            }
        }

        public bool findbyGender()
        {
            if (cbGender.Checked)
            {

                if (rbMale.Checked)
                {
                    personGendor = "Male";
                }
                else if (rbFemale.Checked)
                {
                    personGendor = "Female";
                }
                
                string empty = null;
                string one = getLineformRichTextBox(personGendor);
                if (one != empty)
                {
                    return true;
                }

            }

            return false;
        }

        //public bool findBS()
        //{
        //    if (cbBS.Checked)
        //    {
        //       // string data = new string( getLineformRichTextBox(bsThree).ToCharArray());
        //        if (getLineformRichTextBox(bsThree).Length > 0)
        //        {
        //            return true;
        //        }

        //    }

        //    return false;
        //}



        /// <summary>
        /// To check Dir if not exist then create Dir
        /// </summary>
        /// <returns></returns>
        private bool makeDir()
        {
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                return true;
            }
            else
            {
                if (System.IO.Directory.Exists(targetPath))
                {
                    return true;
                }
            }
            return false;
        }
        private void applyFilter()
        {
           
            foreach (var item in filePaths)
            {
                readPDF(item);
                if (cbMphil.Checked && cbMS.Checked && cbBS.Checked && cbName.Checked && cbGender.Checked)
                {
                    if (findBS() && findMS() && findMPhil() && findbyName() && findbyGender())
                    {
                        targetFiles.Add(item);
                    }
                }
                else if (cbMphil.Checked && cbMS.Checked && cbBS.Checked && cbName.Checked)
                {
                    if (findBS() && findMS() && findMPhil() && findbyName() )
                    {
                        targetFiles.Add(item);
                    }
                }
                else if (cbMphil.Checked && cbMS.Checked && cbBS.Checked)
                {
                    if (findBS() && findMS() && findMPhil())
                    {
                        targetFiles.Add(item);
                    }
                }
                else if (cbMS.Checked && cbBS.Checked)
                {
                    if (findBS() && findMS())
                    {
                        targetFiles.Add(item);
                    }
                }

                else if (cbMphil.Checked)
                {
                    if (findMPhil())
                    {
                        targetFiles.Add(item);
                    }
                }

                else if (cbMS.Checked)
                {
                    if (findMS())
                    {
                        targetFiles.Add(item);
                    }
                }

                else if (cbBS.Checked)
                {
                    if (findBS())
                    {
                        targetFiles.Add(item);
                    }
                }
                else if (cbName.Checked && cbGender.Checked)
                {
                    if (findbyName() && findbyGender())
                    {
                        targetFiles.Add(item);
                    }
                }
                else if (cbName.Checked)
                {
                    if (findbyName())
                    {
                        targetFiles.Add(item);
                    }
                }
                else if (cbGender.Checked)
                {
                    if (findbyGender())
                    {
                        targetFiles.Add(item);
                    }
                }



            }
            
        }
        bool addCv = false;
        public bool addCVIntoDir()
        {
            try
            {
                // findBS();
                makeDir();
                applyFilter();
                int i = 0;
                int max = targetFiles.Count ;
                prgrsBarOP.Maximum = max;
                prgrsBarOP.Minimum = 0;
                foreach (var item in targetFiles)
                {
                    File.Copy(item, targetPath + i + @".pdf", true);
                    addCv = true;
                    i++;
                    prgrsBarOP.Value = i;

                }
                targetFiles = null;
                return addCv;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Reading Files" + ex.ToString());
            }
            targetFiles = null;
            return addCv;
        }
    }
}
