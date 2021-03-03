using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CssModifier
{
    public partial class Form1 : Form
    {
        private string _fileContents, _path;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            var dr = openFileDialog.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void btnModifyColor_Click(object sender, EventArgs e)
        {
            var defaultBanner = "header{height:90px;background-color:#76BDD7;padding-top:14px}";
            var newBanner = "header{height:90px;background-color:#f37124;padding-top:14px}";

            var defaultButton =
                ".field-wrapper > fieldset > div > button{display:block;width:100%;height:50px;background-color:limegreen;border:transparent}";
            var newButton =
                ".field-wrapper > fieldset > div > button{display:block;width:100%;height:50px;background-color:lightBlue;border:transparent}";

            var defaultShade = ".progress-button .tz-bar{background-color:#4B8A08;height:3px;bottom:0;left:0;width:0;position:absolute;z-index:1;border-radius:0 0 2px 2px;-webkit-transition:width 0.5s,height 0.5s;-moz-transition:width 0.5s,height 0.5s;transition:width 0.5s,height 0.5s}";
            var newShade = ".progress-button .tz-bar{background-color:#FFF;height:3px;bottom:0;left:0;width:0;position:absolute;z-index:1;border-radius:0 0 2px 2px;-webkit-transition:width 0.5s,height 0.5s;-moz-transition:width 0.5s,height 0.5s;transition:width 0.5s,height 0.5s}";

            _fileContents = _fileContents.Replace(defaultShade, newShade);
            File.WriteAllText(_path, _fileContents);
            ReadFile();
        }

        #region HELPERS

        private void ReadFile()
        {
            _path = txtFilePath.Text.Trim();
            _fileContents = File.ReadAllText(@_path).Trim();

            _fileContents = StripWhitespace(_fileContents);
            rtbFileContent.Text = _fileContents;
        }

        /// <summary>
        /// Strips the whitespace from any .css file.
        /// </summary>
        private static string StripWhitespace(string value)
        {
            var content = new StringBuilder(value);
            content = content.Replace("  ", String.Empty);
            content = content.Replace(Environment.NewLine, String.Empty);
            content = content.Replace("\t", string.Empty);
            content = content.Replace(" {", "{");
            content = content.Replace(" :", ":");
            content = content.Replace(": ", ":");
            content = content.Replace(", ", ",");
            content = content.Replace("; ", ";");
            content = content.Replace(";}", "}");

            // sometimes found when retrieving CSS remotely
            content = content.Replace(@"?", string.Empty);

            //body = Regex.Replace(body, @"/\*[^\*]*\*+([^/\*]*\*+)*/", "$1");
            var cleanedValue = Regex.Replace(content.ToString(), @"(?<=[>])\s{2,}(?=[<])|(?<=[>])\s{2,}(?=&nbsp;)|(?<=&ndsp;)\s{2,}(?=[<])", String.Empty);

            //Remove comments from CSS
            cleanedValue = Regex.Replace(cleanedValue, @"/\*[\d\D]*?\*/", string.Empty);

            return cleanedValue;
        }

        #endregion

        private void txtBannerColor_MouseClick(object sender, MouseEventArgs e)
        {
            var dr = colorDialog.ShowDialog();
            if (!dr.Equals(DialogResult.OK)) return;

            txtBannerColor.Text = colorDialog.Color.ToString();
        }

    }
}
