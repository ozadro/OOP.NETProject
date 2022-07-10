using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Model;

namespace Utility.Manager
{
    public class StatesManager
    {
        public const string EXTENSION = ".txt";
        public const string DIR = @"..\..\..\SaveOption\FavStates";
        public const string PATH = DIR + @"\";
        public const string NAME = "favState" + EXTENSION;
        public void SaveStates(string states, string gender)
        {
            if (!Directory.Exists(DIR))
            {
                Directory.CreateDirectory(DIR);
            }
            string path = PATH + gender + NAME;
            var data = JsonConvert.SerializeObject(states);
            File.WriteAllText(path, data);


        }

        public string LoadStates(string gender)
        {

            string path = PATH + gender + NAME;
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

        public bool FileExists(string gender)
        {
            string path = PATH + gender + NAME;
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
