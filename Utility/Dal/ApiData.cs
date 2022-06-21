using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utility.Constants;
using Utility.Model;

namespace Utility.Dal
{
    public class ApiData 
    {


        /***STATES***/
        //Deserializer
        public IList<States> GetDeserializatedStatesObject(IRestResponse<States> statesRawData)
        {
            return JsonConvert.DeserializeObject<IList<States>>(statesRawData.Content);
        }

        //MALE
        public Task<IRestResponse<States>> GetRawMaleStatesData()
        {
            var apiClient = new RestClient(ApiConstants.MTEAMS);
            return apiClient.ExecuteAsync<States>(new RestRequest());

        }

        public async Task<IList<States>>  GetAllMaleStates()
        {


            IList<States> states = new List<States>();
            var statesRawData = await GetRawMaleStatesData();
            var statesData = GetDeserializatedStatesObject(statesRawData);




            // puni drop down list
            foreach (var state in statesData)
            {
                states.Add(state);
            }



            return states;

        }

        //FEMALE
        public Task<IRestResponse<States>> GetRawFemaleStatesData()
        {
            var apiClient = new RestClient(ApiConstants.FTEAMS);
            return apiClient.ExecuteAsync<States>(new RestRequest());

        }

        public async Task<IList<States>> GetAllFemaleStates()
        {


            IList<States> states = new List<States>();
            var statesRawData = await GetRawFemaleStatesData();
            var statesData = GetDeserializatedStatesObject(statesRawData);




            // puni drop down list
            foreach (var state in statesData)
            {
                states.Add(state);
            }



            return states;

        }





        /***MATCHES***/

        //Deserializer
        public IList<Match> GetDeserializatedTeamObject(IRestResponse<Match> teamRawData)
        {
            return JsonConvert.DeserializeObject<IList<Match>>(teamRawData.Content);
        }
        //MALE
        public Task<IRestResponse<Match>> GetRawMaleTeamData(string code)
        {
            
            var apiClient = new RestClient(ApiConstants.MALEMATCHES + code);
            
            return apiClient.ExecuteAsync<Match>(new RestRequest());

        }

        public async Task<IList<Match>> GetAllMaleMatches(string code)
        {


            IList<Match> teams = new List<Match>();
            var teamsRawData = await GetRawMaleTeamData(code);
            var teamData = GetDeserializatedTeamObject(teamsRawData);




            // puni drop down list
            foreach (Match team in teamData)
            {
                teams.Add(team);
            }



            return teams;

        }






        //Female
        public Task<IRestResponse<Match>> GetRawFemaleTeamData(string code)
        {

            var apiClient = new RestClient(ApiConstants.FEMALEMATCHES + code);

            return apiClient.ExecuteAsync<Match>(new RestRequest());

        }

        public async Task<IList<Match>> GetAllFemaleMatches(string code)
        {


            IList<Match> teams = new List<Match>();
            var teamsRawData = await GetRawFemaleTeamData(code);
            var teamData = GetDeserializatedTeamObject(teamsRawData);




            // puni drop down list
            foreach (Match team in teamData)
            {
                teams.Add(team);
            }



            return teams;

        }



        ///***TeamStats***/
        //public IList<StartingEleven> GetDeserializatedPlayersObject(IRestResponse<StartingEleven> statsRawData)
        //{
        //    return JsonConvert.DeserializeObject<IList<StartingEleven>>(statsRawData.Content);
        //}

        ////MALE

        //public Task<IRestResponse<StartingEleven>> GetRawMalePlayersData(string code)
        //{
        //    var apiClient = new RestClient(ApiConstants.MALEMATCHES + code);
        //    return apiClient.ExecuteAsync<StartingEleven>(new RestRequest());

        //}

        //public async Task<IList<StartingEleven>> GetAllMalePlayers(string code)
        //{


        //    IList<StartingEleven> players = new List<StartingEleven>();
        //    var playersRawData = await GetRawMalePlayersData(code);
        //    var playersData = GetDeserializatedPlayersObject(playersRawData);
           
        //    // puni drop down list
        //    foreach (StartingEleven player in playersData)
        //    {
        //        players.Add(player);
        //    }

        //    return players;

           
        

        //}





    }
}
