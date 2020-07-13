using System.Collections.Generic;

namespace Livescore.Models
{
    public class MatchModel
    {
        public string HomeTeamImageUrl { get; set; }
        public string HomeTeam { get; set; }
        public int HomeTeamGoals { get; set; }
        public string AwayTeamImageUrl { get; set; }
        public string AwayTeam { get; set; }
        public int AwayTeamGoals { get; set; }
        public int Time { get; set; }
        public string Info { get; set; }
        public string Score { get { return $"{HomeTeamGoals} - {AwayTeamGoals}"; } }
        public List<MatchStatModel> Stats { get; set; }
    }
}
