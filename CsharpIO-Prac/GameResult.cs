using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIO_Prac
{
    public class GameResult
    {
        public DateTime GameDate { get; set; }
        public string TeamName { get; set; }
        public HomeOrAway HomeOrAway { get; set; }
        public int Goals { get; set; }
        public int GoalAttempts { get; set; }
        public int ShotsOnGoal { get; set; }
        public int ShotsOffGoal { get; set; }
        public double PosessionPercent { get; set; }
        public double ConversionRate => (double)Goals / GoalAttempts;
    }

    public enum HomeOrAway
    {
        Home,
        Away
    }
}
