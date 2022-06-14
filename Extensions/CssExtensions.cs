using DotNetGuru.Models;

namespace DotNetGuru;
public static class CssExtensions
{

    public static void UpdateClass(this Item[] items, int index, string className)
    {
        items[index].CssClass = className;
    }
}