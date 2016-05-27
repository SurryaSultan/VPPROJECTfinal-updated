using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
namespace CVREADER
{
    public class Filter : Form1
    {
        Form1 formOne = new Form1();
        string lineText;
        List<string> targetFiles = new List<string>();
        string bs = "BS";
        string bsTwo = "Bachelor";
        string bsThree = "B a c h e l o r";
        string bsFour = "Bs";
        //
        string ms = "Ms", msOne = "MS", msTwo = "Masters", msThree = "M a s t e r s";
        //
        string mphil = "Mphil", mphilOne = "M p h i l ";
        /// <summary>
        /// To check cehckbox status
        /// </summary>
        /// <returns></returns>

        public Filter()
        {
            
        }
        public bool findBS()
        {
            if (cbBS.Checked == true)
            {
                if (getLineformRichTextBox(bs).Length > 0 ||getLineformRichTextBox(bsTwo).Length > 0 || getLineformRichTextBox(bsThree).Length > 0|| getLineformRichTextBox(bsFour).Length > 0)
                {
                    return true;
                }
                
            }

            return false;
        }
        /// <summary>
        /// To find a specific text from richTextBox
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        private string getLineformRichTextBox(string search)
        {

            string find = search;
            lineText = null;
            int charNum = richTextBoxFileData.Find(find);
            // lineText = null;
            if (charNum > -1)
            {
                lineText = richTextBoxFileData.Lines[richTextBoxFileData.GetLineFromCharIndex(charNum)];
            }
            return lineText;
        }

        /// <summary>
        /// To check Dir if not exist then create Dir
        /// </summary>
        /// <returns></returns>
        private bool makeDir()
        {
            if (!System.IO.Directory.Exists(@"D:\Target CV"))
            {
                System.IO.Directory.CreateDirectory(@"D:\Target CV");
                return true;
            }
            else
            {
                if (System.IO.Directory.Exists(@"D:\Target CV"))
                {
                    return true;
                }
            }
            return false;
        }
        private void applyFilter()
        {
            if (makeDir())
            {
                int lenght = filePaths.Count;
                foreach (var item in filePaths)
                {
                    readPDF(item);
                    if (findBS())
                    {
                        targetFiles.Add(item);
                    }
                   
                }
            }
        }
        bool addCv = false;
        public bool addCVIntoDir()
        {
            findBS();
            applyFilter();
            foreach (var item in targetFiles)
            {
                System.IO.File.Copy(item, @"D:\Target CV");
                addCv = true;

            
            }
            return addCv;
        }
    }
}
