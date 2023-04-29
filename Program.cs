using System;
using System.Collections.Generic;
using System.IO;

namespace ReadCSVExample
{
    class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>();
            string filePath = "countries.csv";// Thêm địa chỉ  file gốc vào đây để thực hiện đọc và ỉn ra console

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        Country country = new Country()
                        {
                            Code = fields[4],
                            Name = fields[5]
                        };
                        countries.Add(country);
                    }
                }
                Console.WriteLine("List of countries:");
                foreach (var country in countries)
                {
                    Console.WriteLine(country.Code + ": " + country.Name);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading the file: " + e.Message);
            }
        }
    }
}
