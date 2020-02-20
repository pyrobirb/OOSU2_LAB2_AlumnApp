namespace PresentationLayer
{
    partial class CreateUserForm
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
            this.alumnRadioBtn = new System.Windows.Forms.RadioButton();
            this.personalRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.användarNamnTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lösenordTextBox = new System.Windows.Forms.TextBox();
            this.skapaKontoBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.förnamnTextBox = new System.Windows.Forms.TextBox();
            this.efternamnTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.epostTextBox = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alumnRadioBtn
            // 
            this.alumnRadioBtn.AutoSize = true;
            this.alumnRadioBtn.Location = new System.Drawing.Point(6, 9);
            this.alumnRadioBtn.Name = "alumnRadioBtn";
            this.alumnRadioBtn.Size = new System.Drawing.Size(54, 17);
            this.alumnRadioBtn.TabIndex = 0;
            this.alumnRadioBtn.TabStop = true;
            this.alumnRadioBtn.Text = "Alumn";
            this.alumnRadioBtn.UseVisualStyleBackColor = true;
            this.alumnRadioBtn.CheckedChanged += new System.EventHandler(this.alumnRadioBtn_CheckedChanged);
            // 
            // personalRadioBtn
            // 
            this.personalRadioBtn.AutoSize = true;
            this.personalRadioBtn.Location = new System.Drawing.Point(66, 9);
            this.personalRadioBtn.Name = "personalRadioBtn";
            this.personalRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.personalRadioBtn.TabIndex = 1;
            this.personalRadioBtn.TabStop = true;
            this.personalRadioBtn.Text = "Administratör";
            this.personalRadioBtn.UseVisualStyleBackColor = true;
            this.personalRadioBtn.CheckedChanged += new System.EventHandler(this.adminRadioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Användarnamn";
            // 
            // användarNamnTextBox
            // 
            this.användarNamnTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.användarNamnTextBox.Location = new System.Drawing.Point(26, 65);
            this.användarNamnTextBox.Name = "användarNamnTextBox";
            this.användarNamnTextBox.Size = new System.Drawing.Size(210, 20);
            this.användarNamnTextBox.TabIndex = 3;
            this.användarNamnTextBox.Text = "Användarnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lösenord";
            // 
            // lösenordTextBox
            // 
            this.lösenordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lösenordTextBox.Location = new System.Drawing.Point(26, 222);
            this.lösenordTextBox.Name = "lösenordTextBox";
            this.lösenordTextBox.Size = new System.Drawing.Size(210, 20);
            this.lösenordTextBox.TabIndex = 5;
            this.lösenordTextBox.Text = "Minst 10 tecken";
            // 
            // skapaKontoBtn
            // 
            this.skapaKontoBtn.Location = new System.Drawing.Point(137, 267);
            this.skapaKontoBtn.Name = "skapaKontoBtn";
            this.skapaKontoBtn.Size = new System.Drawing.Size(99, 23);
            this.skapaKontoBtn.TabIndex = 6;
            this.skapaKontoBtn.Text = "Skapa konto";
            this.skapaKontoBtn.UseVisualStyleBackColor = true;
            this.skapaKontoBtn.Click += new System.EventHandler(this.skapaKontoBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.alumnRadioBtn);
            this.groupBox1.Controls.Add(this.personalRadioBtn);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 34);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Förnamn";
            // 
            // förnamnTextBox
            // 
            this.förnamnTextBox.Location = new System.Drawing.Point(26, 104);
            this.förnamnTextBox.Name = "förnamnTextBox";
            this.förnamnTextBox.Size = new System.Drawing.Size(210, 20);
            this.förnamnTextBox.TabIndex = 11;
            // 
            // efternamnTextBox
            // 
            this.efternamnTextBox.Location = new System.Drawing.Point(26, 143);
            this.efternamnTextBox.Name = "efternamnTextBox";
            this.efternamnTextBox.Size = new System.Drawing.Size(210, 20);
            this.efternamnTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Efternamn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Epost";
            // 
            // epostTextBox
            // 
            this.epostTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.epostTextBox.Location = new System.Drawing.Point(26, 182);
            this.epostTextBox.Name = "epostTextBox";
            this.epostTextBox.Size = new System.Drawing.Size(210, 20);
            this.epostTextBox.TabIndex = 15;
            this.epostTextBox.Text = "abc@cde.se";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(26, 267);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Avbryt";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.avbrytBtn_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 316);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.epostTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.efternamnTextBox);
            this.Controls.Add(this.förnamnTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.skapaKontoBtn);
            this.Controls.Add(this.lösenordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.användarNamnTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateUserForm";
            this.Text = "Skapa konto";
            this.Load += new System.EventHandler(this.CreateUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton alumnRadioBtn;
        private System.Windows.Forms.RadioButton personalRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox användarNamnTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lösenordTextBox;
        private System.Windows.Forms.Button skapaKontoBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox förnamnTextBox;
        private System.Windows.Forms.TextBox efternamnTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox epostTextBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLogOut;
    }
}