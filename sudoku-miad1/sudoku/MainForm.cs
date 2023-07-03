using System;
using System.Windows.Forms;

namespace sudoku
{
    public partial class MainForm : Form
    {
        private const int CELL_SIZE = 30;
        private const int GRID_SIZE = 9;

        SudokuGrid MainGrid;


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            MainGrid = new SudokuGrid(GRID_SIZE, CELL_SIZE, 20, 40, this);
        }

        
        private void msMainMenuGameNew_Click_1(object sender, EventArgs e)
        {
            MainGrid.ClearField();
            
        }


       
        private void msMainMenuGameSolve_Click(object sender, EventArgs e)
        {
            MainGrid.Solve();
        }

        
        private void msMainMenuExit_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }


        
        private void msMainMenuRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("قانون اول: در هر سطر جدول اعداد ۱ الی ۹ بدون تکرار قرار گیرد\n\nقانون دوم: در هر ستون جدول اعداد ۱ الی ۹ بدون تکرار قرار گیرد\n\nقانون سوم: در هر جدول 3*3 اعداد 1 الی 9 بدون تکرار قرار گیرد", "قوانین");
        }

       
        private void msMainMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("روی مربع مورد نظر کلیک کن\n\nبا کلیک چپ عدد افزایش پیدا میکنه\n\n با کلیک راست عدد کاهش پیدا میکنه\n\n با کلیک وسط عدد پاک میشه", "چجوری عدد وارد کنیم؟");
        }

        private void msMainMenuGame_Click(object sender, EventArgs e)
        {

        }

        private void lblLockedField_Click(object sender, EventArgs e)
        {

        }

        private void msMainMenuFieldClear_Click_1(object sender, EventArgs e)
        {
            MainGrid.ClearField();
        }

        private void msMainMenuHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
