using System;
using System.Collections.Generic;
//step 13 creating another conflict on the file
//adding another comment for step 11
//adding another comment in master
//step 11 new line master
using System.Linq;
//comment to add for step 7 in the lab.
using System.Text;
//adding another comment but for branch_1
//new line step 11 branch_1
using System.Threading.Tasks;


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
