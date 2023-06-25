namespace DZ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planet1Anon = new
            {
                name = "Венера",
                numberFromSun = 2,
                lengthEquator = 38025,
                beforePlanet = "Меркурий",
            };

            var planet2Anon = new
            {
                name = "Земля",
                numberFromSun = 3,
                lengthEquator = 40075,
                beforePlanet = planet1Anon,
            };

            var planet3Anon = new
            {
                name = "Марс",
                numberFromSun = 4,
                lengthEquator = 21343,
                beforePlanet = planet2Anon,
            };

            var planet4Anon = new
            {
                name = "Венера",
                numberFromSun = 2,
                lengthEquator = 38025,
                beforePlanet = "Меркурий",
            };



            Print(planet1Anon.name,planet1Anon.numberFromSun,planet1Anon.lengthEquator,planet1Anon.beforePlanet,planet1Anon, planet4Anon);
            Print(planet2Anon.name, planet2Anon.numberFromSun, planet2Anon.lengthEquator, planet2Anon.beforePlanet.name, planet2Anon, planet4Anon);
            Print(planet3Anon.name, planet3Anon.numberFromSun, planet3Anon.lengthEquator, planet3Anon.beforePlanet.name, planet3Anon, planet4Anon);
            Print(planet4Anon.name, planet4Anon.numberFromSun, planet4Anon.lengthEquator, planet4Anon.beforePlanet, planet4Anon, planet4Anon);


        }

        static void Print(string name, int number, int length, string before, object anon, object venera)
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Порядковый номер от Солнца: " + number);
            Console.WriteLine("Длина экватора: " + length);
            Console.WriteLine("Предыдущая планета " + before);
            Console.WriteLine("Эквивалентна ли она Венере = " + anon.Equals(venera));
            Console.WriteLine();
        }
    }
}