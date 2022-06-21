using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using Utility.Constants;
using Utility.Model;

namespace Utility.Dal
{
    public class JsonData
    {

        //Deserializer
        public IList<States> GetDeserializatedOffStatesObject(string statesRawData)
        {
            return JsonConvert.DeserializeObject<IList<States>>(statesRawData);
        }

        //MALE
        public string GetRawMaleOffStatesData()
        {

            string jsonClient = JsonConstants.MTEAMS;
            string jsonString = File.ReadAllText(jsonClient);
            return jsonString;

        }

        public IList<States> GetAllOffMaleStates()
        {


            IList<States> states = new List<States>();
            var statesRawData = GetRawMaleOffStatesData();
            var statesData = GetDeserializatedOffStatesObject(statesRawData);




            // puni drop down list
            foreach (var state in statesData)
            {
                states.Add(state);
            }



            return states;

        }

        //FEMALE
        public string GetRawFemaleOffStatesData()
        {
            string jsonClient = JsonConstants.FTEAMS;
            string jsonString = File.ReadAllText(jsonClient);
            return jsonString;

        }

        public  IList<States> GetAllFemaleOffStates()
        {


            IList<States> states = new List<States>();
            var statesRawData =  GetRawFemaleOffStatesData();
            var statesData = GetDeserializatedOffStatesObject(statesRawData);




            //puni drop down list
            foreach (var state in statesData)
            {
                states.Add(state);
            }



            return states;

        }



        /***MATCHES***/

        //Deserializer
        public IList<Match> GetDeserializatedOffTeamObject(string teamRawData)
        {
            return JsonConvert.DeserializeObject<IList<Match>>(teamRawData);
        }
        //MALE
        public string GetRawMaleOffTeamData()
        {

            string jsonClient = JsonConstants.MALEMATCHES;
            string jsonString = File.ReadAllText(jsonClient);
            return jsonString;

        }

        public  IList<Match> GetAllMaleOffMatches()
        {


            IList<Match> teams = new List<Match>();
            var teamsRawData =  GetRawMaleOffTeamData();
            var teamData = GetDeserializatedOffTeamObject(teamsRawData);




            // puni drop down list
            foreach (Match team in teamData)
            {
                teams.Add(team);
            }



            return teams;

        }






        //Female
        public string GetRawFemaleOffTeamData()
        {

            string jsonClient = JsonConstants.FEMALEMATCHES;
            string jsonString = File.ReadAllText(jsonClient);
            return jsonString;

        }

        public  IList<Match> GetAllFemaleOffMatches()
        {


            IList<Match> teams = new List<Match>();
            var teamsRawData =  GetRawFemaleOffTeamData();
            var teamData = GetDeserializatedOffTeamObject(teamsRawData);




            // puni drop down list
            foreach (Match team in teamData)
            {
                teams.Add(team);
            }



            return teams;

        }


    }
}
