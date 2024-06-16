using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaish_Kyrsovaya_second
{
    public partial class Settings : Form
    {
        MainMenu mainMenu;
        MaterialSkin.Controls.MaterialSwitch themeToggle;
        public Settings(MainMenu mainMenu, MaterialSkin.Controls.MaterialSwitch themeToggle)
        {
            InitializeComponent();
            this.mainMenu = mainMenu;
            this.themeToggle = themeToggle;
        }
    }
}
