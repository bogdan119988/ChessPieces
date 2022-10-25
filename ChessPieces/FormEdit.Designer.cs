namespace ChessPieces
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAbbreviation = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.labelImg = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAbbreviation = new System.Windows.Forms.TextBox();
            this.panelCoordinates = new System.Windows.Forms.Panel();
            this.panelCoordinatesFill = new System.Windows.Forms.Panel();
            this.groupBoxCoordinatesButtons = new System.Windows.Forms.GroupBox();
            this.buttonCoordinatesDel = new System.Windows.Forms.Button();
            this.buttonCoordinatesUpd = new System.Windows.Forms.Button();
            this.buttonCoordinatesAdd = new System.Windows.Forms.Button();
            this.panelCoordinatesLeft = new System.Windows.Forms.Panel();
            this.listBoxCoordinates = new System.Windows.Forms.ListBox();
            this.panelImg = new System.Windows.Forms.Panel();
            this.buttonImgUpload = new System.Windows.Forms.Button();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBottom.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelCoordinates.SuspendLayout();
            this.panelCoordinatesFill.SuspendLayout();
            this.groupBoxCoordinatesButtons.SuspendLayout();
            this.panelCoordinatesLeft.SuspendLayout();
            this.panelImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelButton);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 542);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(552, 81);
            this.panelBottom.TabIndex = 0;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonCancel);
            this.panelButton.Controls.Add(this.buttonSave);
            this.panelButton.Location = new System.Drawing.Point(245, 3);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(5);
            this.panelButton.Size = new System.Drawing.Size(213, 72);
            this.panelButton.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(111, 21);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(18, 21);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 35);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.tableLayoutPanel);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(0, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(552, 542);
            this.panelCenter.TabIndex = 1;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelAbbreviation, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelCoordinates, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelImg, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxAbbreviation, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.panelCoordinates, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.panelImg, 1, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(552, 542);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(4, 12);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(157, 30);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Наименование фигуры";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAbbreviation
            // 
            this.labelAbbreviation.AutoSize = true;
            this.labelAbbreviation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAbbreviation.Location = new System.Drawing.Point(4, 66);
            this.labelAbbreviation.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.labelAbbreviation.Name = "labelAbbreviation";
            this.labelAbbreviation.Size = new System.Drawing.Size(157, 30);
            this.labelAbbreviation.TabIndex = 2;
            this.labelAbbreviation.Text = "Аббревиатура";
            this.labelAbbreviation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCoordinates.Location = new System.Drawing.Point(4, 120);
            this.labelCoordinates.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(157, 138);
            this.labelCoordinates.TabIndex = 4;
            this.labelCoordinates.Text = "Координаты";
            this.labelCoordinates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelImg
            // 
            this.labelImg.AutoSize = true;
            this.labelImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImg.Location = new System.Drawing.Point(4, 282);
            this.labelImg.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.labelImg.Name = "labelImg";
            this.labelImg.Size = new System.Drawing.Size(157, 248);
            this.labelImg.TabIndex = 3;
            this.labelImg.Text = "Изображение";
            this.labelImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(169, 20);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 20, 40, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(343, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAbbreviation
            // 
            this.textBoxAbbreviation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAbbreviation.Location = new System.Drawing.Point(169, 74);
            this.textBoxAbbreviation.Margin = new System.Windows.Forms.Padding(4, 20, 40, 20);
            this.textBoxAbbreviation.Name = "textBoxAbbreviation";
            this.textBoxAbbreviation.Size = new System.Drawing.Size(343, 22);
            this.textBoxAbbreviation.TabIndex = 5;
            // 
            // panelCoordinates
            // 
            this.panelCoordinates.Controls.Add(this.panelCoordinatesFill);
            this.panelCoordinates.Controls.Add(this.panelCoordinatesLeft);
            this.panelCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoordinates.Location = new System.Drawing.Point(168, 111);
            this.panelCoordinates.Name = "panelCoordinates";
            this.panelCoordinates.Size = new System.Drawing.Size(381, 156);
            this.panelCoordinates.TabIndex = 6;
            // 
            // panelCoordinatesFill
            // 
            this.panelCoordinatesFill.Controls.Add(this.groupBoxCoordinatesButtons);
            this.panelCoordinatesFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCoordinatesFill.Location = new System.Drawing.Point(231, 0);
            this.panelCoordinatesFill.Name = "panelCoordinatesFill";
            this.panelCoordinatesFill.Padding = new System.Windows.Forms.Padding(5);
            this.panelCoordinatesFill.Size = new System.Drawing.Size(150, 156);
            this.panelCoordinatesFill.TabIndex = 2;
            // 
            // groupBoxCoordinatesButtons
            // 
            this.groupBoxCoordinatesButtons.Controls.Add(this.buttonCoordinatesDel);
            this.groupBoxCoordinatesButtons.Controls.Add(this.buttonCoordinatesUpd);
            this.groupBoxCoordinatesButtons.Controls.Add(this.buttonCoordinatesAdd);
            this.groupBoxCoordinatesButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCoordinatesButtons.Location = new System.Drawing.Point(5, 5);
            this.groupBoxCoordinatesButtons.Name = "groupBoxCoordinatesButtons";
            this.groupBoxCoordinatesButtons.Size = new System.Drawing.Size(140, 146);
            this.groupBoxCoordinatesButtons.TabIndex = 0;
            this.groupBoxCoordinatesButtons.TabStop = false;
            this.groupBoxCoordinatesButtons.Text = "Действия";
            // 
            // buttonCoordinatesDel
            // 
            this.buttonCoordinatesDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCoordinatesDel.Location = new System.Drawing.Point(5, 97);
            this.buttonCoordinatesDel.Name = "buttonCoordinatesDel";
            this.buttonCoordinatesDel.Size = new System.Drawing.Size(127, 35);
            this.buttonCoordinatesDel.TabIndex = 2;
            this.buttonCoordinatesDel.Text = "Удалить";
            this.buttonCoordinatesDel.UseVisualStyleBackColor = true;
            this.buttonCoordinatesDel.Click += new System.EventHandler(this.buttonCoordinatesDel_Click);
            // 
            // buttonCoordinatesUpd
            // 
            this.buttonCoordinatesUpd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCoordinatesUpd.Location = new System.Drawing.Point(5, 59);
            this.buttonCoordinatesUpd.Name = "buttonCoordinatesUpd";
            this.buttonCoordinatesUpd.Size = new System.Drawing.Size(127, 35);
            this.buttonCoordinatesUpd.TabIndex = 1;
            this.buttonCoordinatesUpd.Text = "Редактировать";
            this.buttonCoordinatesUpd.UseVisualStyleBackColor = true;
            this.buttonCoordinatesUpd.Click += new System.EventHandler(this.buttonCoordinatesUpd_Click);
            // 
            // buttonCoordinatesAdd
            // 
            this.buttonCoordinatesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCoordinatesAdd.Location = new System.Drawing.Point(5, 21);
            this.buttonCoordinatesAdd.Name = "buttonCoordinatesAdd";
            this.buttonCoordinatesAdd.Size = new System.Drawing.Size(127, 35);
            this.buttonCoordinatesAdd.TabIndex = 0;
            this.buttonCoordinatesAdd.Text = "Добавить";
            this.buttonCoordinatesAdd.UseVisualStyleBackColor = true;
            this.buttonCoordinatesAdd.Click += new System.EventHandler(this.buttonCoordinatesAdd_Click);
            // 
            // panelCoordinatesLeft
            // 
            this.panelCoordinatesLeft.Controls.Add(this.listBoxCoordinates);
            this.panelCoordinatesLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCoordinatesLeft.Location = new System.Drawing.Point(0, 0);
            this.panelCoordinatesLeft.Name = "panelCoordinatesLeft";
            this.panelCoordinatesLeft.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.panelCoordinatesLeft.Size = new System.Drawing.Size(231, 156);
            this.panelCoordinatesLeft.TabIndex = 1;
            // 
            // listBoxCoordinates
            // 
            this.listBoxCoordinates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCoordinates.FormattingEnabled = true;
            this.listBoxCoordinates.ItemHeight = 16;
            this.listBoxCoordinates.Location = new System.Drawing.Point(0, 0);
            this.listBoxCoordinates.Name = "listBoxCoordinates";
            this.listBoxCoordinates.Size = new System.Drawing.Size(211, 156);
            this.listBoxCoordinates.TabIndex = 0;
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.buttonImgUpload);
            this.panelImg.Controls.Add(this.pictureBoxImg);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImg.Location = new System.Drawing.Point(168, 273);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(381, 266);
            this.panelImg.TabIndex = 7;
            // 
            // buttonImgUpload
            // 
            this.buttonImgUpload.Location = new System.Drawing.Point(231, 222);
            this.buttonImgUpload.Name = "buttonImgUpload";
            this.buttonImgUpload.Size = new System.Drawing.Size(130, 35);
            this.buttonImgUpload.TabIndex = 1;
            this.buttonImgUpload.Text = "Загрузить";
            this.buttonImgUpload.UseVisualStyleBackColor = true;
            this.buttonImgUpload.Click += new System.EventHandler(this.buttonImgUpload_Click);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Location = new System.Drawing.Point(20, 66);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(211, 191);
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 623);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBottom);
            this.MaximumSize = new System.Drawing.Size(1000, 670);
            this.MinimumSize = new System.Drawing.Size(570, 670);
            this.Name = "FormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.panelBottom.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelCoordinates.ResumeLayout(false);
            this.panelCoordinatesFill.ResumeLayout(false);
            this.groupBoxCoordinatesButtons.ResumeLayout(false);
            this.panelCoordinatesLeft.ResumeLayout(false);
            this.panelImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAbbreviation;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Label labelImg;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAbbreviation;
        private System.Windows.Forms.Panel panelCoordinates;
        private System.Windows.Forms.Panel panelCoordinatesLeft;
        private System.Windows.Forms.ListBox listBoxCoordinates;
        private System.Windows.Forms.Panel panelCoordinatesFill;
        private System.Windows.Forms.GroupBox groupBoxCoordinatesButtons;
        private System.Windows.Forms.Button buttonCoordinatesDel;
        private System.Windows.Forms.Button buttonCoordinatesUpd;
        private System.Windows.Forms.Button buttonCoordinatesAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelImg;
        private System.Windows.Forms.Button buttonImgUpload;
        private System.Windows.Forms.PictureBox pictureBoxImg;
    }
}