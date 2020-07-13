using Livescore.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Livescore.ViewModels
{
    public class LivescoreViewModel
    {
        #region Properties
        public ObservableCollection<MatchModel> Matches { get; set; }
        #endregion

        #region Constructors
        public LivescoreViewModel()
        {
            LoadMatches();
        }
        #endregion

        #region Methods
        private void LoadMatches()
        {
            Matches = new ObservableCollection<MatchModel>();

            Matches.Add(new MatchModel()
            {
                HomeTeam = "Toluca",
                HomeTeamImageUrl = "https://1.bp.blogspot.com/-iLYtBXZ-CUA/V4vd4vNF23I/AAAAAAAAFlw/ipSek2rk0r098PP5w7kfFl7Jm3mSTjmrACLcB/s1600/Toluca.png",
                HomeTeamGoals = 4,
                AwayTeam = "Cruz Azul",
                AwayTeamImageUrl = "https://3.bp.blogspot.com/-inU_NRUGJ1Y/V4u82_HFHkI/AAAAAAAAFcI/eiIvhbbA3to6u0H7kA6I0t-0a52Z0sHrwCLcB/s1600/13%2BCruz_Azul_FC%2B%2B%2BLogo%2B512%2Bx%2B512px.png",
                AwayTeamGoals = 2,
                Info = "Cruz Azul no ha ganado de visitante desde enero del 2018.",
                Time = 78,
                Stats = new List<MatchStatModel>()
                {
                    new MatchStatModel()
                    {
                        StatName = "Posesión",
                        HomeValue = "52%",
                        AwayValue = "48%"
                    },
                    new MatchStatModel()
                    {
                        StatName = "Tiros a gol",
                        HomeValue = "9",
                        AwayValue = "7"
                    },
                    new MatchStatModel()
                    {
                        StatName = "Faltas",
                        HomeValue = "6",
                        AwayValue = "1"
                    },
                }
            });

            Matches.Add(new MatchModel()
            {
                HomeTeam = "Tigres",
                HomeTeamImageUrl = "https://1.bp.blogspot.com/-RbchHu6EUmI/XQLQ4KL0fZI/AAAAAAABVSI/kPF-kpPpTsQxXx3SHSz2olgk1Yq6EJ8BwCLcBGAs/s1600/Tigres%2BUANL.png",
                HomeTeamGoals = 1,
                AwayTeam = "Monterrey",
                AwayTeamImageUrl = "https://1.bp.blogspot.com/-nxo2XItzACc/V2Xlu1N066I/AAAAAAAAAnY/8tFptl2HtbwoULhExbdG01ayC0AurLifgCLcB/s1600/Monterrey.png",
                AwayTeamGoals = 1,
                Info = "Tigres y Monterrey han empatado en sus últimos dos enfrentamientos.",
                Time = 52,
                Stats = new List<MatchStatModel>()
                {
                    new MatchStatModel()
                    {
                        StatName = "Posesión",
                        HomeValue = "51%",
                        AwayValue = "49%"
                    },
                    new MatchStatModel()
                    {
                        StatName = "Tiros a gol",
                        HomeValue = "4",
                        AwayValue = "5"
                    },
                    new MatchStatModel()
                    {
                        StatName = "Faltas",
                        HomeValue = "4",
                        AwayValue = "1"
                    },
                }
            });
        }
        #endregion
    }
}