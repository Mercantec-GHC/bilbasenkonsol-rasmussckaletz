using BilbasenNew;

namespace BilbasenKonsol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<object> list = new List<object>
            {
                new GasolineCar("Tesla", "Mustang", 1963, "Red", 430, 8),
                new GasolineCar("Toyota", "Camry", 2020, "Blue", 200, 4),
                new GasolineCar("Chevrolet", "Corvette", 2022, "Silver", 650, 8),
                new GasolineCar("Honda", "Civic", 2005, "Black", 150, 4),
                new GasolineCar("BMW", "3 Series", 2018, "White", 320, 4),
                new GasolineCar("Volkswagen", "Golf", 2019, "Gray", 170, 4),
                new GasolineCar("Audi", "A4", 2021, "Black", 248, 4),
                new GasolineCar("Mercedes-Benz", "E-Class", 2017, "Silver", 320, 6),
                new ElectricCar("Tesla", "Model S", 2023, "Blue", 750, 100),
                new GasolineCar("Subaru", "Outback", 2015, "Green", 175, 4),
                new GasolineCar("Lexus", "RX 350", 2019, "White", 295, 6),
                new GasolineCar("Porsche", "911", 2021, "Red", 443, 6),
                new GasolineCar("Mazda", "MX-5", 2016, "Yellow", 181, 4),
                new GasolineCar("Jeep", "Wrangler", 2018, "Black", 285, 6),
                new GasolineCar("Hyundai", "Elantra", 2017, "Silver", 147, 4),
                new GasolineCar("Kia", "Sorento", 2020, "Blue", 185, 4),
                new GasolineCar("Ford", "Escape", 2019, "Gray", 168, 4),
                new GasolineCar("Toyota", "RAV4", 2021, "White", 203, 4),
                new GasolineCar("Chevrolet", "Silverado", 2015, "Black", 355, 8),
                new GasolineCar("Honda", "Accord", 2016, "Red", 185, 4),
                new GasolineCar("BMW", "5 Series", 2020, "Silver", 335, 6),
                new GasolineCar("Volvo", "XC90", 2018, "Blue", 316, 4),
                new GasolineCar("Audi", "Q5", 2019, "White", 248, 4),
                new GasolineCar("Mercedes-Benz", "GLC 300", 2021, "Black", 255, 4),
                new ElectricCar("Tesla", "Model 3", 2022, "Red", 318, 90),
                new GasolineCar("Subaru", "Forester", 2017, "Green", 170, 4),
                new GasolineCar("Lexus", "ES 350", 2020, "Silver", 302, 6),
                new GasolineCar("Porsche", "Cayenne", 2019, "Blue", 340, 6),
                new GasolineCar("Mazda", "CX-5", 2017, "Gray", 187, 4),
                new GasolineCar("Jeep", "Grand Cherokee", 2016, "Black", 295, 6),
                new GasolineCar("Hyundai", "Tucson", 2020, "White", 161, 4),
                new GasolineCar("Kia", "Sportage", 2018, "Silver", 181, 4),
                new GasolineCar("Ford", "Explorer", 2022, "Red", 300, 6),
                new GasolineCar("Toyota", "Tacoma", 2015, "Black", 278, 6),
                new GasolineCar("Chevrolet", "Tahoe", 2019, "White", 355, 8),
                new GasolineCar("Honda", "Pilot", 2018, "Blue", 280, 6),
                new GasolineCar("BMW", "X5", 2020, "Silver", 335, 6),
                new GasolineCar("Volvo", "S60", 2017, "Black", 316, 4),
                new GasolineCar("Audi", "A6", 2018, "Gray", 335, 6),
                new GasolineCar("Mercedes-Benz", "CLA 250", 2019, "White", 221, 4),
                new ElectricCar("Tesla", "Model X", 2021, "Blue", 670, 100),
                new GasolineCar("Subaru", "Impreza", 2016, "Blue", 152, 4),
                new GasolineCar("Lexus", "IS 300", 2018, "Black", 260, 6),
                new GasolineCar("Porsche", "Macan", 2020, "Silver", 348, 6),
                new GasolineCar("Mazda", "3", 2017, "Red", 155, 4),
                new GasolineCar("Jeep", "Renegade", 2019, "White", 180, 4),
                new GasolineCar("Hyundai", "Sonata", 2022, "Blue", 191, 4),
                new GasolineCar("Kia", "Optima", 2016, "Black", 185, 4),
                new GasolineCar("Ford", "F-150", 2018, "Silver", 395, 8),
                new GasolineCar("Toyota", "Highlander", 2017, "Gray", 295, 6),
                new GasolineCar("Chevrolet", "Equinox", 2020, "White", 170, 4),
                new GasolineCar("Honda", "HR-V", 2019, "Red", 141, 4),
                new GasolineCar("BMW", "7 Series", 2021, "Black", 600, 8),
                new GasolineCar("Volvo", "XC60", 2019, "Blue", 316, 4),
                new GasolineCar("Audi", "Q7", 2020, "Silver", 335, 6),
                new GasolineCar("Mercedes-Benz", "C300", 2016, "White", 241, 4),
                new ElectricCar("Tesla", "Model Y", 2022, "Blue", 670, 90),
                new GasolineCar("Subaru", "Legacy", 2015, "Black", 175, 4),
                new GasolineCar("Lexus", "NX 300", 2018, "Silver", 235, 4),
                new GasolineCar("Porsche", "Panamera", 2019, "Red", 400, 8),
                new GasolineCar("Mazda", "6", 2017, "Gray", 187, 4),
                new GasolineCar("Jeep", "Compass", 2018, "White", 180, 4),
                new GasolineCar("Hyundai", "Santa Fe", 2021, "Blue", 235, 4),
                new GasolineCar("Kia", "Forte", 2016, "Black", 147, 4),
                new GasolineCar("Ford", "Ranger", 2019, "Silver", 270, 4),
                new GasolineCar("Toyota", "Sienna", 2017, "Gray", 296, 6),
                new GasolineCar("Chevrolet", "Colorado", 2020, "White", 200, 4),
                new GasolineCar("Honda", "Fit", 2018, "Red", 130, 4),
                new GasolineCar("BMW", "X3", 2022, "Black", 248, 4),
                new GasolineCar("Volvo", "V90", 2020, "Silver", 316, 4),
                new GasolineCar("Audi", "A8", 2019, "White", 460, 8),
                new GasolineCar("Mercedes-Benz", "GLE 450", 2021, "Blue", 362, 6),
                new ElectricCar("Tesla", "Cybertruck", 2023, "Silver", 800, 120),
                new GasolineCar("Subaru", "Crosstrek", 2018, "Orange", 152, 4),
                new GasolineCar("Lexus", "RX 450h", 2020, "Black", 308, 6),
                new GasolineCar("Porsche", "718 Cayman", 2020, "Yellow", 300, 4),
                new GasolineCar("Mazda", "CX-3", 2016, "White", 146, 4),
                new GasolineCar("Jeep", "Gladiator", 2020, "Red", 285, 6),
                new GasolineCar("Hyundai", "Veloster", 2017, "Yellow", 147, 4),
                new GasolineCar("Kia", "Soul", 2019, "Gray", 147, 4),
                new GasolineCar("Ford", "Expedition", 2018, "White", 375, 6),
                new GasolineCar("Toyota", "Avalon", 2021, "Black", 301, 6),
                new GasolineCar("Chevrolet", "Blazer", 2019, "Blue", 305, 6),
                new GasolineCar("Honda", "Ridgeline", 2020, "Gray", 280, 6)
            };


            string firstCarBrand = "";
            int amountOfFirstCarBrand = 0;


            foreach (object obj in list)
            {
                if (obj is ElectricCar) // https://stackoverflow.com/questions/2763501/can-i-use-foreach-to-return-only-a-certain-type-from-a-collection
                {
                    ElectricCar electricCar = (ElectricCar) obj;

                    if (electricCar == list[0])
                    {
                        firstCarBrand = electricCar.Brand;
                    }
                    if (electricCar.Brand == firstCarBrand)
                    {
                        Console.WriteLine($"{electricCar.Brand} {electricCar.Model} {electricCar.Year} {electricCar.Color} {electricCar.HorsePower} {electricCar.BatteryCapacity}");
                    }
                }

                else if (obj is GasolineCar)
                {
                    GasolineCar gasolineCar = (GasolineCar) obj;

                    if (gasolineCar == list[0])
                    {
                        firstCarBrand = gasolineCar.Brand;
                    }
                    if (gasolineCar.Brand == firstCarBrand)
                    {
                        Console.WriteLine($"{gasolineCar.Brand} {gasolineCar.Model} {gasolineCar.Year} {gasolineCar.Color} {gasolineCar.HorsePower} {gasolineCar.NumberOfCylinders}");
                    }
                }
            }

            

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


            //Console.WriteLine(amountOfFirstCarBrand);
        }
    }
}
