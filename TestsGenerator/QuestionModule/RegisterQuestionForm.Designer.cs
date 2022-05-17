namespace TestsGenerator.QuestionModule
{
    partial class RegisterQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterQuestionForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbxBimester = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbxGrade = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbxMateria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RTxbDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxDiscipline = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxbLetter = new System.Windows.Forms.TextBox();
            this.BtnDeleteAlternative = new System.Windows.Forms.Button();
            this.BtnEditAlternative = new System.Windows.Forms.Button();
            this.BtnAddAlternative = new System.Windows.Forms.Button();
            this.ChbIsCorret = new System.Windows.Forms.CheckBox();
            this.TxbDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListAlternatives = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CbxBimester);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.CbxGrade);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.CbxMateria);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.RTxbDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.CbxDiscipline);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(24, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 255);
            this.panel2.TabIndex = 2;
            // 
            // CbxBimester
            // 
            this.CbxBimester.DisplayMember = "Bimester";
            this.CbxBimester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxBimester.FormattingEnabled = true;
            this.CbxBimester.Location = new System.Drawing.Point(80, 51);
            this.CbxBimester.Name = "CbxBimester";
            this.CbxBimester.Size = new System.Drawing.Size(166, 23);
            this.CbxBimester.TabIndex = 21;
            this.CbxBimester.SelectedIndexChanged += new System.EventHandler(this.CbxBimester_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bimestre:";
            // 
            // CbxGrade
            // 
            this.CbxGrade.DisplayMember = "Grade";
            this.CbxGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxGrade.FormattingEnabled = true;
            this.CbxGrade.Location = new System.Drawing.Point(345, 14);
            this.CbxGrade.Name = "CbxGrade";
            this.CbxGrade.Size = new System.Drawing.Size(157, 23);
            this.CbxGrade.TabIndex = 19;
            this.CbxGrade.SelectedIndexChanged += new System.EventHandler(this.CbxGrade_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(304, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Série:";
            // 
            // CbxMateria
            // 
            this.CbxMateria.DisplayMember = "Name";
            this.CbxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMateria.FormattingEnabled = true;
            this.CbxMateria.Location = new System.Drawing.Point(324, 51);
            this.CbxMateria.Name = "CbxMateria";
            this.CbxMateria.Size = new System.Drawing.Size(178, 23);
            this.CbxMateria.TabIndex = 13;
            this.CbxMateria.SelectedIndexChanged += new System.EventHandler(this.CbxMateria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Matéria:";
            // 
            // RTxbDescription
            // 
            this.RTxbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTxbDescription.Location = new System.Drawing.Point(18, 104);
            this.RTxbDescription.Name = "RTxbDescription";
            this.RTxbDescription.Size = new System.Drawing.Size(484, 132);
            this.RTxbDescription.TabIndex = 4;
            this.RTxbDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enunciado:";
            // 
            // CbxDiscipline
            // 
            this.CbxDiscipline.DisplayMember = "Name";
            this.CbxDiscipline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxDiscipline.FormattingEnabled = true;
            this.CbxDiscipline.Location = new System.Drawing.Point(85, 14);
            this.CbxDiscipline.Name = "CbxDiscipline";
            this.CbxDiscipline.Size = new System.Drawing.Size(206, 23);
            this.CbxDiscipline.TabIndex = 2;
            this.CbxDiscipline.SelectedIndexChanged += new System.EventHandler(this.CbxDiscipline_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Disciplina:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Questão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alternativas";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.TxbLetter);
            this.panel4.Controls.Add(this.BtnDeleteAlternative);
            this.panel4.Controls.Add(this.BtnEditAlternative);
            this.panel4.Controls.Add(this.BtnAddAlternative);
            this.panel4.Controls.Add(this.ChbIsCorret);
            this.panel4.Controls.Add(this.TxbDescription);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.ListAlternatives);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(24, 309);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(520, 254);
            this.panel4.TabIndex = 4;
            // 
            // TxbLetter
            // 
            this.TxbLetter.Location = new System.Drawing.Point(60, 28);
            this.TxbLetter.MaxLength = 1;
            this.TxbLetter.Name = "TxbLetter";
            this.TxbLetter.Size = new System.Drawing.Size(84, 23);
            this.TxbLetter.TabIndex = 11;
            // 
            // BtnDeleteAlternative
            // 
            this.BtnDeleteAlternative.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteAlternative.Image")));
            this.BtnDeleteAlternative.Location = new System.Drawing.Point(439, 62);
            this.BtnDeleteAlternative.Name = "BtnDeleteAlternative";
            this.BtnDeleteAlternative.Size = new System.Drawing.Size(37, 28);
            this.BtnDeleteAlternative.TabIndex = 10;
            this.BtnDeleteAlternative.UseVisualStyleBackColor = true;
            this.BtnDeleteAlternative.Click += new System.EventHandler(this.BtnDeleteAlternative_Click);
            // 
            // BtnEditAlternative
            // 
            this.BtnEditAlternative.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditAlternative.Image")));
            this.BtnEditAlternative.Location = new System.Drawing.Point(393, 62);
            this.BtnEditAlternative.Name = "BtnEditAlternative";
            this.BtnEditAlternative.Size = new System.Drawing.Size(37, 28);
            this.BtnEditAlternative.TabIndex = 9;
            this.BtnEditAlternative.UseVisualStyleBackColor = true;
            this.BtnEditAlternative.Click += new System.EventHandler(this.BtnEditAlternative_Click);
            // 
            // BtnAddAlternative
            // 
            this.BtnAddAlternative.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddAlternative.Image")));
            this.BtnAddAlternative.Location = new System.Drawing.Point(350, 62);
            this.BtnAddAlternative.Name = "BtnAddAlternative";
            this.BtnAddAlternative.Size = new System.Drawing.Size(37, 28);
            this.BtnAddAlternative.TabIndex = 8;
            this.BtnAddAlternative.UseVisualStyleBackColor = true;
            this.BtnAddAlternative.Click += new System.EventHandler(this.BtnAddAlternative_Click);
            // 
            // ChbIsCorret
            // 
            this.ChbIsCorret.AutoSize = true;
            this.ChbIsCorret.Location = new System.Drawing.Point(160, 31);
            this.ChbIsCorret.Name = "ChbIsCorret";
            this.ChbIsCorret.Size = new System.Drawing.Size(65, 19);
            this.ChbIsCorret.TabIndex = 7;
            this.ChbIsCorret.Text = "Correta";
            this.ChbIsCorret.UseVisualStyleBackColor = true;
            // 
            // TxbDescription
            // 
            this.TxbDescription.Location = new System.Drawing.Point(81, 66);
            this.TxbDescription.Name = "TxbDescription";
            this.TxbDescription.Size = new System.Drawing.Size(258, 23);
            this.TxbDescription.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Descrição:";
            // 
            // ListAlternatives
            // 
            this.ListAlternatives.FormattingEnabled = true;
            this.ListAlternatives.ItemHeight = 15;
            this.ListAlternatives.Location = new System.Drawing.Point(18, 125);
            this.ListAlternatives.Name = "ListAlternatives";
            this.ListAlternatives.Size = new System.Drawing.Size(484, 109);
            this.ListAlternatives.TabIndex = 4;
            this.ListAlternatives.SelectedIndexChanged += new System.EventHandler(this.ListAlternatives_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Alternativas Geradas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Letra:";
            // 
            // BtnRegister
            // 
            this.BtnRegister.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnRegister.Location = new System.Drawing.Point(157, 586);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(114, 45);
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Cadastrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(298, 586);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(114, 45);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // RegisterQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(569, 653);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Questões";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private Label label4;
        private ComboBox CbxDiscipline;
        private Label label3;
        private Label label1;
        private RichTextBox RTxbDescription;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Label label9;
        private Label label7;
        private CheckBox ChbIsCorret;
        private TextBox TxbDescription;
        private Label label8;
        private ListBox ListAlternatives;
        private Button BtnRegister;
        private Button BtnCancel;
        private Button BtnAddAlternative;
        private Button BtnDeleteAlternative;
        private Button BtnEditAlternative;
        private TextBox TxbLetter;
        private ComboBox CbxMateria;
        private ComboBox CbxGrade;
        private Label label10;
        private ComboBox CbxBimester;
        private Label label11;
    }
}