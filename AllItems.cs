
using System;
using System.IO;
using System.Xml.Linq;

namespace Parsers
{
    public class AllItems
    {
        private static string PATH = Environment.CurrentDirectory + @"\AllItems";
        public List<Category> Catygories { get; set; }

        public static AllItems GetAll()
        {
            var dir = Directory.GetDirectories(PATH); 
            var listCaty = new List<Category>();
            foreach (var caty in dir)
            {
                var name = caty.Replace($@"{PATH}\", "");
                listCaty.Add(Category.GetAll(name));
            }

            var allItems = new AllItems()
            {
               Catygories = listCaty
            };
            return allItems;
        }
    }

    public class Category
    {
        private static string PATH = Environment.CurrentDirectory + @"\AllItems";
        public string Name { get; set; }
        public List<Item>? Items { get; set; }

        public static Category GetAll(string name)
        {
            var dir = Directory.GetFiles(PATH + @$"\{name}", "*.json");
            var it = new List<Item>();
            foreach (var filename in dir)
            {
                var jsonString = File.ReadAllText(filename);
                it.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(jsonString));
            }
            var category = new Category()
            {
                Name = name,
                Items = it
            };
            return category;
        }
    }

    public class Item
    {
        public static List<Item> GetSearchByItem(string name)
        {
            var path = Environment.CurrentDirectory + @"\wwwroot\all";
            var files = Directory.GetFiles(path, "*.json");
            var items = new List<Item>();
            foreach (var file in files)
            {
                string jsonString = System.IO.File.ReadAllText(file);
                Item it = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(jsonString);
                if (it.Name.Contains(name))
                {
                    items.Add(it);
                }
            }

            return items;
        }
        public static Item GetByHash(string hash)
        {
            if (hash != "none")
            {
                string path = Environment.CurrentDirectory + @$"\wwwroot\all\{hash}.json";
                string jsonString = System.IO.File.ReadAllText(path);
                var it = Newtonsoft.Json.JsonConvert.DeserializeObject<Item>(jsonString);
                return it;
            }
            else
            {
                return null;
            }
        }
        public Item GetAll()
        {
            var item = new Item()
            {

            };
            return item;
        }


        public string Hash { get; set; }//s
        public string Category { get; set; }//s
        public string Name { get; set; }
        public Description Description { get; set; }
        public bool Like { get; set; }
        public string Creater { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public string PhotoPath { get; set; }
    }

    public class Description
    {
        public string Color { get; set; }
        public string Descr { get; set; }
        public string Matireal { get; set; }
    }
    


}
