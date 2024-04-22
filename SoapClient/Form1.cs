using SoapClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoapClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            CalculatorSoapClient soapClient = new CalculatorSoapClient();
            var result = await soapClient.AddAsync(Convert.ToInt32(textBoxA.Text), Convert.ToInt32(textBoxB.Text));
            MessageBox.Show($"result is {result}");
        }
    }
}
