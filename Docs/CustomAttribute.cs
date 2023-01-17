namespace DocumentAttribute.Docs;

[AttributeUsage(AttributeTargets.All)]
public class DescriptionAttribute : Attribute
{
    public string _Description { get; set; }

    public DescriptionAttribute(string Description)
    {
        _Description = Description;
    }
}