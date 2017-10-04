using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void easyButton_Click(object sender, EventArgs e)
        {
            string heroName;
            string difficultyLevel1;

            heroName = nameInput.Text;
            difficultyLevel1 = "easy";

            outputLabel.Text = "Welcome " + heroName + "!" + "\n" + "Afraid are you? Decided to take the " 
                + difficultyLevel1 + " path?";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            string heroName;

            string difficultyLevel2;

            heroName = nameInput.Text;
            difficultyLevel2 = "medium";

            outputLabel.Text = "Welcome " + heroName + "!" + "\n" + "You are average at best. Enjoy taking your " 
                + difficultyLevel2 + " path.";
        }
    }
}
