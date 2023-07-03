using System;
using System.Drawing;
using System.Windows.Forms;

namespace sudoku
{
    class SudokuGrid
    {
        private int GridSize;
        private int BoxSize;
        private int CellSize;
        private Label[,] Field;
        private bool GridIsSolved = false;


        public SudokuGrid(int size, int cellSize, int startX, int startY, MainForm parent)
        {
            GridSize = size;
            CellSize = cellSize;
            Field = new Label[GridSize, GridSize];

           
            int horizontal = startX;
            int vertical = startY;

           
            BoxSize = size / (int)Math.Sqrt(size);


            for (int i = 0; i < GridSize; i++)
            {

                
                if (i % BoxSize == 0)
                    vertical += 1;

               
                horizontal = startX;

                for (int j = 0; j < GridSize; j++)
                {

                  
                    if (j % BoxSize == 0)
                        horizontal += 1;

                   
                    Field[i, j] = new Label()
                    {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point(horizontal, vertical),
                        BorderStyle = BorderStyle.FixedSingle,
                        ForeColor = Color.Black,
                        BackColor = Color.White,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Tag = new GridLocation(i, j)
                    };

               
                    Field[i, j].Click += OnFieldClick;

                    
                    parent.Controls.Add(Field[i, j]);

                    
                    horizontal += cellSize - 1;
                }

              
                vertical += cellSize - 1;
            }

            
            parent.Size = new Size(horizontal + 2 * startX, vertical + startY + CellSize / 2);
        }


       
        internal class GridLocation
        {
            public readonly int i;
            public readonly int j;

            public GridLocation(int i, int j)
            {
                this.i = i;
                this.j = j;
            }
        }


        private void OnFieldClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            if (me.Button == MouseButtons.Left)
                OnLeftClick(sender, e);
            else if (me.Button == MouseButtons.Right)
                OnRightClick(sender, e);
            else if (me.Button == MouseButtons.Middle)
                OnMiddleClick(sender, e);
            else return;

            if (HasNoConflictsAt(sender) == false)
                ((Label)sender).BackColor = Color.Red;
            else
                ((Label)sender).BackColor = Color.White;
        }

        private void OnLeftClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l.Text == "")
                l.Text = "1";
            else if (l.Text == GridSize.ToString())
                l.Text = "1";
            else
                l.Text = (int.Parse(l.Text) + 1).ToString();
        }

        private void OnRightClick(object sender, EventArgs e)
        {
            Label l = sender as Label;

            if (l.Text == "")
                l.Text = GridSize.ToString();
            else if (l.Text == "1")
                l.Text = GridSize.ToString();
            else
                l.Text = (int.Parse(l.Text) - 1).ToString();
        }

        private void OnMiddleClick(object sender, EventArgs e)
        {
            ((Label)sender).Text = "";
        }

        private bool HasNoConflictsAt(object sender)
        {
            Label pressedLabel = sender as Label;

            
            if (pressedLabel.Text == "")
                return true;

           
            GridLocation index = (GridLocation)pressedLabel.Tag;
            int x = index.i;
            int y = index.j;

          
            for (int i = 0; i < GridSize; i++)
                if (i != y && Field[x, i].Text == pressedLabel.Text)
                    return false;

            
            for (int i = 0; i < GridSize; i++)
                if (i != x && Field[i, y].Text == pressedLabel.Text)
                    return false;

           
            int sqStartX = x - x % BoxSize;
            int sqEndX = sqStartX + BoxSize;
            int sqStartY = y - y % BoxSize;
            int sqEndY = sqStartY + BoxSize;
            for (int i = sqStartX; i < sqEndX; i++)
                for (int j = sqStartY; j < sqEndY; j++)
                    if (i != x && j != y && Field[i, j].Text == pressedLabel.Text)
                        return false;

            return true;
        }

        public bool HasNoConflicts()
        {
            foreach (Label i in Field)
                if (HasNoConflictsAt(i) == false)
                    return false;

            return true;
        }

        public void Solve()
        {
            if (GridIsSolved)
                return;

            if (HasNoConflicts())
                SolveGrid(0, 0);
            else
                MessageBox.Show("!اعداد توی جدول باهم تداخل دارن ", "وای");
        }

        private void SolveGrid(int row, int col)
        {
           
            if (row == GridSize)
            {
                GridIsSolved = true;
                return;
            }

          
            int nextRow, nextCol;

            
            if (col == GridSize - 1)
            {
                nextRow = row + 1;
                nextCol = 0;
            }
            else
            {
                nextRow = row;
                nextCol = col + 1;
            }

           
            if (Field[row, col].Text != "")
                SolveGrid(nextRow, nextCol);
            else
            {
                
                for (int candidate = 1; candidate <= GridSize; candidate++)
                {

                    Field[row, col].Text = candidate.ToString();
                    if (HasNoConflictsAt(Field[row, col]))
                    {
                        SolveGrid(nextRow, nextCol);
                        if (GridIsSolved)
                            return;
                    }
                    Field[row, col].Text = "";
                }
            }
        }



        public void ClearField()
        {
            foreach (Label cell in Field)
                if (cell.ForeColor == Color.Black)
                {
                    cell.Text = "";
                    cell.BackColor = Color.White;
                }

            GridIsSolved = false;
        }

        private void UpdateFieldColors()
        {
            foreach (Label cell in Field)
            {
                if (cell.Text == "")
                    cell.ForeColor = Color.Black;
                else
                    cell.ForeColor = Color.Red;

                cell.BackColor = Color.White;
            }
        }


    }
}
