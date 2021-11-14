using Builder.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Class
{
    public static class settings
    {
        public static List<projectModel> getSettings()
        {
            using (StreamReader r = new StreamReader("settings.json"))
            {
                string json = r.ReadToEnd();
                List<projectModel> items = JsonConvert.DeserializeObject<List<projectModel>>(json);
                return items;
            }
        }

        public static string getBuilder()
        {
            try
            {
                using (StreamReader r = new StreamReader("builder.json"))
                {
                    string settings = r.ReadToEnd();
                    return settings;
                }
            }
            catch (Exception)
            {

                return "";
            }
        }
    }
}
