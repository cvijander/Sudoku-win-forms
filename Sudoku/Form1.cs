namespace Sudoku
{
    public partial class Form1 : Form
    {
        private TextBox[,] matrica = new TextBox[9, 9];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(620, 330);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrica[i, j] = new TextBox();
                    matrica[i, j].Size = new Size(60, 20);
                    matrica[i, j].Location = new Point(5 + 65 * j, 5 + 25 * i);
                    matrica[i, j].BackColor = Color.LightBlue;
                    matrica[i, j].Tag = i * 10 + j;
                    matrica[i, j].Click += Klikni;
                    this.Controls.Add(matrica[i, j]);
                }
            }
        }

        private void Klikni(object? sender, EventArgs e)
        {
            int tag = (int)(sender as TextBox).Tag;
            int i = tag / 10;
            int j = tag % 10;

            MessageBox.Show("Tag : " + tag);
        }
    }
}