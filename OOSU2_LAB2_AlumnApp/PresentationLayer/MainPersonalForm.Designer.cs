namespace PresentationLayer
{
    partial class MainPersonalForm
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
            this.tabControlMainAdmin = new System.Windows.Forms.TabControl();
            this.tabPageCreateActivity = new System.Windows.Forms.TabPage();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.SkapaAktivitetKnapp = new System.Windows.Forms.Button();
            this.SluttidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.StarttidDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.PlatsTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitelAktivitetTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEditActivity = new System.Windows.Forms.TabPage();
            this.ändraBeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.VäljAktivitetComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ändraSlutdatumDateTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.ändraStarttidDateTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.ändraPlatsTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ändraTitelTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageMakeEmailList = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.AktivitetCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.KompetensFilterCmbBox = new System.Windows.Forms.ComboBox();
            this.AlumnCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.programFilterCmbBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCreateAlumnCSV = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.ändraAnsvarigPersonTxtBox = new System.Windows.Forms.TextBox();
            this.ändraAnsvarigKontaktTxtBox = new System.Windows.Forms.TextBox();
            this.AnsvarigPersonTxtBox = new System.Windows.Forms.TextBox();
            this.KontaktPersonTxtBox = new System.Windows.Forms.TextBox();
            this.tabControlMainAdmin.SuspendLayout();
            this.tabPageCreateActivity.SuspendLayout();
            this.tabPageEditActivity.SuspendLayout();
            this.tabPageMakeEmailList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainAdmin
            // 
            this.tabControlMainAdmin.Controls.Add(this.tabPageCreateActivity);
            this.tabControlMainAdmin.Controls.Add(this.tabPageEditActivity);
            this.tabControlMainAdmin.Controls.Add(this.tabPageMakeEmailList);
            this.tabControlMainAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlMainAdmin.Name = "tabControlMainAdmin";
            this.tabControlMainAdmin.SelectedIndex = 0;
            this.tabControlMainAdmin.Size = new System.Drawing.Size(519, 329);
            this.tabControlMainAdmin.TabIndex = 0;
            this.tabControlMainAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlMainAdmin_SelectedIndexChanged);
            // 
            // tabPageCreateActivity
            // 
            this.tabPageCreateActivity.Controls.Add(this.KontaktPersonTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.AnsvarigPersonTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.BeskrivningTextBox);
            this.tabPageCreateActivity.Controls.Add(this.SkapaAktivitetKnapp);
            this.tabPageCreateActivity.Controls.Add(this.SluttidDateTimePicker);
            this.tabPageCreateActivity.Controls.Add(this.label7);
            this.tabPageCreateActivity.Controls.Add(this.StarttidDateTimePicker);
            this.tabPageCreateActivity.Controls.Add(this.label6);
            this.tabPageCreateActivity.Controls.Add(this.PlatsTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.label5);
            this.tabPageCreateActivity.Controls.Add(this.label4);
            this.tabPageCreateActivity.Controls.Add(this.label3);
            this.tabPageCreateActivity.Controls.Add(this.TitelAktivitetTxtBox);
            this.tabPageCreateActivity.Controls.Add(this.label2);
            this.tabPageCreateActivity.Controls.Add(this.label1);
            this.tabPageCreateActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreateActivity.Name = "tabPageCreateActivity";
            this.tabPageCreateActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateActivity.Size = new System.Drawing.Size(511, 303);
            this.tabPageCreateActivity.TabIndex = 0;
            this.tabPageCreateActivity.Text = "Skapa aktivitet";
            this.tabPageCreateActivity.UseVisualStyleBackColor = true;
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(250, 23);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.Size = new System.Drawing.Size(238, 181);
            this.BeskrivningTextBox.TabIndex = 15;
            this.BeskrivningTextBox.Text = "";
            // 
            // SkapaAktivitetKnapp
            // 
            this.SkapaAktivitetKnapp.Location = new System.Drawing.Point(250, 223);
            this.SkapaAktivitetKnapp.Name = "SkapaAktivitetKnapp";
            this.SkapaAktivitetKnapp.Size = new System.Drawing.Size(238, 23);
            this.SkapaAktivitetKnapp.TabIndex = 14;
            this.SkapaAktivitetKnapp.Text = "Skapa aktivitet";
            this.SkapaAktivitetKnapp.UseVisualStyleBackColor = true;
            this.SkapaAktivitetKnapp.Click += new System.EventHandler(this.SkapaAktivitetKnapp_Click);
            // 
            // SluttidDateTimePicker
            // 
            this.SluttidDateTimePicker.Location = new System.Drawing.Point(10, 223);
            this.SluttidDateTimePicker.Name = "SluttidDateTimePicker";
            this.SluttidDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.SluttidDateTimePicker.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Datum och sluttid";
            // 
            // StarttidDateTimePicker
            // 
            this.StarttidDateTimePicker.Location = new System.Drawing.Point(10, 184);
            this.StarttidDateTimePicker.Name = "StarttidDateTimePicker";
            this.StarttidDateTimePicker.Size = new System.Drawing.Size(208, 20);
            this.StarttidDateTimePicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum och starttid";
            // 
            // PlatsTxtBox
            // 
            this.PlatsTxtBox.Location = new System.Drawing.Point(10, 144);
            this.PlatsTxtBox.Name = "PlatsTxtBox";
            this.PlatsTxtBox.Size = new System.Drawing.Size(208, 20);
            this.PlatsTxtBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kontakt person";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ansvarig person";
            // 
            // TitelAktivitetTxtBox
            // 
            this.TitelAktivitetTxtBox.Location = new System.Drawing.Point(10, 24);
            this.TitelAktivitetTxtBox.Name = "TitelAktivitetTxtBox";
            this.TitelAktivitetTxtBox.Size = new System.Drawing.Size(208, 20);
            this.TitelAktivitetTxtBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beskrivning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel";
            // 
            // tabPageEditActivity
            // 
            this.tabPageEditActivity.Controls.Add(this.ändraAnsvarigKontaktTxtBox);
            this.tabPageEditActivity.Controls.Add(this.ändraAnsvarigPersonTxtBox);
            this.tabPageEditActivity.Controls.Add(this.ändraBeskrivningTextBox);
            this.tabPageEditActivity.Controls.Add(this.VäljAktivitetComboBox);
            this.tabPageEditActivity.Controls.Add(this.label15);
            this.tabPageEditActivity.Controls.Add(this.btnSaveChanges);
            this.tabPageEditActivity.Controls.Add(this.label14);
            this.tabPageEditActivity.Controls.Add(this.ändraSlutdatumDateTime);
            this.tabPageEditActivity.Controls.Add(this.label13);
            this.tabPageEditActivity.Controls.Add(this.ändraStarttidDateTime);
            this.tabPageEditActivity.Controls.Add(this.label12);
            this.tabPageEditActivity.Controls.Add(this.ändraPlatsTxtBox);
            this.tabPageEditActivity.Controls.Add(this.label11);
            this.tabPageEditActivity.Controls.Add(this.label10);
            this.tabPageEditActivity.Controls.Add(this.label9);
            this.tabPageEditActivity.Controls.Add(this.ändraTitelTxtBox);
            this.tabPageEditActivity.Controls.Add(this.label8);
            this.tabPageEditActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageEditActivity.Name = "tabPageEditActivity";
            this.tabPageEditActivity.Size = new System.Drawing.Size(511, 303);
            this.tabPageEditActivity.TabIndex = 2;
            this.tabPageEditActivity.Text = "Redigera aktivitet";
            this.tabPageEditActivity.UseVisualStyleBackColor = true;
            // 
            // ändraBeskrivningTextBox
            // 
            this.ändraBeskrivningTextBox.Location = new System.Drawing.Point(250, 66);
            this.ändraBeskrivningTextBox.Name = "ändraBeskrivningTextBox";
            this.ändraBeskrivningTextBox.Size = new System.Drawing.Size(242, 180);
            this.ändraBeskrivningTextBox.TabIndex = 17;
            this.ändraBeskrivningTextBox.Text = "";
            // 
            // VäljAktivitetComboBox
            // 
            this.VäljAktivitetComboBox.FormattingEnabled = true;
            this.VäljAktivitetComboBox.Location = new System.Drawing.Point(17, 25);
            this.VäljAktivitetComboBox.Name = "VäljAktivitetComboBox";
            this.VäljAktivitetComboBox.Size = new System.Drawing.Size(475, 21);
            this.VäljAktivitetComboBox.TabIndex = 16;
            this.VäljAktivitetComboBox.SelectedIndexChanged += new System.EventHandler(this.VäljAktivitetComboBox_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Välj aktivitet att redigera:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(250, 265);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(242, 23);
            this.btnSaveChanges.TabIndex = 14;
            this.btnSaveChanges.Text = "Spara ändringar";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Beskrivning";
            // 
            // ändraSlutdatumDateTime
            // 
            this.ändraSlutdatumDateTime.Location = new System.Drawing.Point(17, 265);
            this.ändraSlutdatumDateTime.Name = "ändraSlutdatumDateTime";
            this.ändraSlutdatumDateTime.Size = new System.Drawing.Size(212, 20);
            this.ändraSlutdatumDateTime.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Datum och sluttid";
            // 
            // ändraStarttidDateTime
            // 
            this.ändraStarttidDateTime.Location = new System.Drawing.Point(17, 226);
            this.ändraStarttidDateTime.Name = "ändraStarttidDateTime";
            this.ändraStarttidDateTime.Size = new System.Drawing.Size(212, 20);
            this.ändraStarttidDateTime.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Datum och starttid";
            // 
            // ändraPlatsTxtBox
            // 
            this.ändraPlatsTxtBox.Location = new System.Drawing.Point(17, 186);
            this.ändraPlatsTxtBox.Name = "ändraPlatsTxtBox";
            this.ändraPlatsTxtBox.Size = new System.Drawing.Size(212, 20);
            this.ändraPlatsTxtBox.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Plats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Kontaktperson";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ansvarig person";
            // 
            // ändraTitelTxtBox
            // 
            this.ändraTitelTxtBox.Location = new System.Drawing.Point(17, 66);
            this.ändraTitelTxtBox.Name = "ändraTitelTxtBox";
            this.ändraTitelTxtBox.Size = new System.Drawing.Size(212, 20);
            this.ändraTitelTxtBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Titel";
            // 
            // tabPageMakeEmailList
            // 
            this.tabPageMakeEmailList.Controls.Add(this.label20);
            this.tabPageMakeEmailList.Controls.Add(this.AktivitetCheckedListBox);
            this.tabPageMakeEmailList.Controls.Add(this.label19);
            this.tabPageMakeEmailList.Controls.Add(this.label18);
            this.tabPageMakeEmailList.Controls.Add(this.KompetensFilterCmbBox);
            this.tabPageMakeEmailList.Controls.Add(this.AlumnCheckedListBox);
            this.tabPageMakeEmailList.Controls.Add(this.programFilterCmbBox);
            this.tabPageMakeEmailList.Controls.Add(this.label17);
            this.tabPageMakeEmailList.Controls.Add(this.btnCreateAlumnCSV);
            this.tabPageMakeEmailList.Controls.Add(this.label16);
            this.tabPageMakeEmailList.Location = new System.Drawing.Point(4, 22);
            this.tabPageMakeEmailList.Name = "tabPageMakeEmailList";
            this.tabPageMakeEmailList.Size = new System.Drawing.Size(511, 303);
            this.tabPageMakeEmailList.TabIndex = 3;
            this.tabPageMakeEmailList.Text = "Skapa utskickslista";
            this.tabPageMakeEmailList.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(193, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "Välj Aktivitet";
            // 
            // AktivitetCheckedListBox
            // 
            this.AktivitetCheckedListBox.FormattingEnabled = true;
            this.AktivitetCheckedListBox.Location = new System.Drawing.Point(193, 83);
            this.AktivitetCheckedListBox.Name = "AktivitetCheckedListBox";
            this.AktivitetCheckedListBox.Size = new System.Drawing.Size(153, 199);
            this.AktivitetCheckedListBox.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(286, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Kompetens";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(116, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Program";
            // 
            // KompetensFilterCmbBox
            // 
            this.KompetensFilterCmbBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.KompetensFilterCmbBox.FormattingEnabled = true;
            this.KompetensFilterCmbBox.Location = new System.Drawing.Point(289, 27);
            this.KompetensFilterCmbBox.Name = "KompetensFilterCmbBox";
            this.KompetensFilterCmbBox.Size = new System.Drawing.Size(208, 21);
            this.KompetensFilterCmbBox.TabIndex = 6;
            this.KompetensFilterCmbBox.Text = "Välj filter";
            this.KompetensFilterCmbBox.SelectedIndexChanged += new System.EventHandler(this.KompetensFilterCmbBox_SelectedIndexChanged);
            // 
            // AlumnCheckedListBox
            // 
            this.AlumnCheckedListBox.FormattingEnabled = true;
            this.AlumnCheckedListBox.Location = new System.Drawing.Point(22, 83);
            this.AlumnCheckedListBox.Name = "AlumnCheckedListBox";
            this.AlumnCheckedListBox.Size = new System.Drawing.Size(153, 199);
            this.AlumnCheckedListBox.TabIndex = 5;
            // 
            // programFilterCmbBox
            // 
            this.programFilterCmbBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.programFilterCmbBox.FormattingEnabled = true;
            this.programFilterCmbBox.Location = new System.Drawing.Point(116, 27);
            this.programFilterCmbBox.Name = "programFilterCmbBox";
            this.programFilterCmbBox.Size = new System.Drawing.Size(167, 21);
            this.programFilterCmbBox.TabIndex = 4;
            this.programFilterCmbBox.Text = "Välj filter";
            this.programFilterCmbBox.SelectedIndexChanged += new System.EventHandler(this.programFilterCmbBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Filtrera lista efter:";
            // 
            // btnCreateAlumnCSV
            // 
            this.btnCreateAlumnCSV.Location = new System.Drawing.Point(381, 153);
            this.btnCreateAlumnCSV.Name = "btnCreateAlumnCSV";
            this.btnCreateAlumnCSV.Size = new System.Drawing.Size(116, 56);
            this.btnCreateAlumnCSV.TabIndex = 2;
            this.btnCreateAlumnCSV.Text = "Skapa .CSV med valda alumner";
            this.btnCreateAlumnCSV.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Välj alumn";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(456, 347);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Logga ut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ändraAnsvarigPersonTxtBox
            // 
            this.ändraAnsvarigPersonTxtBox.Location = new System.Drawing.Point(17, 106);
            this.ändraAnsvarigPersonTxtBox.Name = "ändraAnsvarigPersonTxtBox";
            this.ändraAnsvarigPersonTxtBox.Size = new System.Drawing.Size(212, 20);
            this.ändraAnsvarigPersonTxtBox.TabIndex = 18;
            // 
            // ändraAnsvarigKontaktTxtBox
            // 
            this.ändraAnsvarigKontaktTxtBox.Location = new System.Drawing.Point(17, 147);
            this.ändraAnsvarigKontaktTxtBox.Name = "ändraAnsvarigKontaktTxtBox";
            this.ändraAnsvarigKontaktTxtBox.Size = new System.Drawing.Size(212, 20);
            this.ändraAnsvarigKontaktTxtBox.TabIndex = 19;
            // 
            // AnsvarigPersonTxtBox
            // 
            this.AnsvarigPersonTxtBox.Location = new System.Drawing.Point(10, 63);
            this.AnsvarigPersonTxtBox.Name = "AnsvarigPersonTxtBox";
            this.AnsvarigPersonTxtBox.Size = new System.Drawing.Size(208, 20);
            this.AnsvarigPersonTxtBox.TabIndex = 16;
            // 
            // KontaktPersonTxtBox
            // 
            this.KontaktPersonTxtBox.Location = new System.Drawing.Point(10, 104);
            this.KontaktPersonTxtBox.Name = "KontaktPersonTxtBox";
            this.KontaktPersonTxtBox.Size = new System.Drawing.Size(208, 20);
            this.KontaktPersonTxtBox.TabIndex = 17;
            // 
            // MainPersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 382);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.tabControlMainAdmin);
            this.Name = "MainPersonalForm";
            this.Text = "Administratör";
            this.tabControlMainAdmin.ResumeLayout(false);
            this.tabPageCreateActivity.ResumeLayout(false);
            this.tabPageCreateActivity.PerformLayout();
            this.tabPageEditActivity.ResumeLayout(false);
            this.tabPageEditActivity.PerformLayout();
            this.tabPageMakeEmailList.ResumeLayout(false);
            this.tabPageMakeEmailList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainAdmin;
        private System.Windows.Forms.TabPage tabPageCreateActivity;
        private System.Windows.Forms.TabPage tabPageEditActivity;
        private System.Windows.Forms.TabPage tabPageMakeEmailList;
        private System.Windows.Forms.Button SkapaAktivitetKnapp;
        private System.Windows.Forms.DateTimePicker SluttidDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker StarttidDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PlatsTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitelAktivitetTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DateTimePicker ändraSlutdatumDateTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker ändraStarttidDateTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ändraPlatsTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ändraTitelTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox VäljAktivitetComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox programFilterCmbBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCreateAlumnCSV;
        private System.Windows.Forms.RichTextBox BeskrivningTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox KompetensFilterCmbBox;
        private System.Windows.Forms.CheckedListBox AlumnCheckedListBox;
        private System.Windows.Forms.RichTextBox ändraBeskrivningTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckedListBox AktivitetCheckedListBox;
        private System.Windows.Forms.TextBox ändraAnsvarigKontaktTxtBox;
        private System.Windows.Forms.TextBox ändraAnsvarigPersonTxtBox;
        private System.Windows.Forms.TextBox KontaktPersonTxtBox;
        private System.Windows.Forms.TextBox AnsvarigPersonTxtBox;
    }
}