using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsCelsius
{
    public partial class Form1 : Form
    {
        private static TemperatureConverter.Class1 tempConv = new TemperatureConverter.Class1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add( tempConv.CtoF(double.Parse(textBox1.Text)));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tempConv.FtoC(double.Parse(textBox1.Text)));
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XElement element = new XElement("temperatures");
            foreach (var item in listBox1.Items)
            {
                element.Add(new XElement("temperature", item));
            }
            XDocument document = new XDocument();
            document.Add(element);
            document.Save("items.xml", SaveOptions.DisableFormatting);
        }
    }
}
