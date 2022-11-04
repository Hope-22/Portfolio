using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Portfolio_Project.data
{
    public class Seeder
    {

        private string db = Path.Combine(Directory.GetCurrentDirectory(), "Data/");
        public bool WriteJson<T>(T model, string jsonFile)
        {
            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                File.AppendAllTextAsync(db + jsonFile, json);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<T> ReadJson<T>(string jsonFile)
        {
            var readText = File.ReadAllText(db + jsonFile);
            var objects = new List<T>();
            var serializer = new JsonSerializer();
            var stringReader = new StringReader(readText);
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;
                while (jsonReader.Read())
                {
                    T json = serializer.Deserialize<T>(jsonReader);
                    objects.Add(json);
                }
            }
            return objects;
        }
    }
}
