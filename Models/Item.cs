namespace DotNetGuru.Models
{
    public record Item
    {
        public bool IsSorted { get; set; } = false;
        public int Value { get; set; }
        public string CssClass { get; set; } = "alert alert-dark";


    }

}