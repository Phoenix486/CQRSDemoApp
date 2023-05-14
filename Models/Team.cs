using System.Text.RegularExpressions;

namespace CQRSDemoApp.Models
{
    public class Team
    {
        public Team()
        {
            MatchTeam1Navigations = new HashSet<Match>();
            MatchTeam2Navigations = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Match> MatchTeam1Navigations { get; set; }
        public virtual ICollection<Match> MatchTeam2Navigations { get; set; }
    }
}
