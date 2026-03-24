namespace sport_shop
{
    partial class FormMain
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
            buttonDel = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            panelTop = new Panel();
            labelProfile = new Label();
            buttonExit = new Button();
            panelFill = new Panel();
            dataGridViewProd = new DataGridView();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).BeginInit();
            SuspendLayout();
            // 
            // buttonDel
            // 
            buttonDel.BackColor = Color.FromArgb(67, 97, 238);
            buttonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDel.Location = new Point(260, 12);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(110, 35);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(67, 97, 238);
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(124, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(130, 35);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(67, 97, 238);
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(8, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(248, 249, 250);
            panelTop.Controls.Add(labelProfile);
            panelTop.Controls.Add(buttonExit);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(buttonEdit);
            panelTop.Controls.Add(buttonDel);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(7);
            panelTop.Size = new Size(800, 57);
            panelTop.TabIndex = 2;
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Dock = DockStyle.Right;
            labelProfile.Location = new Point(683, 7);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(0, 15);
            labelProfile.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(67, 97, 238);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExit.Location = new Point(683, 7);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(110, 43);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelFill
            // 
            panelFill.AutoSize = true;
            panelFill.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFill.BackColor = Color.FromArgb(248, 249, 250);
            panelFill.Controls.Add(dataGridViewProd);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 57);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(7);
            panelFill.Size = new Size(800, 393);
            panelFill.TabIndex = 3;
            // 
            // dataGridViewProd
            // 
            dataGridViewProd.AllowUserToAddRows = false;
            dataGridViewProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewProd.BackgroundColor = Color.FromArgb(248, 249, 250);
            dataGridViewProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProd.Dock = DockStyle.Fill;
            dataGridViewProd.Location = new Point(7, 7);
            dataGridViewProd.Name = "dataGridViewProd";
            dataGridViewProd.ReadOnly = true;
            dataGridViewProd.RowHeadersVisible = false;
            dataGridViewProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProd.Size = new Size(786, 379);
            dataGridViewProd.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "FormMain";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelTop;
        private Button buttonDel;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label labelProfile;
        private Button buttonExit;
        private Panel panelFill;
        private DataGridView dataGridViewProd;
    }
}