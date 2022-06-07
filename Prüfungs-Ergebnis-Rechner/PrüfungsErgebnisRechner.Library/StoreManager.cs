using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using PrüfungsErgebnisRechner.Library;

namespace PrüfungsProjekt
{
    public static class StoreManager
    {
        public static string LastPath { get; private set; }
        public static string LastName { get; private set; }
        public static void Store(Beruf[] berufe, string path = null, string name = null)
        {
            if(string.IsNullOrEmpty(path) && string.IsNullOrEmpty(LastPath))
            {
                throw new ArgumentException("Es ist weder ein neuer noch ein alter Pfad bekannt, bitte geben sie einen an!");
            }
            else if (string.IsNullOrEmpty(path))
            {
                path = LastPath;
            }
            else
            {
                LastPath = path;
            }

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(LastName)) 
            {
                throw new ArgumentNullException("Es ist weder ein neuer noch ein alter Name bekannt, bitte geben sie einen an!");
            }else if (string.IsNullOrEmpty(name))
            {
                name = LastName;
            }
            else
            {
                LastName = name;
            }

            if (!name.EndsWith(".prf"))
            {
                name += ".prf";
            }

            File.WriteAllText(Path.Combine(path, name), JsonConverter.ConvertToJson(berufe));
        }

        public static Beruf[] ReadFile(string path)
        {
            var test = JsonConverter.ConvertFromJson(path);
            return test;
        }
    }

    static class JsonConverter
    {
        public static string ConvertToJson(Beruf[] input)
        {
            return JsonConvert.SerializeObject(input);
        }

        public static Beruf[] ConvertFromJson(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new Exception("No path was given");
            }else if(!path.EndsWith(".prf")){
                throw new Exception("File Type is not accepted");
            }
            string text = File.ReadAllText(path);
            var test = JsonConvert.DeserializeObject<JsonFile>(text);
            return test.Berufe;
        }
    }
}
