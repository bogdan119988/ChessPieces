using ChessPieces.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessPieces
{
    public partial class FormView : Form
    {
        private Shapes shapes;
        private int i = 0;
        private string from;
        private string to;

        public FormView(Shapes _shapes)
        {
            InitializeComponent();
            shapes = _shapes;
            initialParameters();
        }

        private void initialParameters()
        {
            from = shapes.Points[0].ToString().Replace(";", "");
            to = from;
            i = 0;
        } 

        private void insertImg()
        {
            if(to != from)
            {
                delImg(from);
            }
            
            Panel panel = this.Controls.Find(to, true)[0] as Panel;

            FileStream fs = new FileStream(Path.Combine(FormMain.imgPath, shapes.Img_path), FileMode.Open);
            Image img = new Bitmap(Image.FromStream(fs), new Size(60, 60));
            fs.Close();

            PictureBox pb = new PictureBox();
            pb.Name = "pb";
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;
            pb.Image = img;
            panel.Controls.Add(pb);
            i++;
            from = to;
            to = i == shapes.Points.Count() ? from : shapes.Points[i].ToString().Replace(";", "");
        }

        private void delImg(string name)
        {
            Panel panelOld = this.Controls.Find(name, true)[0] as Panel;
            PictureBox pictureBoxOld = panelOld.Controls.Find("pb", true)[0] as PictureBox;
            panelOld.Controls.Remove(pictureBoxOld);
        }

        private void buttonStartView_Click(object sender, EventArgs e)
        {
            buttonStartView.Visible = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i < shapes.Points.Count())
            {
                insertImg();
            }
            else
            {
                timer1.Enabled = false;
                buttonStartView.Visible = true;
                delImg(from);
                initialParameters();
            }
        }
    }
}
