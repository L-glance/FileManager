using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager_2._0
{
    [Serializable]
    internal class GUI
    {
        private static GUI instance;
        private GUI() 
        { }
        public static GUI GetInstance()
        {
            if(instance == null)
                instance = new GUI();
            return instance;
        }
        public static GUI GetInstance(GUI gui)
        {
            if (instance == null)
                instance = gui;
            return instance;
        }
        public int[] rgb = new int[3];
        public string[] Fonts = new string[] { "Segoe UI", "Showcard Gothic", "Snap ITC" };
        public string[] ColorThemeName = new string[] { "Dark", "Dracula", "Cheerful Spring", "Blue Moon", "Blood Moon" };
        public string CurrentFontName;
        public string CurrentColorThemeName;
    }   
}
