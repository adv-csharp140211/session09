using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Serialization;
[Serializable]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonIgnore]
    public string Description { get; set; }
    public int Price { get; set; }
}
