using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
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
        var p = xmlSer.Deserialize(stream) as Product;

        MessageBox.Show($"Done - {p.Name}");
    }

    private async void buttonJSONSer_Click(object sender, EventArgs e)
    {
        //JSON
        // NewtonSoft.JSON
        // Sytem.Text.Json ✔️

        var result = JsonSerializer.Serialize(product, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        await File.WriteAllTextAsync(Path.Combine(AppContext.BaseDirectory, "product.json"), result);
        MessageBox.Show($"Done");
    }

    private async void buttonJsonDes_Click(object sender, EventArgs e)
    {
        var json = await File.ReadAllTextAsync(Path.Combine(AppContext.BaseDirectory, "product.json"));
        var p = JsonSerializer.Deserialize<Product>(json);
        MessageBox.Show($"Done - {p.Name}");
    }

    private void buttonBinSer_Click(object sender, EventArgs e)
    {
        //var ser = new BinaryFormatter();
        //var stream = new FileStream(Path.Combine(AppContext.BaseDirectory, "product.bin"), FileMode.Create);
        //ser.Serialize(stream, product);
        //stream.Close();
    }
}
