using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab2
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer ser;
        List<Game> games = new List<Game>();
        string FilePath = @"..\..\games.xml";

        public GameFactory()
        {

        }

        public void CreateGameList()
        {
            Game G = new Game("Hornets", "Bulldogs", 50, 75);
            games.Add(G);

            G = new Game("Bears", "Wildcats", 60, 80);
            games.Add(G);

            G = new Game("Cardinals", "Strikes", 93, 95);
            games.Add(G);

            G = new Game("Fish", "Sharks", 58, 78);
            games.Add(G);

            G = new Game("Ateroids", "Starz", 70, 75);
            games.Add(G);

            G = new Game("Trails", "Hinges", 65, 66);
            games.Add(G);

            //StreamWriter sw = new StreamWriter(FilePath);
            //XmlSerializer ser = new XmlSerializer(games.GetType());
            //ser.Serialize(sw, games);
            //sw.Close();
        }

        public Boolean SerializeGameList()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer ser = new XmlSerializer(games.GetType());
            ser.Serialize(sw, games);
            sw.Close();
            return true;
        }
    }


}
