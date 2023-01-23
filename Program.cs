using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using Module2PracticeQuestion;
using static System.Environment;
using Newtonsoft.Json;
using System.Collections.Generic;

string? content;


using(StreamReader reader = new StreamReader("input.txt"))
{
    content = reader.ReadToEnd();
    Console.WriteLine(content);
}

Root xmlContent = JsonConvert.DeserializeObject<Root>(content);



var xs = new XmlSerializer(typeof(Root));

string path = Path.Combine(CurrentDirectory, "people.xml");
using (FileStream stream = File.Create(path))
{

    xs.Serialize(stream, xmlContent);

    
}
Console.WriteLine(File.ReadAllText(path));