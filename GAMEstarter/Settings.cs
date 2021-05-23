using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;
using System.Drawing;
using Microsoft.Win32;
using System.IO;


namespace GAMEstarter
{
    class Settings
    {
        public Color Ucolor, Dcolor, Fcolor;
        public bool Clock = true, HidePanel = false;
        public string ChildColor = "", ChildStart = "";
        public string txtColors = "0 0 0";

        public List<Color> Ucolors = new List<Color>()
        {
            Color.FromArgb(21,101,192),
            Color.FromArgb(233,47,47),
            Color.FromArgb(255,199,0),
            Color.FromArgb(71,150,93),
            Color.FromArgb(115,113,226),
            Color.FromArgb(47,191,233),
            Color.FromArgb(214,158,233),
            Color.FromArgb(196,238,231),
            Color.FromArgb(255,255,255)
        };

        public List<Color> Dcolors = new List<Color>()
        {
            Color.FromArgb(18,84,171),
            Color.FromArgb(199,33,33),
            Color.FromArgb(222,180,30),
            Color.FromArgb(54,97,61),
            Color.FromArgb(59,85,152),
            Color.FromArgb(67,146,194),
            Color.FromArgb(68,227,084),
            Color.FromArgb(174,193,221),
            Color.FromArgb(203,203,203)
        };

        public List<string> ColorList = new List<string>()
        {
            "#3F51B5", "#009688", "#FF5722", "#607D8B",
            "#FF9800", "#9C27B0", "#2196F3", "#EA676C",
            "#E41A4A", "#5978BB", "#018790", "#B71C46",
            "#00B0AD", "#EA4833", "#EF937E", "#F37521",
            "#A12059", "#8BC240", "#0094BC", "#E4126B",
            "#43B76E", "#7BCFE9",

            //Пали смерью храбрых. Вечная память 
            //"#C7DC5B", "#721D47", "#0E3441", "#126881", "#364D5B",
        };

        public List<Color> Fcolors = new List<Color>()
        {
            Color.WhiteSmoke, SystemColors.ControlText
        };

        public void getSettings()
        {
            FileInfo file1 = new FileInfo("settings.ini");

            try
            {
                using (StreamReader sr = file1.OpenText())
                {
                    ChildColor = sr.ReadLine();
                    ChildStart = sr.ReadLine();
                    Clock = Convert.ToBoolean(sr.ReadLine());
                    HidePanel = Convert.ToBoolean(sr.ReadLine());
                    txtColors = sr.ReadLine();
                    sr.Close();
                }
            }
            catch { setSettings(); }
            setColors();
        }

        public void setSettings()
        {
            StreamWriter sw = new StreamWriter("settings.ini");
            sw.WriteLine(ChildColor);
            sw.WriteLine(ChildStart);
            sw.WriteLine(Clock);
            sw.WriteLine(HidePanel);
            sw.WriteLine(txtColors);
            sw.Close();
        }

        void setColors()
        {
            string[] colors = txtColors.Split(' ');
            Ucolor = Ucolors[Convert.ToInt32(colors[0])];
            Dcolor = Dcolors[Convert.ToInt32(colors[1])];
            Fcolor = Fcolors[Convert.ToInt32(colors[2])];
        }
    }
}
