using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadrovyPanel
{
    public partial class ControlPanel : Form
    {
        Game game;
        int secondsToEndOfEpisode;
        Tuple<string, Keys> currentWord;
        public ControlPanel(Game g)
        {
            InitializeComponent();
            game = g;
            TemperatureTimer.Interval = game.TemperatureTime;
            TemperatureTimer.Enabled = false;
            EpisodeTimer.Interval = 2000;
            EpisodeTimer.Enabled = true;
            SecondTimer.Enabled = true;
            SecondTimer.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TemperatureTimer.Enabled = true;
        }

        private void TemperatureTimer_Tick(object sender, EventArgs e)
        {
            game.GenerateNextKey();
            Password.Text = game.currentKey.Item1;
            DisplayTemperature();
        }

        private void EpisodeTimer_Tick(object sender, EventArgs e)
        {
            if (game.HasNextEpisode())
            {
                MessageBox.Show("Koniec");
                EpisodeTimer.Enabled = false;
                EpisodeTimer.Stop();
                
                return;
            }
            Episode nextEpisode = game.GetNextEpisode();
            secondsToEndOfEpisode = nextEpisode.EpisodeTime;
            EpisodeTimer.Interval = nextEpisode.EpisodeTime;
            Stopwatch.ForeColor = nextEpisode.ColorStopwatch;
            NumberCode.ForeColor = nextEpisode.ColorNumberCode;
            NumberCode.Text = nextEpisode.NumberCode.ToString();
            Password.Text = nextEpisode.Password;
            DisplayElements(nextEpisode);
            Joke.Text = nextEpisode.Joke;
            
        }

        private void SecondTimer_Tick(object sender, EventArgs e)
        {
            secondsToEndOfEpisode-=1000;
            DisplayTime();
            game.ModifyTemperature();
            DisplayTemperature();
        }

        private void DisplayElements(Episode episode)
        {
            string elements = "Stav prvkov v reaktore\n";
            for (int i = 0; i < game.Elements.Count; i++)
            {
                elements += game.Elements[i] + ": " + episode.Values[i] + "\n";
            }
            Elements.Text = elements;
        }
        
        private void DisplayTime()
        {
            Stopwatch.Text = "0:0" + (secondsToEndOfEpisode/60000) + ":" + ((secondsToEndOfEpisode/1000)%60);
        }

        private void DisplayTemperature()
        {
            TemperatureProgress.Value = Math.Max(0,Math.Min(100,(int)game.CurrentTemperature));
            TemperatureLabel.Text = "Teplota: " + game.GetTemperature() + "°";
        }

        private void ControlPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool result = game.ModifyTemperature(e.KeyChar);
            DisplayTemperature();
            if (result) TemperatureTimer_Tick(null,EventArgs.Empty);
        }

        private void TemperatureLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
