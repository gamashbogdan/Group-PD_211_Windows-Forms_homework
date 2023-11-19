namespace Dz_na_23._11
{
    public class Cars
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Probig { get; set; }
        public int Value { get; set; }
        public Cars()
        {
            Model = "";
            Year = 0;
            Color = "";
            Probig = 0;
            Value = 0;
        }
        public Cars(string m, int y, string c, int p, int v)
        {
            Model = m;
            Year = y;
            Color = c;
            Probig = p;
            Value = v;
        }
        public override string ToString()
        {
            return $"Model - {Model}, Year - {Year} , Probig - {Probig}";
        }
    }
}
