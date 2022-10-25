using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChessPieces.Domain.Dictionary.Dictionary;

namespace ChessPieces
{
    public partial class FormCoordinates : Form
    {
        private ChessPieces.Domain.Model.Point point;
        private ActionForm action;
        public FormCoordinates(ActionForm _action, ChessPieces.Domain.Model.Point _point)
        {
            InitializeComponent();
            point = _point;
            action = _action;
        }

        private void FormCoordinates_Load(object sender, EventArgs e)
        {

            comboBoxX.DataSource = PointX();
            comboBoxY.DataSource = PointY();

            comboBoxX.SelectedItem = point.X == null ? "" : point.X;
            comboBoxY.SelectedItem = point.Y == 0 ? "" : point.Y.ToString();

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
                point.X = comboBoxX.SelectedValue.ToString();
                point.Y = int.Parse(comboBoxY.SelectedValue.ToString());
                DialogResult = DialogResult.OK;
            }
        }

        private bool isValid()
        {
            errorProvider.Clear();
            bool result = true;

            if (string.IsNullOrWhiteSpace(comboBoxX.SelectedValue.ToString()))
            {
                errorProvider.SetError(comboBoxX, "Обязательное поле");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxY.SelectedValue.ToString()))
            {
                errorProvider.SetError(comboBoxY, "Обязательное поле");
                result = false;
            }

            return result;
        }
    }
}
