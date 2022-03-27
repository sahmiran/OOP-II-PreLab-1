using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_II_Lab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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
            hideSubMenu();
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        
        private void hardBtn_Click(object sender, EventArgs e)
        {
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
            hideSubMenu();
        }
    }
}
