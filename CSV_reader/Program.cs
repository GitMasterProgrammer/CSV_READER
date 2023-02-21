namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\dev\szyperownia\21.02.2023\CSV_reader\csv\population.csv";
            CSVReader r = new CSVReader(filePath);
            City[]? cities =  r.ReadFirstNCities(2);
            foreach (var city in cities)
            {
                Console.WriteLine("Miasto: " + city.cityName + " Populacia: " + city.totalPopulation);
            }
        }
    }
}