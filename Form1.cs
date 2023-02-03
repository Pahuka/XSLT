using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XSLT
{
    public partial class XSLT : Form
    {
        XDocument xmlList;
        XDocument xmlGroup;
        XslCompiledTransform transformer;

        public XSLT()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transformer = new XslCompiledTransform();
            xsltProcess.Enabled = false;
            addElemCount.Enabled = false;
            openXSL.Enabled = false;
            resultPath.Enabled = false;
            inputFile.Enabled = false;
            resultFile.Enabled = false;
        }

        private void xsltProcess_Click_1(object sender, EventArgs e)
        {
            xmlGroup = new XDocument();

            if (Path.GetExtension(resultPath.Text) != ".xml")
            {
                MessageBox.Show($"{resultPath.Text}\nУкажите имя файла с расширением *.xml", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (var writer = xmlGroup.CreateWriter())
            {
                using (var reader = xmlList.CreateReader())
                {
                    transformer.Transform(reader, writer);
                }
            }

            AddXmlAttribute(xmlGroup, "group", "count");
            xmlGroup.Save(resultPath.Text);
            resultFile.Text = xmlGroup.ToString();
        }

        private void addElemCount_Click(object sender, EventArgs e)
        {
            AddXmlAttribute(xmlList, "list", "count");
            xmlList.Save(inputPath.Text);
            inputFile.Text = xmlList.ToString();
        }

        private void AddXmlAttribute(XDocument doc, string elementName, string attributeName)
        {
            var xmlElems = doc.Descendants(elementName);

            foreach (var item in xmlElems)
            {
                item.SetAttributeValue(attributeName, item.Elements("item").Count());
            }
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog("XML files(*.xml)|*.xml");
        }

        private void openXSL_Click(object sender, EventArgs e)
        {
            OpenFileDialog("XSL files(*.xsl)|*.xsl");
        }

        private void OpenFileDialog(string fileFilter)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = fileFilter;
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog(this);

            if (openFileDialog.FileName != string.Empty && fileFilter.Contains("XML"))
            {
                inputPath.Text = Path.GetFullPath(openFileDialog.FileName);
                resultPath.Text = Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), "Groups.xml");
                xmlList = XDocument.Load(openFileDialog.FileName);
                inputFile.Text = xmlList.ToString();
                openXSL.Enabled = true;
                resultPath.Enabled = true;
                inputFile.Enabled = true;
            }

            if (openFileDialog.FileName != string.Empty && fileFilter.Contains("XSL"))
            {
                transformer.Load(Path.GetFullPath(openFileDialog.FileName));
                xsltProcess.Enabled = true;
                addElemCount.Enabled = true;
                resultFile.Enabled = true;
            }
        }
    }
}