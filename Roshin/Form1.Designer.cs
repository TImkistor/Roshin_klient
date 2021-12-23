
namespace Roshin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.l2 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tt1 = new System.Windows.Forms.LinkLabel();
            this.tt2 = new System.Windows.Forms.LinkLabel();
            this.t1 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.t3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(454, 402);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 50);
            this.pictureBox4.TabIndex = 58;
            this.pictureBox4.TabStop = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(181, 213);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(231, 34);
            this.password.TabIndex = 56;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(181, 158);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(231, 34);
            this.login.TabIndex = 55;
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.ForeColor = System.Drawing.Color.Red;
            this.l2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.l2.Location = new System.Drawing.Point(89, 419);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(346, 17);
            this.l2.TabIndex = 54;
            this.l2.Text = "При забытия пароля обратитесь к админстратору ";
            this.l2.Visible = false;
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.ForeColor = System.Drawing.Color.Red;
            this.l1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l1.Location = new System.Drawing.Point(130, 402);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(259, 17);
            this.l1.TabIndex = 53;
            this.l1.Text = "Непарвильный пароль либо же логин.";
            this.l1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(366, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Авторизация";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(369, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pictureBox2.Location = new System.Drawing.Point(90, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(88, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pictureBox1.Location = new System.Drawing.Point(91, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button3.Location = new System.Drawing.Point(464, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 34);
            this.button3.TabIndex = 43;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button2.Location = new System.Drawing.Point(418, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 34);
            this.button2.TabIndex = 42;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.button1.Location = new System.Drawing.Point(148, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 58);
            this.button1.TabIndex = 41;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tt1
            // 
            this.tt1.AutoSize = true;
            this.tt1.BackColor = System.Drawing.Color.Transparent;
            this.tt1.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.tt1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.tt1.Location = new System.Drawing.Point(88, 269);
            this.tt1.Name = "tt1";
            this.tt1.Size = new System.Drawing.Size(232, 19);
            this.tt1.TabIndex = 44;
            this.tt1.TabStop = true;
            this.tt1.Text = "пользовательское соглошение";
            // 
            // tt2
            // 
            this.tt2.AutoSize = true;
            this.tt2.BackColor = System.Drawing.Color.Transparent;
            this.tt2.DisabledLinkColor = System.Drawing.Color.Transparent;
            this.tt2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.tt2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tt2.Location = new System.Drawing.Point(154, 288);
            this.tt2.Name = "tt2";
            this.tt2.Size = new System.Drawing.Size(131, 19);
            this.tt2.TabIndex = 45;
            this.tt2.TabStop = true;
            this.tt2.Text = "политику Google";
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.BackColor = System.Drawing.Color.Transparent;
            this.t1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.t1.Location = new System.Drawing.Point(88, 250);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(313, 19);
            this.t1.TabIndex = 50;
            this.t1.Text = "Пользуясь приложением вы принимаете ";
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.BackColor = System.Drawing.Color.Transparent;
            this.t2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.t2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.t2.Location = new System.Drawing.Point(316, 270);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(96, 19);
            this.t2.TabIndex = 51;
            this.t2.Text = "а также при";
            // 
            // t3
            // 
            this.t3.AutoSize = true;
            this.t3.BackColor = System.Drawing.Color.Transparent;
            this.t3.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold);
            this.t3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.t3.Location = new System.Drawing.Point(87, 288);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(70, 19);
            this.t3.TabIndex = 52;
            this.t3.Text = "нимаете";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(291, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tt2);
            this.Controls.Add(this.tt1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel tt1;
        private System.Windows.Forms.LinkLabel tt2;
        private System.Windows.Forms.Label t1;
        private System.Windows.Forms.Label t2;
        private System.Windows.Forms.Label t3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

