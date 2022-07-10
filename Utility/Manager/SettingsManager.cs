using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Manager
{
    public class SettingsManager
    {
        public const string EXTENSION = ".txt";
        public const string DIR = @"..\..\..\SaveOption\Settings";
        public const string PATH = DIR + @"\";


        //Gender Save File
        public void Save(string setting,string naziv)
        {
            if (!Directory.Exists(DIR))
            {
                Directory.CreateDirectory(DIR);
            }
            string name = naziv + "Odabir.txt";
            string path = PATH + name;
            var data = JsonConvert.SerializeObject(setting);
            File.WriteAllText(path, data);


        }

        public string Load(string naziv)
        {
            string name = naziv + "Odabir.txt";
            string path = PATH + name;
            if (File.Exists(path))
            {

                string json = "";
                StreamReader sr = new StreamReader(path);
                using (sr)
                { json = sr.ReadToEnd(); }
                var data = JsonConvert.DeserializeObject<string>(json);
                return data;
            }
            return null;


        }

        public bool FileExists(string naziv)
        {
            string name = naziv + "Odabir.txt";
            string path = PATH + name;
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 


    }
}
