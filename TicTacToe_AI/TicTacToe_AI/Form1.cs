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
            gameController.AIChoose();
        }

        private void top_center_Click(object sender, EventArgs e)
        {
            gameController.Mark(1, 0);
            gameController.AIChoose();
        }

        private void top_right_Click(object sender, EventArgs e)
        {
            gameController.Mark(2, 0);
            gameController.AIChoose();
        }

        private void center_left_Click(object sender, EventArgs e)
        {
            gameController.Mark(0, 1);
            gameController.AIChoose();
        }

        private void center_center_Click(object sender, EventArgs e)
        {
            gameController.Mark(1, 1);
            gameController.AIChoose();
        }

        private void center_right_Click(object sender, EventArgs e)
        {
            gameController.Mark(2, 1);
            gameController.AIChoose();
        }

        private void bottom_left_Click(object sender, EventArgs e)
        {
            gameController.Mark(0, 2);
            gameController.AIChoose();
        }

        private void bottom_center_Click(object sender, EventArgs e)
        {
            gameController.Mark(1, 2);
            gameController.AIChoose();
        }

        private void bottom_right_Click(object sender, EventArgs e)
        {
            gameController.Mark(2, 2);
            gameController.AIChoose();
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

        private GridPosition recentGridPosition;

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

                    recentGridPosition = new GridPosition(x, y);

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

        public void AIChoose()
        {
            Random random = new Random();

            WinCombo topRow = new WinCombo();
            topRow.gridPositions.Add(new GridPosition(0, 0));
            topRow.gridPositions.Add(new GridPosition(1, 0));
            topRow.gridPositions.Add(new GridPosition(2, 0));

            WinCombo centerRow = new WinCombo();
            centerRow.gridPositions.Add(new GridPosition(0, 1));
            centerRow.gridPositions.Add(new GridPosition(1, 1));
            centerRow.gridPositions.Add(new GridPosition(2, 1));

            if (topRow.PositionInThisCombo(recentGridPosition))
            {
                GridPosition chosenPosition = new GridPosition();
                chosenPosition = topRow.gridPositions[random.Next(0, topRow.gridPositions.Count)];

                while (grid[chosenPosition.x, chosenPosition.y] != "")
                {
                    if (grid[chosenPosition.x, chosenPosition.y] != "")
                    {
                        topRow.gridPositions.Remove(chosenPosition);
                    }

                    chosenPosition = topRow.gridPositions[random.Next(0, topRow.gridPositions.Count)];
                }

                Mark(chosenPosition.x, chosenPosition.y);
            }
            else if (centerRow.PositionInThisCombo(recentGridPosition))
            {
                GridPosition chosenPosition = new GridPosition();
                chosenPosition = centerRow.gridPositions[random.Next(0, centerRow.gridPositions.Count)];

                while (grid[chosenPosition.x, chosenPosition.y] != "")
                {
                    if (grid[chosenPosition.x, chosenPosition.y] != "")
                    {
                        centerRow.gridPositions.Remove(chosenPosition);
                    }

                    chosenPosition = centerRow.gridPositions[random.Next(0, centerRow.gridPositions.Count)];
                }

                Mark(chosenPosition.x, chosenPosition.y);
            }
        }
    }

    public class GridPosition
    {
        public int x;
        public int y;

        public GridPosition()
        {

        }

        public GridPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class WinCombo
    {
        public List<GridPosition> gridPositions = new List<GridPosition>();

        public bool PositionInThisCombo(GridPosition positionToCheck)
        {
            foreach (GridPosition currentPosition in gridPositions)
            {
                if (positionToCheck.x == currentPosition.x && positionToCheck.y == currentPosition.y)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
