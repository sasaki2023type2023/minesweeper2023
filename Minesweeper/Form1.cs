using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
{private Dictionary<Point, PictureBox> _cellList = new Dictionary<Point, PictureBox>();
}
    public Form1()
    {
        InitializeComponent();
    }
    /// <summary>
    /// イベントのハンドラ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form1_Load(object sender, EventArgs e)
    {
        for (int x = 1; x <= Properties.Settings.Default.NumberOfColumns; x++)
        {
            for (int y = 1; y <= Properties.Settings.Default.NumberOfRows; y++)

            { Point Point = new Point(x, y);

                PictureBox cell = new PictureBox();

                panel1.Controls.add(cell);

                _cellList.Add(Point, cell);


                cell.BackgroundImageLayout = ImageLayout.Stretch;
                cell.Location = Point((x - 1) * 25, (y - 1) * 25);
                cell.Name = $"Cell({x},{y})";
                cell.Size = new Size(25, 25);
                cell.BackgroundImage = Properties.Resources.btn_blank;
            }

        }
    }