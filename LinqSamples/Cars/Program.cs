using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateXML();
            QueryXML();

            //var manufacturers = ProcessManufacturers("manufacturers.csv");

            //var extensionMethodsQuery = cars.Join(manufacturers, 
            //                                      c => new { c.Manufacturer, c.Year }, 
            //                                      m => new { Manufacturer = m.Name, m.Year }, 
            //                                      (c,m) => new
            //                                      {
            //                                          m.Headquarters,
            //                                          c.Name,
            //                                          c.Combined
            //                                      })
            //                .OrderByDescending(c => c.Combined)
            //                .ThenBy(c => c.Name);

            //var linqSyntaxQuery = from car in cars
            //             join manufacturer in manufacturers 
            //             on  new { car.Manufacturer, car.Year } equals new { Manufacturer = manufacturer.Name, manufacturer.Year }
            //             orderby car.Combined descending, car.Name ascending
            //             select new
            //             {
            //                 manufacturer.Headquarters,
            //                 car.Name,
            //                 car.Combined
            //             };

            //foreach (var car in extensionMethodsQuery.Take(10))
            //{
            //    Console.WriteLine($"{car.Headquarters} {car.Name} : {car.Combined}");
            //}

            //Console.WriteLine("***********");

            //foreach (var car in linqSyntaxQuery.Take(10))
            //{
            //    Console.WriteLine($"{car.Headquarters} {car.Name} : {car.Combined}");
            //}

            //var groupedLinqSyntaxQuery = from car in cars
            //                             group car by car.Manufacturer into carGroup
            //                             select new
            //                             {
            //                                 Name = carGroup.Key,
            //                                 MaxFE = carGroup.Max(c => c.Combined),
            //                                 MinFE = carGroup.Min(c => c.Combined),
            //                                 AvgFE = carGroup.Average(c => c.Combined)
            //                             } into result
            //                             orderby result.MaxFE descending
            //                             select result;

            //var groupedExtensionMethodsQuery = cars.GroupBy(c => c.Manufacturer)
            //        .Select(g =>
            //        {
            //            var results = g.Aggregate(new CarStatistics(),
            //                                (acc, c) => acc.Accumulate(c),
            //                                acc => acc.Compute());
            //            return new
            //            {
            //                Name = g.Key,
            //                AverageFE = results.AverageFE,
            //                MinFE = results.MinFE,
            //                MaxFE = results.MaxFE
            //            };
            //        })
            //        .OrderByDescending(r => r.MaxFE);

            //foreach (var result in groupedLinqSyntaxQuery)
            //{
            //    Console.WriteLine($"{result.Name}");
            //    Console.WriteLine($"\t Max: {result.MaxFE}");
            //    Console.WriteLine($"\t Min: {result.MinFE}");
            //    Console.WriteLine($"\t Avg: {result.AvgFE}");
            //}

            //Console.WriteLine("*******");

            //foreach (var result in groupedExtensionMethodsQuery)
            //{
            //    Console.WriteLine($"{result.Name}");
            //    Console.WriteLine($"\t Max: {result.MaxFE}");
            //    Console.WriteLine($"\t Min: {result.MinFE}");
            //    Console.WriteLine($"\t Avg: {result.AverageFE}");
            //}
        }

        private static void QueryXML()
        {
            var ns = (XNamespace)"http://pluralsight.com/cars/2016";
            var ex = (XNamespace)"http://pluralsight.com/cars/2016/ex";
            var document = XDocument.Load("fuel.xml");

            var query = from element in document.Element(ns + "Cars")?.Elements(ex + "Car") 
                                                                ?? Enumerable.Empty<XElement>()
                        where element.Attribute("Manufacturer").Value == "BMW"
                        select element.Attribute("Name").Value;

            foreach (var element in query)
            {
                Console.WriteLine(element);
            }

        }

        private static void CreateXML()
        {
            var records = ProcessCars("fuel.csv");

            var ns = (XNamespace)"http://pluralsight.com/cars/2016";
            var ex = (XNamespace)"http://pluralsight.com/cars/2016/ex";
            var document = new XDocument();
            var cars = new XElement(ns + "Cars",
                           from record in records
                           select new XElement(ex + "Car",
                                  new XAttribute("Manufacturer", record.Manufacturer),
                                  new XAttribute("Name", record.Name),
                                  new XAttribute("CityFE", record.City),
                                  new XAttribute("HighwayFE", record.Highway),
                                  new XAttribute("CombinedFE", record.Combined)
                                  ));
            cars.Add(new XAttribute(XNamespace.Xmlns + "ex", ex));

            document.Add(cars);
            document.Save("fuel.xml");
        }

        private static List<Manufacturer> ProcessManufacturers(string path)
        {
            var query = File.ReadAllLines(path)
                            .Where(l => l.Length > 1)
                            .Select(l =>
                            {
                                var columns = l.Split(",");
                                return new Manufacturer
                                {
                                    Name = columns[0],
                                    Headquarters = columns[1],
                                    Year = int.Parse(columns[2])
                                };
                            });
            return query.ToList();
        }

        private static List<Car> ProcessCars(string path)
        {
            return File.ReadAllLines(path)
                       .Skip(1)
                       .Where(line => line.Length > 1)
                       .ToCar()
                       .ToList();
        }
    }

    public class CarStatistics
    {
        public CarStatistics()
        {
            MaxFE = Int32.MinValue;
            MinFE = Int32.MaxValue;
        }

        public CarStatistics Accumulate(Car car)
        {
            Count += 1;
            Total += car.Combined;
            MaxFE = Math.Max(MaxFE, car.Combined);
            MinFE = Math.Min(MinFE, car.Combined);

            return this;
        }

        public CarStatistics Compute()
        {
            AverageFE = Total / Count;

            return this;
        }

        public int MaxFE { get; set; }
        public int MinFE { get; set; }
        public int Total { get; set; }
        public int Count { get; set; }
        public double AverageFE { get; set; }
    }

    public static class CarExtensions
    {
        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(",");

                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }
        }
    }
}
