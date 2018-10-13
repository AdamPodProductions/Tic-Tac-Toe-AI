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
        private GameController gameController;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Button[,] buttonGrid = new Button[3, 3];
            buttonGrid[0, 0] = top_left;
            buttonGrid[1, 0] = top_center;
            buttonGrid[2, 0] = top_right;

            buttonGrid[0, 1] = center_left;
            buttonGrid[1, 1] = center_center;
            buttonGrid[2, 1] = center_right;

            buttonGrid[0, 2] = bottom_left;
            buttonGrid[1, 2] = bottom_center;
            buttonGrid[2, 2] = bottom_right;

            gameController = new GameController(buttonGrid, win_label);
        }

        private void top_left_Click(object sender, EventArgs e)
        {
            gameController.Mark(0, 0);
        }

        private void top_center_Click(object sender, EventArgs e)
        {
            gameController.Mark(1, 0);
        }

        private void top_right_Click(object sender, EventArgs e)
        {
            gameController.Mark(2, 0);
        }

        private void center_left_Click(object sender, EventArgs e)
        {
            gameController.Mark(0, 1);
        }

        private void center_center_Click(object sender, EventArgs e)
        {
            gameController.Mark(1, 1);
        }

        private void center_right_Click(object sender, EventArgs e)
        {
            gameController.Mark(2, 1);
        }

        private void bottom_left_Click(object sender, EventArgs e)
        {
            gameController.Mark(0, 2);
        }

        private void bottom_center_Click(object sender, EventArgs e)
        {
            gameController.Mark(1, 2);
        }

        private void bottom_right_Click(object sender, EventArgs e)
        {
            gameController.Mark(2, 2);
        }
    }

    public class GameController
    {
        private string[,] grid;
        private string currentMark = "X";

        private int turns = 1;
        private bool playing = true;

        private Button[,] buttonGrid;
        private Label win_label;

        public GameController(Button[,] buttons, Label winLabel)
        {
            grid = new string[3, 3];
            buttonGrid = buttons;
            win_label = winLabel;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    grid[x, y] = "";
                }
            }
        }

        public void Mark(int x, int y)
        {
            if (playing)
            {
                if (grid[x, y].Equals(""))
                {
                    grid[x, y] = currentMark;
                    buttonGrid[x, y].Text = currentMark;

                    CheckForWin();
                    SwitchMark();

                    turns++;
                }
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

        public void CheckForWin()
        {
            //All horizontal wins
            for (int y = 0; y < 3; y++)
            {
                if (grid[0, y] != "" && grid[0, y] == grid[1, y] && grid[1, y] == grid[2, y])
                {
                    Win(currentMark);
                    return;
                }
            }

            //All vertical wins
            for (int x = 0; x < 3; x++)
            {
                if (grid[x, 0] != "" && grid[x, 0] == grid[x, 1] && grid[x, 1] == grid[x, 2])
                {
                    Win(currentMark);
                    return;
                }
            }

            //All diagonal wins
            if (grid[0, 0] != "" && grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2])
            {
                Win(currentMark);
                return;
            }
            if (grid[0, 2] != "" && grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0])
            {
                Win(currentMark);
                return;
            }

            if (turns == 9)
            {
                win_label.Text = "Draw";
                playing = false;
            }
        }

        private void Win(string mark)
        {
            win_label.Text = currentMark + " wins!";
            playing = false;
        }
    }
}
