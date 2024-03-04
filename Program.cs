﻿using BilbasenNew;

namespace BilbasenKonsol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car[] cars = { // https://stackoverflow.com/questions/58517157/how-to-loop-array-of-objects-using-foreach
                new Car("Ford", "Mustang", 1963, "Red", 430),
                new Car("Toyota", "Camry", 2020, "Blue", 200),
                new Car("Chevrolet", "Corvette", 2022, "Silver", 650),
                new Car("Honda", "Civic", 2005, "Black", 150),
                new Car("BMW", "3 Series", 2018, "White", 320),
                new Car("Volkswagen", "Golf", 2019, "Gray", 170),
                new Car("Audi", "A4", 2021, "Black", 248),
                new Car("Mercedes-Benz", "E-Class", 2017, "Silver", 320),
                new Car("Tesla", "Model S", 2023, "Blue", 750),
                new Car("Subaru", "Outback", 2015, "Green", 175),
                new Car("Lexus", "RX 350", 2019, "White", 295),
                new Car("Porsche", "911", 2021, "Red", 443),
                new Car("Mazda", "MX-5", 2016, "Yellow", 181),
                new Car("Jeep", "Wrangler", 2018, "Black", 285),
                new Car("Hyundai", "Elantra", 2017, "Silver", 147),
                new Car("Kia", "Sorento", 2020, "Blue", 185),
                new Car("Ford", "Escape", 2019, "Gray", 168),
                new Car("Toyota", "RAV4", 2021, "White", 203),
                new Car("Chevrolet", "Silverado", 2015, "Black", 355),
                new Car("Honda", "Accord", 2016, "Red", 185),
                new Car("BMW", "5 Series", 2020, "Silver", 335),
                new Car("Volvo", "XC90", 2018, "Blue", 316),
                new Car("Audi", "Q5", 2019, "White", 248),
                new Car("Mercedes-Benz", "GLC 300", 2021, "Black", 255),
                new Car("Tesla", "Model 3", 2022, "Red", 318),
                new Car("Subaru", "Forester", 2017, "Green", 170),
                new Car("Lexus", "ES 350", 2020, "Silver", 302),
                new Car("Porsche", "Cayenne", 2019, "Blue", 340),
                new Car("Mazda", "CX-5", 2017, "Gray", 187),
                new Car("Jeep", "Grand Cherokee", 2016, "Black", 295),
                new Car("Hyundai", "Tucson", 2020, "White", 161),
                new Car("Kia", "Sportage", 2018, "Silver", 181),
                new Car("Ford", "Explorer", 2022, "Red", 300),
                new Car("Toyota", "Tacoma", 2015, "Black", 278),
                new Car("Chevrolet", "Tahoe", 2019, "White", 355),
                new Car("Honda", "Pilot", 2018, "Blue", 280),
                new Car("BMW", "X5", 2020, "Silver", 335),
                new Car("Volvo", "S60", 2017, "Black", 316),
                new Car("Audi", "A6", 2018, "Gray", 335),
                new Car("Mercedes-Benz", "CLA 250", 2019, "White", 221),
                new Car("Tesla", "Model X", 2021, "Blue", 670),
                new Car("Subaru", "Impreza", 2016, "Blue", 152),
                new Car("Lexus", "IS 300", 2018, "Black", 260),
                new Car("Porsche", "Macan", 2020, "Silver", 348),
                new Car("Mazda", "3", 2017, "Red", 155),
                new Car("Jeep", "Renegade", 2019, "White", 180),
                new Car("Hyundai", "Sonata", 2022, "Blue", 191),
                new Car("Kia", "Optima", 2016, "Black", 185),
                new Car("Ford", "F-150", 2018, "Silver", 395),
                new Car("Toyota", "Highlander", 2017, "Gray", 295),
                new Car("Chevrolet", "Equinox", 2020, "White", 170),
                new Car("Honda", "HR-V", 2019, "Red", 141),
                new Car("BMW", "7 Series", 2021, "Black", 600),
                new Car("Volvo", "XC60", 2019, "Blue", 316),
                new Car("Audi", "Q7", 2020, "Silver", 335),
                new Car("Mercedes-Benz", "C300", 2016, "White", 241),
                new Car("Tesla", "Model Y", 2022, "Blue", 670),
                new Car("Subaru", "Legacy", 2015, "Black", 175),
                new Car("Lexus", "NX 300", 2018, "Silver", 235),
                new Car("Porsche", "Panamera", 2019, "Red", 400),
                new Car("Mazda", "6", 2017, "Gray", 187),
                new Car("Jeep", "Compass", 2018, "White", 180),
                new Car("Hyundai", "Santa Fe", 2021, "Blue", 235),
                new Car("Kia", "Forte", 2016, "Black", 147),
                new Car("Ford", "Ranger", 2019, "Silver", 270),
                new Car("Toyota", "Sienna", 2017, "Gray", 296),
                new Car("Chevrolet", "Colorado", 2020, "White", 200),
                new Car("Honda", "Fit", 2018, "Red", 130),
                new Car("BMW", "X3", 2022, "Black", 248),
                new Car("Volvo", "V90", 2020, "Silver", 316),
                new Car("Audi", "A8", 2019, "White", 460),
                new Car("Mercedes-Benz", "GLE 450", 2021, "Blue", 362),
                new Car("Tesla", "Cybertruck", 2023, "Silver", 800),
                new Car("Subaru", "Crosstrek", 2018, "Orange", 152),
                new Car("Lexus", "RX 450h", 2020, "Black", 308),
                new Car("Porsche", "718 Cayman", 2020, "Yellow", 300),
                new Car("Mazda", "CX-9", 2018, "White", 250),
                new Car("Jeep", "Cherokee", 2017, "Red", 271),
                new Car("Hyundai", "Kona", 2021, "Gray", 175),
                new Car("Kia", "Rio", 2016, "Blue", 130),
                new Car("Ford", "Edge", 2019, "Silver", 250),
                new Car("Toyota", "Corolla", 2020, "White", 169),
                new Car("Chevrolet", "Traverse", 2018, "Black", 310),
                new Car("Honda", "Odyssey", 2017, "Red", 280),
                new Car("BMW", "X7", 2021, "Blue", 355),
                new Car("Volvo", "XC40", 2020, "Silver", 187),
                new Car("Audi", "Q3", 2018, "Gray", 228),
                new Car("Mercedes-Benz", "S-Class", 2019, "White", 463),
                new Car("Tesla", "Roadster", 2024, "Red", 1000),
                new Car("Subaru", "Ascent", 2019, "Blue", 260),
                new Car("Lexus", "LC 500", 2021, "Black", 471),
                new Car("Porsche", "911 Turbo S", 2023, "Silver", 640),
                new Car("Mazda", "CX-3", 2016, "White", 146),
                new Car("Jeep", "Gladiator", 2020, "Red", 285),
                new Car("Hyundai", "Veloster", 2017, "Yellow", 147),
                new Car("Kia", "Soul", 2019, "Gray", 147),
                new Car("Ford", "Expedition", 2018, "White", 375),
                new Car("Toyota", "Avalon", 2021, "Black", 301),
                new Car("Chevrolet", "Blazer", 2019, "Blue", 305),
                new Car("Honda", "Ridgeline", 2020, "Gray", 280)
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

                if (car.Year <= 1999 && car.Year >= 1980)
                {
                    Console.WriteLine($"{car.Brand} {car.Model} {car.Year} {car.Color} {car.HorsePower}");
                }

            }

            //Console.WriteLine(amountOfFirstCarBrand);
        }
    }
}
