using json;
using System.Collections.Generic;
using System.Xml.Serialization;
using ss;
using Newtonsoft.Json;

namespace convert
{
    internal class Files
    {
        public void path(string path)
        {
            string[] file = File.ReadAllLines(path);
            string Jfile = File.ReadAllText(path);
            string Xfile = path;
            string type = Convert.ToString(path[path.Length - 1]);
            if (type == "z")
            {
                txt(path);
            }
            if (type == "x")
            {
                json(Jfile);
            }
            if (type == "c")
            {
                xml(Xfile);
            }
        }
        private void json(string Jfile)
        {
            List<Place> result = JsonConvert.DeserializeObject<List<Place>>(Jfile);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i].name);
                Console.WriteLine(result[i].kolvo);
            }
            string[] file = new string[4] { Convert.ToString(result[0].name), Convert.ToString(result[0].kolvo),
                Convert.ToString(result[1].name), Convert.ToString(result[1].kolvo) };
            redact let = new redact();
            file = let.text(file);
            Console.Clear();
            Console.WriteLine("Введите тип данных: ");
            Place one = new Place();
            one.name = file[0];
            one.kolvo = Convert.ToInt32(file[1]);
            Place two = new Place();
            two.name = file[2];
            two.kolvo = Convert.ToInt32(file[3]);
            List<Place> countries = new List<Place>();
            countries.Add(one);
            countries.Add(two);
            string way = Console.ReadLine();
            string tip = Convert.ToString(way[way.Length - 1]);
            if (tip == "z")
            {
                File.WriteAllLines(way, file);
            }
            if (tip == "x")
            {

                string json = JsonConvert.SerializeObject(countries);
                File.WriteAllText(way, json);
            }
            if (tip == "c")
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Place>));
                using (FileStream FS = new FileStream(way, FileMode.OpenOrCreate))
                {
                    xml.Serialize(FS, countries);
                }
            }
        }
        private void txt(string path)
        {
            string[] file = File.ReadAllLines(path);
            redact let = new redact();
            file = let.text(file);
            int x = 0;
            while (file.Length > x)
            {
                Console.WriteLine(file[x]);
                x++;
            }
            Place one = new Place();
            one.name = file[0];
            one.kolvo = Convert.ToInt32(file[1]);
            Place two = new Place();
            two.name = file[2];
            two.kolvo = Convert.ToInt32(file[3]);
            List<Place> countries = new List<Place>();
            countries.Add(one);
            countries.Add(two);
            Console.Clear();
            Console.WriteLine("Введите тип данных: ");
            string way = Console.ReadLine();
            string tip = Convert.ToString(way[way.Length - 1]);
            if (tip == "z")
            {
                File.WriteAllLines(way, file);
            }
            if (tip == "x")
            {

                string json = JsonConvert.SerializeObject(countries);
                File.WriteAllText(way, json);
            }
            if (tip == "c")
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Place>));
                using (FileStream FS = new FileStream(way, FileMode.OpenOrCreate))
                {
                    xml.Serialize(FS, countries);
                }
            }
        }
        private void xml(string Xfile)
        {
            List<Place> countries = new List<Place>();
            XmlSerializer xml = new XmlSerializer(typeof(List<Place>));
            using (FileStream FS = new FileStream(Xfile, FileMode.Open))
            {
                countries = (List<Place>)xml.Deserialize(FS);
            }
            for (int i = 0; i < countries.Count; i++)
            {
                Console.WriteLine(countries[i].name);
                Console.WriteLine(countries[i].kolvo);
            }
            string[] file = new string[4] { Convert.ToString(countries[0].name), Convert.ToString(countries[0].kolvo),
                Convert.ToString(countries[1].name), Convert.ToString(countries[1].kolvo) };
            redact let = new redact();
            file = let.text(file);
            Console.Clear();
            Console.WriteLine("Введите тип данных: ");
            Place one = new Place();
            one.name = file[0];
            one.kolvo = Convert.ToInt32(file[1]);
            Place two = new Place();
            two.name = file[2];
            two.kolvo = Convert.ToInt32(file[3]);
            List<Place> CountryList = new List<Place>();
            CountryList.Add(one);
            CountryList.Add(two);
            string way = Console.ReadLine();
            string tip = Convert.ToString(way[way.Length - 1]);
            if (tip == "z")
            {
                File.WriteAllLines(way, file);
            }
            if (tip == "x")
            {
                string json = JsonConvert.SerializeObject(CountryList);
                File.WriteAllText(way, json);
            }
            if (tip == "c")
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Place>));
                using (FileStream FS = new FileStream(way, FileMode.OpenOrCreate))
                {
                    xml.Serialize(FS, CountryList);
                }
            }
        }
    }
}