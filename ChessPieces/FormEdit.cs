using ChessPieces.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChessPieces.Domain.Dictionary.Dictionary;

namespace ChessPieces
{
    public partial class FormEdit : Form
    {
        private Shapes shapes;
        private ActionForm action;
        private string imgPath = "";

        public FormEdit(ActionForm _action, Shapes _shapes)
        {
            InitializeComponent();
            shapes = _shapes;
            imgPath = shapes.Img_path;
            action = _action;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            textBoxName.Text = shapes.Name;
            textBoxAbbreviation.Text = shapes.Abbreviation;
            
            if(shapes.Points != null)
            {
                foreach (Domain.Model.Point point in shapes.Points)
                {
                    listBoxCoordinates.Items.Add(point.ToString());
                }
            }

            if (!string.IsNullOrWhiteSpace(shapes.Img_path))
            {
                FileStream fs = new FileStream(Path.Combine(FormMain.imgPath, shapes.Img_path), FileMode.Open);
                Image img = new Bitmap(Image.FromStream(fs), new Size(140, 120));
                fs.Close();
                pictureBoxImg.Image = img;
            }

            switch (action)
            {
                case ActionForm.Add:
                    this.Text = "Добавление";
                    break;
                case ActionForm.Edit:
                    this.Text = "Редактирование";
                    break;
                default:
                    this.Text = "Добавление";
                    break;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                DialogResult = DialogResult.None;
            }
            else
            {
                shapes.Name = textBoxName.Text;
                shapes.Abbreviation = textBoxAbbreviation.Text;

                if (listBoxCoordinates.Items.Count > 0)
                {
                    shapes.Points.Clear();
                    foreach(string item in listBoxCoordinates.Items)
                    {
                        Domain.Model.Point point = new Domain.Model.Point();
                        point.ToPoint(item);
                        shapes.Points.Add(point);
                    }
                }

                if (!string.IsNullOrEmpty(imgPath))
                {
                    SaveImg();
                    shapes.Img_path = Path.GetFileName(imgPath);
                }

                DialogResult = DialogResult.OK;
            }
        }

        private bool isValid()
        {
            errorProvider.Clear();
            bool result = true;

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, "Обязательное поле");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAbbreviation.Text))
            {
                errorProvider.SetError(textBoxAbbreviation, "Обязательное поле");
                result = false;
            }

            if (listBoxCoordinates.Items.Count == 0)
            {
                errorProvider.SetError(listBoxCoordinates, "Обязательное поле");
                result = false;
            }

            if (string.IsNullOrEmpty(imgPath))
            {
                errorProvider.SetError(buttonImgUpload, "Обязательное поле");
                result = false;
            }

            return result;
        }

        private void buttonCoordinatesAdd_Click(object sender, EventArgs e)
        {
            ActionForm action = ActionForm.Add;
            Domain.Model.Point point = new Domain.Model.Point();
            FormCoordinates formCoordinates = new FormCoordinates(action, point);

            if(formCoordinates.ShowDialog() == DialogResult.OK)
            {
                if (ListBoxRecordExists(point) == false)
                {
                    listBoxCoordinates.Items.Add(point.ToString());
                }
                else
                {
                    MessageBox.Show(this, "Такая координата уже существует в списке!");
                }
            }
        }

        private void buttonCoordinatesUpd_Click(object sender, EventArgs e)
        {
            ActionForm action = ActionForm.Edit;
            object selectedItem = listBoxCoordinates.SelectedItem;
            int selectedIndex = listBoxCoordinates.SelectedIndex;
            Domain.Model.Point point = new Domain.Model.Point();
            if(selectedItem == null)
            {
                MessageBox.Show(this, "Ни одна запись для редактирования не выбрана!");
                return;
            }

            point.ToPoint(selectedItem.ToString());
            FormCoordinates formCoordinates = new FormCoordinates(action, point);

            if (formCoordinates.ShowDialog() == DialogResult.OK)
            {
                if (ListBoxRecordExists(point) == false)
                {
                    listBoxCoordinates.Items[selectedIndex] = point.ToString();
                }
                else
                {
                    MessageBox.Show(this, "Такая координата уже существует в списке!");
                }
            }
        }

        private void buttonCoordinatesDel_Click(object sender, EventArgs e)
        {
            object selectedItem = listBoxCoordinates.SelectedItem;
            int selectedIndex = listBoxCoordinates.SelectedIndex;
            if (selectedItem == null)
            {
                MessageBox.Show(this, "Ни одна запись для удаления не выбрана!");
                return;
            }

            listBoxCoordinates.Items.RemoveAt(selectedIndex);
        }

        /// <summary>
        /// Проверка на наличие координаты в списке
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private bool ListBoxRecordExists(Domain.Model.Point item)
        {
            return listBoxCoordinates.Items.Contains(item.ToString());
        }

        private void buttonImgUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();

            OpenFileDialog.Filter = "Изображения|*.jpg;*.png;*.bmp";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = OpenFileDialog.FileName;

                FileStream fs = new FileStream(imgPath, FileMode.Open);
                Image img = new Bitmap(Image.FromStream(fs), new Size(140, 120));
                fs.Close();
                pictureBoxImg.Image = img;
            }
        }

        private void SaveImg()
        {
            ImageFormat format = ImageFormat.Jpeg;

            switch (Path.GetExtension(imgPath))
            {
                case ".jpg":
                    format = ImageFormat.Png;
                    break;
                case ".bmp":
                    format = ImageFormat.Bmp;
                    break;
            }

            if (!Directory.Exists(FormMain.imgPath))
            {
                Directory.CreateDirectory(FormMain.imgPath);
            }

            pictureBoxImg.Image.Save(Path.Combine(FormMain.imgPath, Path.GetFileName(imgPath)), format);
        }
    }
}
