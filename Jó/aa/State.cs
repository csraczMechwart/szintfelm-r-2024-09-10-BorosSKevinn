using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace aa
{
    public struct State
    {
        public static string FILENAME = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "meccs.txt");
        public static void LoadData()
        {
            string[] lines = File.ReadAllLines(FILENAME);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                Round round = new Round();
                round.Turn = int.Parse(parts[0]);
                round.HomeTeam.Name = parts[1];
                round.HomeTeam.Goals = int.Parse(parts[2]);
                round.HomeTeam.HalfTimeGoals = int.Parse(parts[3]);
                round.AwayTeam.Name = parts[4];
                round.AwayTeam.Goals = int.Parse(parts[5]);
                round.AwayTeam.HalfTimeGoals = int.Parse(parts[6]);
                Main.Rounds.Add(round);
            }
        }
    }
}
