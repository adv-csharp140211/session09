using System.Xml.Serialization;

namespace Serialization;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    /**
     * Serilazation / Deserialization
     * 
     *  Format
     *      plain text:
     *          XML - 
     *              <Product>
     *                  <Id>2</Id>
     *                  ..
     *              </Product>
     *          JSON - JavaScript Object Notaion
     *              {
     *                  "Id": 2,
     *                  ..
                    }
     *          YAML
     *          TOML
     *          
     *      binary:
     *          C#
     *          Protobuf
     *          Thrift
     */


    private Product product;
    private void Form1_Load(object sender, EventArgs e)
    {
        product = new Product { Id = 1, Name = "Product 1", Description = "Product Lhafan 1", Price = 1 };
    }

    private void buttonXMLSerialize_Click(object sender, EventArgs e)
    {
        var xmlSer = new XmlSerializer(typeof(Product));
        //File
        var stream = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "product.xml"));
        xmlSer.Serialize(stream, product);
        stream.Close();
        MessageBox.Show("Done");
    }

    private void buttonXMLDeserialize_Click(object sender, EventArgs e)
    {
        var xmlSer = new XmlSerializer(typeof(Product));
        var stream = new StreamReader(Path.Combine(AppContext.BaseDirectory, "product.xml"));
        var p =  xmlSer.Deserialize(stream) as Product;

        MessageBox.Show($"Done - {p.Name}");
    }
}
