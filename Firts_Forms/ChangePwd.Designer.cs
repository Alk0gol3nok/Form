
namespace Firts_Forms
{
    partial class ChangePwd
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
            this.mainPannel2 = new System.Windows.Forms.Panel();
            this.active_pwd = new System.Windows.Forms.Label();
            this.change_pwd = new System.Windows.Forms.TextBox();
            this.sbros_pwd_pannel = new System.Windows.Forms.Panel();
            this.active_pwd_button = new System.Windows.Forms.Button();
            this.new_pass_active = new System.Windows.Forms.TextBox();
            this.new_pwd_active = new System.Windows.Forms.Label();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.new_pwd = new System.Windows.Forms.Label();
            this.sm_pwd_button = new System.Windows.Forms.Button();
            this.sm_pwd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nazad_glav_img = new System.Windows.Forms.PictureBox();
            this.nazadRegister_img = new System.Windows.Forms.PictureBox();
            this.nazadLogin_img = new System.Windows.Forms.PictureBox();
            this.nazad_register_field = new System.Windows.Forms.TextBox();
            this.nazad_login_field = new System.Windows.Forms.TextBox();
            this.User_checker_field = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.mainPannel = new System.Windows.Forms.Label();
            this.mainPannel2.SuspendLayout();
            this.sbros_pwd_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nazad_glav_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazadRegister_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazadLogin_img)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPannel2
            // 
            this.mainPannel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(75)))), ((int)(((byte)(158)))));
            this.mainPannel2.Controls.Add(this.active_pwd);
            this.mainPannel2.Controls.Add(this.change_pwd);
            this.mainPannel2.Controls.Add(this.sbros_pwd_pannel);
            this.mainPannel2.Controls.Add(this.sm_pwd_button);
            this.mainPannel2.Controls.Add(this.sm_pwd);
            this.mainPannel2.Controls.Add(this.textBox1);
            this.mainPannel2.Controls.Add(this.nazad_glav_img);
            this.mainPannel2.Controls.Add(this.nazadRegister_img);
            this.mainPannel2.Controls.Add(this.nazadLogin_img);
            this.mainPannel2.Controls.Add(this.nazad_register_field);
            this.mainPannel2.Controls.Add(this.nazad_login_field);
            this.mainPannel2.Controls.Add(this.User_checker_field);
            this.mainPannel2.Controls.Add(this.loginField);
            this.mainPannel2.Controls.Add(this.panel3);
            this.mainPannel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainPannel2.Location = new System.Drawing.Point(-4, -1);
            this.mainPannel2.Name = "mainPannel2";
            this.mainPannel2.Size = new System.Drawing.Size(808, 453);
            this.mainPannel2.TabIndex = 2;
            this.mainPannel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPannel2_MouseDown);
            this.mainPannel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPannel2_MouseMove);
            // 
            // active_pwd
            // 
            this.active_pwd.AutoSize = true;
            this.active_pwd.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.active_pwd.Location = new System.Drawing.Point(383, 214);
            this.active_pwd.Name = "active_pwd";
            this.active_pwd.Size = new System.Drawing.Size(207, 18);
            this.active_pwd.TabIndex = 27;
            this.active_pwd.Text = "Введите активный пароль ->";
            // 
            // change_pwd
            // 
            this.change_pwd.Location = new System.Drawing.Point(596, 212);
            this.change_pwd.Name = "change_pwd";
            this.change_pwd.Size = new System.Drawing.Size(173, 20);
            this.change_pwd.TabIndex = 26;
            // 
            // sbros_pwd_pannel
            // 
            this.sbros_pwd_pannel.Controls.Add(this.active_pwd_button);
            this.sbros_pwd_pannel.Controls.Add(this.new_pass_active);
            this.sbros_pwd_pannel.Controls.Add(this.new_pwd_active);
            this.sbros_pwd_pannel.Controls.Add(this.new_pass);
            this.sbros_pwd_pannel.Controls.Add(this.new_pwd);
            this.sbros_pwd_pannel.Location = new System.Drawing.Point(11, 164);
            this.sbros_pwd_pannel.Name = "sbros_pwd_pannel";
            this.sbros_pwd_pannel.Size = new System.Drawing.Size(282, 276);
            this.sbros_pwd_pannel.TabIndex = 25;
           
            // 
            // active_pwd_button
            // 
            this.active_pwd_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.active_pwd_button.FlatAppearance.BorderSize = 0;
            this.active_pwd_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.active_pwd_button.Location = new System.Drawing.Point(101, 214);
            this.active_pwd_button.Name = "active_pwd_button";
            this.active_pwd_button.Size = new System.Drawing.Size(84, 23);
            this.active_pwd_button.TabIndex = 28;
            this.active_pwd_button.Text = "Подтвердить";
            this.active_pwd_button.UseVisualStyleBackColor = true;
            this.active_pwd_button.Click += new System.EventHandler(this.active_pwd_button_Click);
            // 
            // new_pass_active
            // 
            this.new_pass_active.Location = new System.Drawing.Point(48, 138);
            this.new_pass_active.Name = "new_pass_active";
            this.new_pass_active.Size = new System.Drawing.Size(173, 20);
            this.new_pass_active.TabIndex = 30;
            // 
            // new_pwd_active
            // 
            this.new_pwd_active.AutoSize = true;
            this.new_pwd_active.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_pwd_active.Location = new System.Drawing.Point(45, 103);
            this.new_pwd_active.Name = "new_pwd_active";
            this.new_pwd_active.Size = new System.Drawing.Size(200, 18);
            this.new_pwd_active.TabIndex = 29;
            this.new_pwd_active.Text = "Подтвердите новый пароль ";
            // 
            // new_pass
            // 
            this.new_pass.Location = new System.Drawing.Point(48, 50);
            this.new_pass.Name = "new_pass";
            this.new_pass.Size = new System.Drawing.Size(173, 20);
            this.new_pass.TabIndex = 28;
            // 
            // new_pwd
            // 
            this.new_pwd.AutoSize = true;
            this.new_pwd.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_pwd.Location = new System.Drawing.Point(45, 13);
            this.new_pwd.Name = "new_pwd";
            this.new_pwd.Size = new System.Drawing.Size(160, 18);
            this.new_pwd.TabIndex = 28;
            this.new_pwd.Text = "Введите новый пароль";
            // 
            // sm_pwd_button
            // 
            this.sm_pwd_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sm_pwd_button.FlatAppearance.BorderSize = 0;
            this.sm_pwd_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sm_pwd_button.Location = new System.Drawing.Point(552, 250);
            this.sm_pwd_button.Name = "sm_pwd_button";
            this.sm_pwd_button.Size = new System.Drawing.Size(75, 23);
            this.sm_pwd_button.TabIndex = 24;
            this.sm_pwd_button.Text = "Сброс";
            this.sm_pwd_button.UseVisualStyleBackColor = true;
            this.sm_pwd_button.Click += new System.EventHandler(this.sm_pwd_button_Click);
            this.sm_pwd_button.MouseEnter += new System.EventHandler(this.sm_pwd_button_MouseEnter);
            this.sm_pwd_button.MouseLeave += new System.EventHandler(this.sm_pwd_button_MouseLeave);
            // 
            // sm_pwd
            // 
            this.sm_pwd.AutoSize = true;
            this.sm_pwd.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sm_pwd.Location = new System.Drawing.Point(480, 164);
            this.sm_pwd.Name = "sm_pwd";
            this.sm_pwd.Size = new System.Drawing.Size(217, 31);
            this.sm_pwd.TabIndex = 23;
            this.sm_pwd.Text = "Сменить пароль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 419);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Вернуться на глав.экран";
            // 
            // nazad_glav_img
            // 
            this.nazad_glav_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazad_glav_img.Image = global::Firts_Forms.Properties.Resources._return;
            this.nazad_glav_img.Location = new System.Drawing.Point(349, 350);
            this.nazad_glav_img.Name = "nazad_glav_img";
            this.nazad_glav_img.Size = new System.Drawing.Size(64, 64);
            this.nazad_glav_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nazad_glav_img.TabIndex = 21;
            this.nazad_glav_img.TabStop = false;
            this.nazad_glav_img.DoubleClick += new System.EventHandler(this.nazad_glav_img_DoubleClick);
            // 
            // nazadRegister_img
            // 
            this.nazadRegister_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazadRegister_img.Image = global::Firts_Forms.Properties.Resources._return;
            this.nazadRegister_img.Location = new System.Drawing.Point(523, 350);
            this.nazadRegister_img.Name = "nazadRegister_img";
            this.nazadRegister_img.Size = new System.Drawing.Size(64, 64);
            this.nazadRegister_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nazadRegister_img.TabIndex = 20;
            this.nazadRegister_img.TabStop = false;
            this.nazadRegister_img.DoubleClick += new System.EventHandler(this.nazadRegister_img_DoubleClick);
            // 
            // nazadLogin_img
            // 
            this.nazadLogin_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nazadLogin_img.Image = global::Firts_Forms.Properties.Resources._return;
            this.nazadLogin_img.Location = new System.Drawing.Point(683, 350);
            this.nazadLogin_img.Name = "nazadLogin_img";
            this.nazadLogin_img.Size = new System.Drawing.Size(64, 64);
            this.nazadLogin_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nazadLogin_img.TabIndex = 19;
            this.nazadLogin_img.TabStop = false;
            this.nazadLogin_img.DoubleClick += new System.EventHandler(this.nazadLogin_img_DoubleClick);
            // 
            // nazad_register_field
            // 
            this.nazad_register_field.Location = new System.Drawing.Point(486, 420);
            this.nazad_register_field.Multiline = true;
            this.nazad_register_field.Name = "nazad_register_field";
            this.nazad_register_field.ReadOnly = true;
            this.nazad_register_field.Size = new System.Drawing.Size(141, 20);
            this.nazad_register_field.TabIndex = 18;
            this.nazad_register_field.Text = "Вернуться к регистрации";
            // 
            // nazad_login_field
            // 
            this.nazad_login_field.BackColor = System.Drawing.SystemColors.Window;
            this.nazad_login_field.Location = new System.Drawing.Point(651, 420);
            this.nazad_login_field.Name = "nazad_login_field";
            this.nazad_login_field.ReadOnly = true;
            this.nazad_login_field.Size = new System.Drawing.Size(141, 20);
            this.nazad_login_field.TabIndex = 17;
            this.nazad_login_field.Text = "Вернуться к авторизации";
            // 
            // User_checker_field
            // 
            this.User_checker_field.Cursor = System.Windows.Forms.Cursors.No;
            this.User_checker_field.Enabled = false;
            this.User_checker_field.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_checker_field.Location = new System.Drawing.Point(299, 96);
            this.User_checker_field.Multiline = true;
            this.User_checker_field.Name = "User_checker_field";
            this.User_checker_field.ReadOnly = true;
            this.User_checker_field.Size = new System.Drawing.Size(269, 38);
            this.User_checker_field.TabIndex = 4;
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.Control;
            this.loginField.Enabled = false;
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginField.Location = new System.Drawing.Point(7, 96);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.ReadOnly = true;
            this.loginField.Size = new System.Drawing.Size(269, 38);
            this.loginField.TabIndex = 3;
            this.loginField.Text = "Добро пожаловать,";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(27)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Controls.Add(this.mainPannel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 80);
            this.panel3.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(81)))), ((int)(((byte)(172)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(784, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // mainPannel
            // 
            this.mainPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(81)))), ((int)(((byte)(172)))));
            this.mainPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPannel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainPannel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.mainPannel.Location = new System.Drawing.Point(0, 0);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(808, 80);
            this.mainPannel.TabIndex = 0;
            this.mainPannel.Text = "Личный кабинет";
            this.mainPannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainPannel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPannel_MouseDown);
            this.mainPannel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPannel_MouseMove);
            // 
            // ChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPannel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePwd";
            this.Text = "ChangePwd";
            this.mainPannel2.ResumeLayout(false);
            this.mainPannel2.PerformLayout();
            this.sbros_pwd_pannel.ResumeLayout(false);
            this.sbros_pwd_pannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nazad_glav_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazadRegister_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazadLogin_img)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPannel2;
        private System.Windows.Forms.PictureBox nazadRegister_img;
        private System.Windows.Forms.PictureBox nazadLogin_img;
        private System.Windows.Forms.TextBox nazad_register_field;
        private System.Windows.Forms.TextBox nazad_login_field;
        private System.Windows.Forms.TextBox User_checker_field;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label mainPannel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox nazad_glav_img;
        private System.Windows.Forms.Button sm_pwd_button;
        private System.Windows.Forms.Label sm_pwd;
        private System.Windows.Forms.Label active_pwd;
        private System.Windows.Forms.TextBox change_pwd;
        private System.Windows.Forms.Panel sbros_pwd_pannel;
        private System.Windows.Forms.Button active_pwd_button;
        private System.Windows.Forms.TextBox new_pass_active;
        private System.Windows.Forms.Label new_pwd_active;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.Label new_pwd;
    }
}