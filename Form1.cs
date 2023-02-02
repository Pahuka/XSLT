using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace XSLT
{
    public partial class Form1 : Form
    {
        XDocument xmlList;
        XDocument xmlGroup;
        XslCompiledTransform transformer;
        //XmlTextWriter writer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlList = XDocument.Load("D:\\Temp\\test\\List.xml");
            
            transformer = new XslCompiledTransform();
            //writer = new XmlTextWriter("D:\\Temp\\test\\temp.xml", Encoding.UTF8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = xmlList.ToString();
            xmlGroup = new XDocument();
            //var itemsByGorup = xmlList
            //    .Descendants("item")
            //    .GroupBy(x => x.Attribute("group").Value);

            //var writer = xmlGroup.CreateWriter();
            //var reader = xmlList.CreateReader();

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.CloseOutput = false;

            using (var writer = xmlGroup.CreateWriter())
            {
                using (var reader = xmlList.CreateReader())
                {
                    transformer.Load("D:\\Temp\\test\\list.xsl");
                    transformer.Transform(reader, writer);
                }
            }            

            //foreach (var groupId in itemsByGorup)
            //{
            //    xmlGroup.Root.Add(new XElement("group", new XAttribute("name", groupId.Key)));

            //    foreach (var item in groupId)
            //    {
            //        var elem = xmlGroup.Root
            //            .Descendants("group")
            //            .Where(x => x.Attribute("name").Value == groupId.Key.ToString())
            //            .FirstOrDefault();

            //        elem.Add(new XElement(item.Name, new XAttribute("name", item.Attribute("name").Value)));
            //    }
            //}

            xmlGroup.Save("D:\\Temp\\test\\temp.xml");

            textBox2.Text = xmlGroup.ToString();
        }
    }
}
