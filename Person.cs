namespace Web
{
    public class Person
    {
        public string First { get; set; } = "Dorin";
        public string Last { get; set; } = "Grigoras";

        public void Deconstruct(out string first, out string last)
        {
            first = First;
            last = Last;
        }
    }
}