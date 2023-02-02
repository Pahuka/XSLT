using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace XSLT
{
    public partial class Form1 : Form
    {
        XDocument xmlList;
        XDocument xmlGroup;
        XslCompiledTransform transformer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlList = XDocument.Load("\\List.xml");
            textBox1.Text = xmlList.ToString();
            transformer = new XslCompiledTransform();
        }

        private void xsltProcess_Click_1(object sender, EventArgs e)
        {
            xmlGroup = new XDocument();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.CloseOutput = false;

            using (var writer = xmlGroup.CreateWriter())
            {
                using (var reader = xmlList.CreateReader())
                {
                    transformer.Load("\\list.xsl");
                    transformer.Transform(reader, writer);
                }
            }

            AddXmlAttribute(xmlGroup, "group", "count");

            xmlGroup.Save("\\temp.xml");

            textBox2.Text = xmlGroup.ToString();
        }        

        private void addElemCount_Click(object sender, EventArgs e)
        {
            AddXmlAttribute(xmlList, "list", "count");
            xmlList.Save("\\list.xml");
            textBox1.Text = xmlList.ToString();
        }

        private void AddXmlAttribute(XDocument doc, string elementName, string attributeName)
        {
            var xmlElems = doc.Descendants(elementName);

            foreach (var item in xmlElems)
            {
                item.SetAttributeValue(attributeName, item.Elements("item").Count());
            }
        }
    }
}
