using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace JadrovyPanel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Game game = new Game();
            game.LoadGame("game.txt");
            game.LoadDictionary("dictionary.txt");
            game.LoadEpisodes("episodes.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlPanel(game));
        }
    }

    public struct Episode
    {
        public int EpisodeTime;
        public int NumberCode;
        public Color ColorNumberCode;
        public bool IsStopWatchBold;
        public Color ColorStopwatch;
        public string Password;
        public string Joke;
        public int[] Values;

    }

    public class Game
    {
        Random rnd;
        public int TemperatureLowerBound;
        public int TemperatureUpperBound;
        public double CurrentTemperature
        {
            get;
            private set;
        }
        public int TemperatureTime=30000;
        public List<int> EpisodeTime;
        List<Episode> Episodes;
        List<Tuple<string, char>> KeyDictionary;
        public List<string> Elements;
        public Tuple<string, char> currentKey;
        private int currentEpisode=0;

        public int GetTemperature()
        {
            return (int)Math.Round(TemperatureLowerBound + (TemperatureUpperBound - TemperatureLowerBound) * (CurrentTemperature / 100),0);
        }

        public void ModifyTemperature()
        {
            if (CurrentTemperature == 50)
            {
                CurrentTemperature += -5 + (rnd.Next() % 10);
            }
            if ((rnd.Next()%5)<3)
            {
                CurrentTemperature = ((CurrentTemperature - 50) * 1.05) + 50;
            }
            else
            {
                CurrentTemperature = ((CurrentTemperature - 50) * 0.95) + 50;
            }
        }

        public bool ModifyTemperature(char k)
        {

            if (k!=currentKey.Item2)
            {
                CurrentTemperature = ((CurrentTemperature - 50) * 1.05) + 50;
                return false;
            }
            else
            {
                CurrentTemperature = ((CurrentTemperature - 50) * 0.95) + 50;
                return true;
            }
        }

        public bool HasNextEpisode()
        {
            return currentEpisode == Episodes.Count;
        }

        public Episode GetNextEpisode()
        {
            currentEpisode++;
            return Episodes[currentEpisode - 1];
        }

        public void GenerateNextKey()
        {
            currentKey = KeyDictionary[rnd.Next() % KeyDictionary.Count];
        }

        public void LoadDictionary(string dictionaryPath)
        {
            KeyDictionary = new List<Tuple<string, char>>();
            using (StreamReader reader = new StreamReader(dictionaryPath))
            {
                string[] line;
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine().Split(';');
                    KeyDictionary.Add(new Tuple<string, char>(line[0], line[1][0]));
                }
                
                
            }
        }

        public void LoadGame(string gamePath)
        {
            rnd = new Random();
            CurrentTemperature = 50;
            Elements = new List<string>();
            using (StreamReader reader = new StreamReader(gamePath))
            {
                string[] line = reader.ReadLine().Split(';');
                foreach(string el in line)
                {
                    Elements.Add(el);
                }
                line = reader.ReadLine().Split(';');
                TemperatureLowerBound = int.Parse(line[0]);
                TemperatureUpperBound = int.Parse(line[1]);
            }
        }

        public void LoadEpisodes(string scenarioPath)
        {
            
            Episodes = new List<Episode>();
            var lines = File.ReadAllLines(scenarioPath).Select(a => a.Split(';')).ToList();
            
            foreach (var line in lines)
            {
                try
                {
                    if (line.Length!=Elements.Count+7)
                    {
                        MessageBox.Show(string.Format("Nesprávny počat vstupov na riadku {0}", Episodes.Count));
                        break;
                    }
                    Episode ep = new Episode
                    {
                        NumberCode = int.Parse(line[0]),
                        ColorNumberCode = Color.FromName(line[1]),
                        IsStopWatchBold = bool.Parse(line[2]),
                        ColorStopwatch = Color.FromName(line[3]),
                        Password = line[4],
                        Joke = line[5],                        
                        EpisodeTime = int.Parse(line[6])*60,
                        Values = new int[5]
                    };
                    for (int i = 0; i < Elements.Count; i++)
                    {
                        ep.Values[i] = int.Parse(line[7+i]);
                    }

                    Episodes.Add(ep);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(string.Format("Nesprávny vstup na riadku {0}.",Episodes.Count));
                }
                    
                    
            }
            
        }
    }

}
