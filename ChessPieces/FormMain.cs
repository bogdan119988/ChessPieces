using ChessPieces.Domain.Concrete;
using ChessPieces.Domain.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static ChessPieces.Domain.Dictionary.Dictionary;
using ActionForm = ChessPieces.Domain.Dictionary.Dictionary.ActionForm;

namespace ChessPieces
{
    public partial class FormMain : Form
    {
        private ShapesRepository repository;
        public static string imgPath = Path.Combine(Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\"), "Img");
        public FormMain()
        {
            InitializeComponent();
            repository = new ShapesRepository();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            InsertDataInDataGridView();
        }

        private void InsertDataInDataGridView()
        {
            List<Shapes> data = repository.Get().ToList();
            dataGridView.Columns.Clear();

            DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
            imageCol.Name = "Photo";
            imageCol.HeaderText = "Изображение";
            imageCol.Width = 50;
            imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView.Columns.Add(imageCol);

            dataGridView.DataSource = data;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Img_path"].Visible = false;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells["Img_path"].Value != null)
                {
                    if (File.Exists(Path.Combine(imgPath, row.Cells["Img_path"].Value.ToString())))
                    {
                        FileStream fs = new FileStream(Path.Combine(imgPath, row.Cells["Img_path"].Value.ToString()), FileMode.Open);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                        row.Cells["Photo"].Value = img;
                    }
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ActionForm action = ActionForm.Add;
            Shapes shapes = new Shapes();

            FormEdit formEdit = new FormEdit(action, shapes);

            if(formEdit.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int result = repository.Add(shapes);
                    MessageBox.Show(this, "Количество успешно добавленных записей: " + result.ToString(), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertDataInDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ActionForm action = ActionForm.Edit;
            Shapes shapes = new Shapes();

            if (dataGridView.SelectedRows.Count > 0)
            {
                shapes = dataGridView.SelectedRows[0].DataBoundItem as Shapes;
            }
            else
            {
                MessageBox.Show(this, "Ни одна запись для редактирования не выбрана!");
                return;
            }

            FormEdit formEdit = new FormEdit(action, shapes);

            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int result = repository.Update(shapes);
                    MessageBox.Show(this, "Количество успешно отредактированных записей: " + result.ToString(), "Успешно",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertDataInDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                buttonUpdate_Click(buttonUpdate, null);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();

            if (dataGridView.SelectedRows.Count > 0)
            {
                shapes = dataGridView.SelectedRows[0].DataBoundItem as Shapes;
            }
            else
            {
                MessageBox.Show(this, "Ни одна запись для удаления не выбрана!");
                return;
            }

            DialogResult dialog = MessageBox.Show("Вы действительно хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialog == DialogResult.Yes)
            {
                try
                {
                    int result = repository.Delete(shapes.Id);
                    MessageBox.Show(this, "Количество успешно удаленных записей: " + result.ToString(), "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertDataInDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Удаление изображений, не используемых в БД
        /// </summary>
        private void DeleteOldesImg()
        {
            List<string> thisImg = repository.Get().Select(s => s.Img_path).ToList();

            foreach (string fileDirectory in Directory.GetFiles(imgPath))
            {
                string fileName = Path.GetFileName(fileDirectory);
                if (!thisImg.Contains(fileName))
                {
                    try
                    {
                        System.IO.File.Delete(fileDirectory);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteOldesImg();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Shapes shapes = new Shapes();

            if (dataGridView.SelectedRows.Count > 0)
            {
                shapes = dataGridView.SelectedRows[0].DataBoundItem as Shapes;
            }
            else
            {
                MessageBox.Show(this, "Ни одна запись для просмотра не выбрана!");
                return;
            }

            if(shapes.Points != null && shapes.Points.Count() > 1)
            {
                FormView formView = new FormView(shapes);

                formView.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Недостаточное количество точек для просмотра движениия фигуры! Минимальное количество точек должно быть 2");
                return;
            }
        }
    }
}
