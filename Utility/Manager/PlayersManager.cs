using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utility.Dal;
using Utility.Model;
using Newtonsoft.Json;
using System.IO;

namespace Utility.Manager
{
    public class PlayersManager
    {
        public const string EXTENSION = ".txt";
        public const string DIR = @"..\..\..\SaveOption\FavPlayers";
        public const string PATH =  DIR+ @"\";



        ///////////MALES////////////
        public async Task<IList<StartingEleven>> GetMalePlayers(string code)
        {

            ApiData match = new ApiData();



            var matchData = await match.GetAllMaleMatches(code);



            IList<Match> matches = new List<Match>();
            // puni drop down list
            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            IList<StartingEleven> startingeleven = new List<StartingEleven>();

            if (matches[0].HomeTeam.Code == code) {

                matches[0].HomeTeamStatistics.StartingEleven.ToList().ForEach(player => startingeleven.Add(player));

            }
            else
            {
                matches[0].AwayTeamStatistics.StartingEleven.ToList().ForEach(player => startingeleven.Add(player));
            }


            return startingeleven;
        }




        public  IList<StartingEleven> GetMaleOffPlayers(string code)
        {

            JsonData match = new JsonData();



            var matchData =  match.GetAllMaleOffMatches();



            IList<Match> matches = new List<Match>();
            // puni drop down list
            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            IList<StartingEleven> startingeleven = new List<StartingEleven>();


            foreach (var item in matches)
            {
                if (item.HomeTeam.Code == code)
                {
                    item.HomeTeamStatistics.StartingEleven.ToList().ForEach(p => startingeleven.Add(p));

                }
                else
                {
                    item.AwayTeamStatistics.StartingEleven.ToList().ForEach(p => startingeleven.Add(p));
                }

            }


         



            return startingeleven;
        }

      

        public async Task<IList<TeamEvent>> GetMaleTeamEvent(string code)
        {

            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<TeamEvent> teamEvents = new List<TeamEvent>();
            var matchData = await match.GetAllMaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            if (matches[0].HomeTeam.Code == code)
            {

                matches[0].HomeTeamEvents.ToList().ForEach(e => teamEvents.Add(e));
            }
            else
            {
                matches[0].AwayTeamEvents.ToList().ForEach(e => teamEvents.Add(e));
            }

            return teamEvents;

        }


        public async Task<IList<Team>> GetMaleHomeTeam (string code)
        {
            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<Team> homeTeam = new List<Team>();
            var matchData = await match.GetAllMaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }
            if (matches[0].HomeTeam.Code == code)
            {
                foreach (var item in matches)
                {
                    homeTeam.Add(matches[0].HomeTeam);
                }
            }
            else
            {
                foreach (var item in matches)
                {
                    homeTeam.Add(matches[0].AwayTeam);
                }
            }

