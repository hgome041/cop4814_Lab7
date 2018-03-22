using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//comment to add for step 7 in the lab.

namespace Lab2
{
    public class Game
    {
        public string Team_1 { get; set; }
        public string Team_2 { get; set; }
        public int Team_1_Score { get; set; }
        public int Team_2_Score { get; set; }

        public Game()
        {

        }
        public Game(string Team_1, string Team_2, int Team_1_Score, int Team_2_Score)
        {
            this.Team_1 = Team_1;
            this.Team_1_Score = Team_1_Score;
            this.Team_2 = Team_2;
            this.Team_2_Score = Team_2_Score;
        }

        public override string ToString()
        {
            return String.Format("{0},{3},{1},{3}", Team_1, Team_1_Score, Team_2,Team_2_Score);
        }
    }
}
