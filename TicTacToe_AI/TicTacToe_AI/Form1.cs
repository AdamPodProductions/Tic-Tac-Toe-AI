using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_AI
{
    public partial class Form1 : Form
    {
        private string[,] grid;
        private string currentMark = "X";

        private int turns = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            grid = new string[3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    grid[x, y] = "";
                }
            }
        }

        public void Mark(int xPos, int yPos)
        {
            if (grid[xPos, yPos].Equals(""))
            {
                grid[xPos, yPos] = currentMark;
                SwitchMark();
                turns++;
            }
        }

        public void SwitchMark()
        {
            if (currentMark == "X")
            {
                currentMark = "O";
            }
            else
            {
                currentMark = "X";
            }
        }

        private void top_left_Click(object sender, EventArgs e)
        {
            Mark(0, 0);
            top_left.Text = currentMark;
        }

        private void top_center_Click(object sender, EventArgs e)
        {
            Mark(1, 0);
            top_center.Text = currentMark;
        }

        private void top_right_Click(object sender, EventArgs e)
        {
            Mark(2, 0);
            top_right.Text = currentMark;
        }

        private void center_left_Click(object sender, EventArgs e)
        {
            Mark(0, 1);
            center_left.Text = currentMark;
        }

        private void center_center_Click(object sender, EventArgs e)
        {
            Mark(1, 1);
            center_center.Text = currentMark;
        }

        private void center_right_Click(object sender, EventArgs e)
        {
            Mark(2, 1);
            center_right.Text = currentMark;
        }

        private void bottom_left_Click(object sender, EventArgs e)
        {
            Mark(0, 2);
            bottom_left.Text = currentMark;
        }

        private void bottom_center_Click(object sender, EventArgs e)
        {
            Mark(1, 2);
            bottom_center.Text = currentMark;
        }

        private void bottom_right_Click(object sender, EventArgs e)
        {
            Mark(2, 2);
            bottom_right.Text = currentMark;
        }
    }
}
