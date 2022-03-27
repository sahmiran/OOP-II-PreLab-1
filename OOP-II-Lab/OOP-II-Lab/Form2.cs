using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_II_Lab.Properties;

namespace OOP_II_Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            selectedDifficultyLabel.Text = Settings.Default["Difficulty"].ToString();
            selectedShapeLabel.Text = Settings.Default["Shape"].ToString();
        }

        private void hideSubMenu()
        {
            if (difficultyPanel.Visible == true)
            {
                difficultyPanel.Visible = false;
            }
            if (shapePanel.Visible == true)
            {
                shapePanel.Visible = false;
            }
            if (customSubPanel.Visible == true)
            {
                customSubPanel.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void easyBtn_Click(object sender, EventArgs e)
        {
            Settings.Default["Difficulty"] = easyBtn.Text;
            Settings.Default.Save();
            selectedDifficultyLabel.Text = easyBtn.Text;
            hideSubMenu();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            Settings.Default["Difficulty"] = normalBtn.Text;
            Settings.Default.Save();
            selectedDifficultyLabel.Text = normalBtn.Text;
            hideSubMenu();
        }

        
        private void hardBtn_Click(object sender, EventArgs e)
        {
            Settings.Default["Difficulty"] = hardBtn.Text;
            Settings.Default.Save();
            selectedDifficultyLabel.Text = hardBtn.Text;
            hideSubMenu();
        }

        private void customBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(customSubPanel);
        }

        private void difficultyBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(difficultyPanel);
        }

        private void shapeBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(shapePanel);
        }

        private void customSaveBtn_Click(object sender, EventArgs e)
        {
            string tempShape = "";
            tempShape = xValueText.Text.ToString() + " x " + yValueText.Text.ToString();
            Settings.Default["Difficulty"] = tempShape;
            Settings.Default.Save();
            selectedDifficultyLabel.Text = tempShape;
            hideSubMenu();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void saveoptionBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void shapeSaveBtn_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (squareCheckBox.Checked == true)
            {
                temp = temp + squareCheckBox.Text.ToString() + " ";
            }

            if (triangleCheckBox.Checked == true)
            {
                temp = temp + triangleCheckBox.Text.ToString() + " ";
            }

            if (roundCheckBox.Checked == true)
            {
                temp = temp + roundCheckBox.Text.ToString() + " ";
            }

            Settings.Default["Shape"] = temp;
            Settings.Default.Save();
            selectedShapeLabel.Text = temp;
        }
    }
}
