using BilbasenNew;

namespace BilbasenKonsol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<object> list = new List<object>
            {
                new ElectricCar("Ford", "Mustang", 1963, "Red", 430, 5),
                new GasolineCar("Ford", "Mustang", 1963, "Red", 430, 10),
            };

            foreach (object obj in list)
            {
                if (obj is ElectricCar) // https://stackoverflow.com/questions/2763501/can-i-use-foreach-to-return-only-a-certain-type-from-a-collection
                {
                    ElectricCar electricCar = (ElectricCar) obj;
                    Console.WriteLine(electricCar.Brand);
                }
                else if (obj is GasolineCar)
                {
                    GasolineCar gasolineCar = (GasolineCar) obj;
                    Console.WriteLine(gasolineCar.Brand);
                }
            }



            Car[] cars = { // https://stackoverflow.com/questions/58517157/how-to-loop-array-of-objects-using-foreach
                new ElectricCar("Ford", "Mustang", 1963, "Red", 430, 5), // Benzin
                /*new Car("Toyota", "Camry", 2020, "Blue", 200), // Benzin
                new Car("Chevrolet", "Corvette", 2022, "Silver", 650), // Benzin
                new Car("Honda", "Civic", 2005, "Black", 150), // Benzin
                new Car("BMW", "3 Series", 2018, "White", 320), // Benzin
                new Car("Volkswagen", "Golf", 2019, "Gray", 170), // Benzin
                new Car("Audi", "A4", 2021, "Black", 248), // Benzin
                new Car("Mercedes-Benz", "E-Class", 2017, "Silver", 320), // Benzin
                new Car("Tesla", "Model S", 2023, "Blue", 750), // Electric
                new Car("Subaru", "Outback", 2015, "Green", 175), // Benzin
                new Car("Lexus", "RX 350", 2019, "White", 295), // Benzin
                new Car("Porsche", "911", 2021, "Red", 443), // Benzin
                new Car("Mazda", "MX-5", 2016, "Yellow", 181), // Benzin
                new Car("Jeep", "Wrangler", 2018, "Black", 285), // Benzin
                new Car("Hyundai", "Elantra", 2017, "Silver", 147), // Benzin
                new Car("Kia", "Sorento", 2020, "Blue", 185), // Benzin
                new Car("Ford", "Escape", 2019, "Gray", 168), // Benzin
                new Car("Toyota", "RAV4", 2021, "White", 203), // Benzin
                new Car("Chevrolet", "Silverado", 2015, "Black", 355), // Benzin
                new Car("Honda", "Accord", 2016, "Red", 185), // Benzin
                new Car("BMW", "5 Series", 2020, "Silver", 335), // Benzin
                new Car("Volvo", "XC90", 2018, "Blue", 316), // Benzin
                new Car("Audi", "Q5", 2019, "White", 248), // Benzin
                new Car("Mercedes-Benz", "GLC 300", 2021, "Black", 255), // Benzin
                new Car("Tesla", "Model 3", 2022, "Red", 318), // Electric
                new Car("Subaru", "Forester", 2017, "Green", 170), // Benzin
                new Car("Lexus", "ES 350", 2020, "Silver", 302), // Benzin
                new Car("Porsche", "Cayenne", 2019, "Blue", 340), // Benzin
                new Car("Mazda", "CX-5", 2017, "Gray", 187), // Benzin
                new Car("Jeep", "Grand Cherokee", 2016, "Black", 295), // Benzin
                new Car("Hyundai", "Tucson", 2020, "White", 161), // Benzin
                new Car("Kia", "Sportage", 2018, "Silver", 181), // Benzin
                new Car("Ford", "Explorer", 2022, "Red", 300), // Benzin
                new Car("Toyota", "Tacoma", 2015, "Black", 278), // Benzin
                new Car("Chevrolet", "Tahoe", 2019, "White", 355), // Benzin
                new Car("Honda", "Pilot", 2018, "Blue", 280), // Benzin
                new Car("BMW", "X5", 2020, "Silver", 335), // Benzin
                new Car("Volvo", "S60", 2017, "Black", 316), // Benzin
                new Car("Audi", "A6", 2018, "Gray", 335), // Benzin
                new Car("Mercedes-Benz", "CLA 250", 2019, "White", 221), // Benzin
                new Car("Tesla", "Model X", 2021, "Blue", 670), // Electric
                new Car("Subaru", "Impreza", 2016, "Blue", 152), // Benzin
                new Car("Lexus", "IS 300", 2018, "Black", 260), // Benzin
                new Car("Porsche", "Macan", 2020, "Silver", 348), // Benzin
                new Car("Mazda", "3", 2017, "Red", 155), // Benzin
                new Car("Jeep", "Renegade", 2019, "White", 180), // Benzin
                new Car("Hyundai", "Sonata", 2022, "Blue", 191), // Benzin
                new Car("Kia", "Optima", 2016, "Black", 185), // Benzin
                new Car("Ford", "F-150", 2018, "Silver", 395), // Benzin
                new Car("Toyota", "Highlander", 2017, "Gray", 295), // Benzin
                new Car("Chevrolet", "Equinox", 2020, "White", 170), // Benzin
                new Car("Honda", "HR-V", 2019, "Red", 141), // Benzin
                new Car("BMW", "7 Series", 2021, "Black", 600), // Benzin
                new Car("Volvo", "XC60", 2019, "Blue", 316), // Benzin
                new Car("Audi", "Q7", 2020, "Silver", 335), // Benzin
                new Car("Mercedes-Benz", "C300", 2016, "White", 241), // Benzin
                new Car("Tesla", "Model Y", 2022, "Blue", 670), // Electric
                new Car("Subaru", "Legacy", 2015, "Black", 175), // Benzin
                new Car("Lexus", "NX 300", 2018, "Silver", 235), // Benzin
                new Car("Porsche", "Panamera", 2019, "Red", 400), // Benzin
                new Car("Mazda", "6", 2017, "Gray", 187), // Benzin
                new Car("Jeep", "Compass", 2018, "White", 180), // Benzin
                new Car("Hyundai", "Santa Fe", 2021, "Blue", 235), // Benzin
                new Car("Kia", "Forte", 2016, "Black", 147), // Benzin
                new Car("Ford", "Ranger", 2019, "Silver", 270), // Benzin
                new Car("Toyota", "Sienna", 2017, "Gray", 296), // Benzin
                new Car("Chevrolet", "Colorado", 2020, "White", 200), // Benzin
                new Car("Honda", "Fit", 2018, "Red", 130), // Benzin
                new Car("BMW", "X3", 2022, "Black", 248), // Benzin
                new Car("Volvo", "V90", 2020, "Silver", 316), // Benzin
                new Car("Audi", "A8", 2019, "White", 460), // Benzin
                new Car("Mercedes-Benz", "GLE 450", 2021, "Blue", 362), // Benzin
                new Car("Tesla", "Cybertruck", 2023, "Silver", 800), // Electric
                new Car("Subaru", "Crosstrek", 2018, "Orange", 152), // Benzin
                new Car("Lexus", "RX 450h", 2020, "Black", 308), // Benzin (Hybrid)
                new Car("Porsche", "718 Cayman", 2020, "Yellow", 300), // Benzin
                new Car("Mazda", "CX-9", 2018, "White", 250), // Benzin
                new Car("Jeep", "Cherokee", 2017, "Red", 271), // Benzin
                new Car("Hyundai", "Kona", 2021, "Gray", 175), // Benzin
                new Car("Kia", "Rio", 2016, "Blue", 130), // Benzin
                new Car("Ford", "Edge", 2019, "Silver", 250), // Benzin
                new Car("Toyota", "Corolla", 2020, "White", 169), // Benzin
                new Car("Chevrolet", "Traverse", 2018, "Black", 310), // Benzin
                new Car("Honda", "Odyssey", 2017, "Red", 280), // Benzin
                new Car("BMW", "X7", 2021, "Blue", 355), // Benzin
                new Car("Volvo", "XC40", 2020, "Silver", 187), // Benzin
                new Car("Audi", "Q3", 2018, "Gray", 228), // Benzin
                new Car("Mercedes-Benz", "S-Class", 2019, "White", 463), // Benzin
                new Car("Tesla", "Roadster", 2024, "Red", 1000), // Electric
                new Car("Subaru", "Ascent", 2019, "Blue", 260), // Benzin
                new Car("Lexus", "LC 500", 2021, "Black", 471), // Benzin
                new Car("Porsche", "911 Turbo S", 2023, "Silver", 640), // Benzin
                new Car("Mazda", "CX-3", 2016, "White", 146), // Benzin
                new Car("Jeep", "Gladiator", 2020, "Red", 285), // Benzin
                new Car("Hyundai", "Veloster", 2017, "Yellow", 147), // Benzin
                new Car("Kia", "Soul", 2019, "Gray", 147), // Benzin
                new Car("Ford", "Expedition", 2018, "White", 375), // Benzin
                new Car("Toyota", "Avalon", 2021, "Black", 301), // Benzin
                new Car("Chevrolet", "Blazer", 2019, "Blue", 305), // Benzin
                new Car("Honda", "Ridgeline", 2020, "Gray", 280) // Benzin*/
            };

            //int amountOfFirstCarBrand = 0;
            

            foreach (Car car in cars)
            {
                /*if (car.Brand == cars[0].Brand)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Color} {car.HorsePower}");
                }
                

                if (car.HorsePower > 200 && car.Brand != cars[0].Brand)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Color} {car.HorsePower}");
                }*/

                /*if (car.Color == "Red")
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Color} {car.HorsePower}");
                }*/


                /*if (car.Brand == cars[0].Brand)
                {
                    amountOfFirstCarBrand++;
                }*/

                /*if (car.Year <= 1999 && car.Year >= 1980)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Color} {car.HorsePower}");
                }*/

            }

            //Console.WriteLine(amountOfFirstCarBrand);
        }
    }
}