            return homeTeam;
        }
        public async Task<IList<Team>> GetMaleAwayTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<Team> awayTeam = new List<Team>();
            var matchData = await match.GetAllMaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }
            if (matches[0].HomeTeam.Code == code)
            {
                foreach (var item in matches)
                {
                    awayTeam.Add(matches[0].AwayTeam);
                }
            }
            else
            {
                foreach (var item in matches)
                {
                    awayTeam.Add(matches[0].HomeTeam);
                }
            }

            return awayTeam;
        }

        public async Task<IList<Match>> GetGameDataMaleForTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> allMatchData = new List<Match>();
            IList<Match> specificMatchData = new List<Match>();
            var matchData = await match.GetAllMaleMatches(code);

            foreach (var item in matchData)
            {
                allMatchData.Add(item);
            }

            if (allMatchData[0].HomeTeam.Code == code)
            {
                allMatchData.ToList().ForEach(m => specificMatchData.Add(m));
            }
            else if (allMatchData[0].AwayTeam.Code == code) 
            {
                allMatchData.ToList().ForEach(m => specificMatchData.Add(m));
            }

            return specificMatchData;

        }


        public async Task<IList<string>> GetAllMatchesForMaleTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> allMatchData = new List<Match>();
            IList<string> allGamesData = new List<string>();

            var matchData = await match.GetAllMaleMatches(code);

            foreach (var item in matchData)
            {
                allMatchData.Add(item);
            }

            if (allMatchData[0].HomeTeam.Code == code)
            {
                
               
                    allGamesData.Add(allMatchData[0].AwayTeam.Code);

               
            }
            else
            {

                allGamesData.Add(allMatchData[0].HomeTeam.Code);

                
            }
            if (allMatchData[1].HomeTeam.Code == code)
            {

                allGamesData.Add(allMatchData[1].AwayTeam.Code);
                
            }
            else
            {

                allGamesData.Add(allMatchData[1].HomeTeam.Code);

                
            }
            if (allMatchData[2].HomeTeam.Code == code)
            {
                
                    allGamesData.Add(allMatchData[2].AwayTeam.Code);
                
            }
            else
            {
               
                    allGamesData.Add(allMatchData[2].HomeTeam.Code);

                
            }

            return allGamesData;
        }

        public async Task<IList<Match>> SpecificMaleMatchData(string code,string awayCode)
        {
            ApiData apiData = new ApiData();
            IList<Match> match = new List<Match>();

            var data = await apiData.GetAllMaleMatches(code);

            for (int i = 0; i < data.Count(); i++)
            {
                if (data[i].HomeTeam.Code == code && data[i].AwayTeam.Code == awayCode)
                {
                    match.Add(data[i]);
                }
                else if (data[i].HomeTeam.Code == awayCode && data[i].AwayTeam.Code == code)
                {
                    match.Add(data[i]);
                }
            }
            


            return match;


        }


        public async Task<IList<OrderedTeam>> GetSpecificMaleTeamResults(string code)
        {

            ApiData apiData = new ApiData();
            IList<OrderedTeam> orderedTeams = new List<OrderedTeam>();
            IList<OrderedTeam> specificTeam = new List<OrderedTeam>();
            var data = await apiData.GetAllMaleTeamGroupsResults();

            foreach (var item in data)
            {
                orderedTeams.Add(item);
            }

            foreach (var item in orderedTeams)
            {
                if (item.FifaCode == code)
                {
                    specificTeam.Add(item);
                }
            }



            return specificTeam;
            
        }

        public async Task<IList<TeamEvent>> GetMaleGameTeamEvent(string code,string awayCode)
        {

            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<TeamEvent> teamEvents = new List<TeamEvent>();
            var matchData = await match.GetAllMaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            for (int i = 0; i < matchData.Count(); i++)
            {
                if (matches[i].HomeTeam.Code == code && matches[i].AwayTeam.Code == awayCode)
                {
                    matches[i].HomeTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                    matches[i].AwayTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                }
                else if (matches[i].HomeTeam.Code == awayCode && matches[i].AwayTeam.Code == code)
                {
                    matches[i].AwayTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                    matches[i].HomeTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                }


            }

            return teamEvents;

        }





        ///////////FEMALES////////////


        public async Task<IList<StartingEleven>> GetFemalePlayers(string code)
        {

            ApiData match = new ApiData();



            var matchData = await match.GetAllFemaleMatches(code);



            IList<Match> matches = new List<Match>();
            // puni drop down list
            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            IList<StartingEleven> startingEleven = new List<StartingEleven>();

            if (matches[0].HomeTeam.Code == code)
            {

                matches[0].HomeTeamStatistics.StartingEleven.ToList().ForEach(player => startingEleven.Add(player));

            }
            else
            {
                matches[0].AwayTeamStatistics.StartingEleven.ToList().ForEach(player => startingEleven.Add(player));
            }


            return startingEleven;
        }







  

        public  IList<StartingEleven> GetFemaleOffPlayers(string code)
        {

            JsonData match = new JsonData();



            var matchData =  match.GetAllFemaleOffMatches();



            IList<Match> matches = new List<Match>();
            // puni drop down list
            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            IList<StartingEleven> startingEleven = new List<StartingEleven>();


            
            if (matches[0].HomeTeam.Code == code)
            {

                matches[0].HomeTeamStatistics.StartingEleven.ToList().ForEach(player => startingEleven.Add(player));

            }
            else
            {
                matches[0].AwayTeamStatistics.StartingEleven.ToList().ForEach(player => startingEleven.Add(player));
            }


            return startingEleven;
        }




        public async Task<IList<TeamEvent>> GetFemaleEvent(string code)
        {

            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<TeamEvent> teamEvents = new List<TeamEvent>();
            var matchData = await match.GetAllFemaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            if (matches[0].HomeTeam.Code == code)
            {

                matches[0].HomeTeamEvents.ToList().ForEach(e => teamEvents.Add(e));
            }
            else
            {
                matches[0].AwayTeamEvents.ToList().ForEach(e => teamEvents.Add(e));
            }

            return teamEvents;

        }


        public async Task<IList<Team>> GetFemaleHomeTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<Team> homeTeam = new List<Team>();
            var matchData = await match.GetAllFemaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }
            if (matches[0].HomeTeam.Code == code)
            {
                foreach (var item in matches)
                {
                    homeTeam.Add(matches[0].HomeTeam);
                }
            }
            else
            {
                foreach (var item in matches)
                {
                    homeTeam.Add(matches[0].AwayTeam);
                }
            }

            return homeTeam;
        }
        public async Task<IList<Team>> GetFemaleAwayTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<Team> awayTeam = new List<Team>();
            var matchData = await match.GetAllFemaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }
            if (matches[0].HomeTeam.Code == code)
            {
                foreach (var item in matches)
                {
                    awayTeam.Add(matches[0].AwayTeam);
                }
            }
            else
            {
                foreach (var item in matches)
                {
                    awayTeam.Add(matches[0].HomeTeam);
                }
            }

            return awayTeam;
        }

        public async Task<IList<Match>> GetGameDataFemaleForTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> allMatchData = new List<Match>();
            IList<Match> specificMatchData = new List<Match>();
            var matchData = await match.GetAllFemaleMatches(code);

            foreach (var item in matchData)
            {
                allMatchData.Add(item);
            }

            if (allMatchData[0].HomeTeam.Code == code)
            {
                allMatchData.ToList().ForEach(m => specificMatchData.Add(m));
            }
            else if (allMatchData[0].AwayTeam.Code == code)
            {
                allMatchData.ToList().ForEach(m => specificMatchData.Add(m));
            }

            return specificMatchData;

        }

        public async Task<IList<string>> GetAllMatchesForFemaleTeam(string code)
        {
            ApiData match = new ApiData();
            IList<Match> allMatchData = new List<Match>();
            IList<string> allGamesData = new List<string>();

            var matchData = await match.GetAllFemaleMatches(code);

            foreach (var item in matchData)
            {
                allMatchData.Add(item);
            }

            if (allMatchData[0].HomeTeam.Code == code)
            {


                allGamesData.Add(allMatchData[0].AwayTeam.Code);


            }
            else
            {

                allGamesData.Add(allMatchData[0].HomeTeam.Code);


            }
            if (allMatchData[1].HomeTeam.Code == code)
            {

                allGamesData.Add(allMatchData[1].AwayTeam.Code);

            }
            else
            {

                allGamesData.Add(allMatchData[1].HomeTeam.Code);


            }
            if (allMatchData[2].HomeTeam.Code == code)
            {

                allGamesData.Add(allMatchData[2].AwayTeam.Code);

            }
            else
            {

                allGamesData.Add(allMatchData[2].HomeTeam.Code);


            }

            return allGamesData;
        }

        public async Task<IList<Match>> SpecificFemaleMatchData(string code, string awayCode)
        {
            ApiData apiData = new ApiData();
            IList<Match> match = new List<Match>();

            var data = await apiData.GetAllFemaleMatches(code);

            for (int i = 0; i < data.Count(); i++)
            {
                if (data[i].HomeTeam.Code == code && data[i].AwayTeam.Code == awayCode)
                {
                    match.Add(data[i]);
                }
                else if (data[i].HomeTeam.Code == awayCode && data[i].AwayTeam.Code == code)
                {
                    match.Add(data[i]);
                }
            }



            return match;


        }

        public async Task<IList<OrderedTeam>> GetSpecificFemaleTeamResults(string code)
        {

            ApiData apiData = new ApiData();
            IList<OrderedTeam> orderedTeams = new List<OrderedTeam>();
            IList<OrderedTeam> specificTeam = new List<OrderedTeam>();
            var data = await apiData.GetAllFemaleTeamGroupsResults();

            foreach (var item in data)
            {
                orderedTeams.Add(item);
            }

            foreach (var item in orderedTeams)
            {
                if (item.FifaCode == code)
                {
                    specificTeam.Add(item);
                }
            }



            return specificTeam;

        }

        public async Task<IList<TeamEvent>> GetFemaleGameTeamEvent(string code, string awayCode)
        {

            ApiData match = new ApiData();
            IList<Match> matches = new List<Match>();
            IList<TeamEvent> teamEvents = new List<TeamEvent>();
            var matchData = await match.GetAllFemaleMatches(code);

            foreach (var item in matchData)
            {
                matches.Add(item);
            }

            for (int i = 0; i < matchData.Count(); i++)
            {
                if (matches[i].HomeTeam.Code == code && matches[i].AwayTeam.Code == awayCode)
                {
                    matches[i].HomeTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                    matches[i].AwayTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                }
                else if (matches[i].HomeTeam.Code == awayCode && matches[i].AwayTeam.Code == code)
                {
                    matches[i].AwayTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                    matches[i].HomeTeamEvents.ToList().ForEach(t => teamEvents.Add(t));
                }


            }

            return teamEvents;

        }


        ///////FILE SAVING//////////


        public void SavePlayer(IList<StartingEleven> player, string code, string gender)
        {
            if (!Directory.Exists(DIR))
            {
                Directory.CreateDirectory(DIR);
            }
            string path = PATH + code + gender + EXTENSION;
            var data = JsonConvert.SerializeObject(player);
            File.WriteAllText(path, data);


        }

        public IList<StartingEleven> LoadPlayers(string code,string gender)
        {

            string path = PATH + code + gender + EXTENSION;
            if (File.Exists(path))
            {
                
                string json = "";
                StreamReader sr = new StreamReader(path);
                using (sr)
                { json = sr.ReadToEnd(); }
                var data = JsonConvert.DeserializeObject<List<StartingEleven>>(json);
                return data;
            }
            return null;
           

        }

        public void DeleteFile(string code, string gender)
        {
            string path = PATH + code + gender + EXTENSION;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                return;
            }
        }
	    


    }
}








      








