using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace HaikuCatalog
{
    class Program
    {
        static string _haikuDB = $"{AppDomain.CurrentDomain.BaseDirectory}\\haikuDB.json";

        static void Main(string[] args)
        {
            var menuHelper = new MenuHelper();
            menuHelper.InteractWithMenu<CatalogService>();
            Console.WriteLine("\nGood Bye!");
        }
        
        static List<T> genericReader<T>() where T : class
        {
            var results = new List<T>();
            if (File.Exists(_haikuDB))
            {
                results = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(_haikuDB));
            }
            return results;
        }

        static void genericWriter<T>(T model) where T : class
        {
            using (var file = File.CreateText(_haikuDB))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, model);
            }
        }
    }
}
