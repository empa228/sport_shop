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
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDel = new Button();
            panelFill = new Panel();
            dataGridView = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.Controls.Add(buttonAdd);
            flowLayoutPanelTop.Controls.Add(buttonEdit);
            flowLayoutPanelTop.Controls.Add(buttonDel);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(7);
            flowLayoutPanelTop.Size = new Size(800, 56);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(10, 10);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEdit.Location = new Point(126, 10);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(130, 35);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDel.Location = new Point(262, 10);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(110, 35);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridView);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 56);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(7);
            panelFill.Size = new Size(800, 394);
            panelFill.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(7, 7);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(786, 380);
            dataGridView.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormMain";
            Text = "FormMain";
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Panel panelFill;
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDel;
    }
}