namespace sport_shop
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            buttonEnter = new Button();
            buttonGuest = new Button();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLogin.Location = new Point(166, 147);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(141, 25);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Введите логин:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(126, 175);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(220, 23);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(126, 249);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(220, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPassword.Location = new Point(159, 221);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(154, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Введите пароль:";
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = Color.FromArgb(67, 97, 238);
            buttonEnter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonEnter.Location = new Point(192, 303);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(88, 32);
            buttonEnter.TabIndex = 4;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.FromArgb(67, 97, 238);
            buttonGuest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGuest.Location = new Point(152, 341);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(168, 32);
            buttonGuest.TabIndex = 5;
            buttonGuest.Text = "Войти как гость";
            buttonGuest.UseVisualStyleBackColor = false;
            buttonGuest.Click += buttonGuest_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(186, 48);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 96);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 6;
            pictureBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(457, 394);
            Controls.Add(pictureBoxLogo);
            Controls.Add(buttonGuest);
            Controls.Add(buttonEnter);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(labelLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonEnter;
        private Button buttonGuest;
        private PictureBox pictureBoxLogo;
    }
}