using DocumentAttribute.Docs;

namespace DocumentAttribute;

internal class Program
{
    static void Main(string[] args)
    {
        MetaData meta= new MetaData();
        meta.GetDocs();
    }
}