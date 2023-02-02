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
        string xslPath;

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
        }

        private void xsltProcess_Click_1(object sender, EventArgs e)
        {
            xmlGroup = new XDocument();

            using (var writer = xmlGroup.CreateWriter())
            {
                using (var reader = xmlList.CreateReader())
                {
                    transformer.Load(xslPath);
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
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files(*.xml)|*.xml";
            openFileDialog.ShowDialog(this);

            if (openFileDialog.FileName != string.Empty)
            {
                inputPath.Text = Path.GetFullPath(openFileDialog.FileName);
                resultPath.Text = Path.Combine(Path.GetDirectoryName(openFileDialog.FileName), "result.xml");
                xmlList = XDocument.Load(openFileDialog.FileName);
                inputFile.Text = xmlList.ToString();
                openXSL.Enabled = true;
            }
        }

        private void openXSL_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XSL files(*.xsl)|*.xsl";
            openFileDialog.ShowDialog(this);

            if (openFileDialog.FileName != string.Empty)
            {
                xslPath = Path.GetFullPath(openFileDialog.FileName);
                xsltProcess.Enabled = true;
                addElemCount.Enabled = true;
            }
        }
    }
}
