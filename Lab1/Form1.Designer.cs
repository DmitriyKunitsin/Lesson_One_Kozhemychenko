namespace Programming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCol = new System.Windows.Forms.RadioButton();
            this.radioRow = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonProceed = new System.Windows.Forms.Button();
            this.matrixNLabel = new System.Windows.Forms.Label();
            this.matrixN_NUD = new System.Windows.Forms.NumericUpDown();
            this.matrixMLabel = new System.Windows.Forms.Label();
            this.matrixM_NUD = new System.Windows.Forms.NumericUpDown();
            this.originDGV = new System.Windows.Forms.DataGridView();
            this.resultDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPos = new System.Windows.Forms.CheckBox();
            this.chkNeg = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixN_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixM_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размерность исходной матрицы:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCol);
            this.groupBox1.Controls.Add(this.radioRow);
            this.groupBox1.Location = new System.Drawing.Point(15, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 69);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Найти среднее в...";
            // 
            // radioCol
            // 
            this.radioCol.AutoSize = true;
            this.radioCol.Location = new System.Drawing.Point(6, 44);
            this.radioCol.Name = "radioCol";
            this.radioCol.Size = new System.Drawing.Size(70, 19);
            this.radioCol.TabIndex = 11;
            this.radioCol.TabStop = true;
            this.radioCol.Text = "cтолб&це";
            this.radioCol.UseVisualStyleBackColor = true;
            // 
            // radioRow
            // 
            this.radioRow.AutoSize = true;
            this.radioRow.Location = new System.Drawing.Point(6, 22);
            this.radioRow.Name = "radioRow";
            this.radioRow.Size = new System.Drawing.Size(62, 19);
            this.radioRow.TabIndex = 10;
            this.radioRow.TabStop = true;
            this.radioRow.Text = "стро&ке";
            this.radioRow.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(498, 309);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 26);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "&Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonProceed
            // 
            this.buttonProceed.Location = new System.Drawing.Point(498, 277);
            this.buttonProceed.Name = "buttonProceed";
            this.buttonProceed.Size = new System.Drawing.Size(130, 26);
            this.buttonProceed.TabIndex = 12;
            this.buttonProceed.Text = "Начать &расчёт";
            this.buttonProceed.UseVisualStyleBackColor = true;
            this.buttonProceed.Click += new System.EventHandler(this.buttonProceed_Click);
            // 
            // matrixNLabel
            // 
            this.matrixNLabel.AutoSize = true;
            this.matrixNLabel.Location = new System.Drawing.Point(208, 9);
            this.matrixNLabel.Name = "matrixNLabel";
            this.matrixNLabel.Size = new System.Drawing.Size(22, 15);
            this.matrixNLabel.TabIndex = 1;
            this.matrixNLabel.Text = "&N :";
            // 
            // matrixN_NUD
            // 
            this.matrixN_NUD.Location = new System.Drawing.Point(230, 3);
            this.matrixN_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixN_NUD.Name = "matrixN_NUD";
            this.matrixN_NUD.Size = new System.Drawing.Size(63, 23);
            this.matrixN_NUD.TabIndex = 2;
            this.matrixN_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixN_NUD.ValueChanged += new System.EventHandler(this.matrixN_NUD_ValueChanged);
            // 
            // matrixMLabel
            // 
            this.matrixMLabel.AutoSize = true;
            this.matrixMLabel.Location = new System.Drawing.Point(299, 9);
            this.matrixMLabel.Name = "matrixMLabel";
            this.matrixMLabel.Size = new System.Drawing.Size(24, 15);
            this.matrixMLabel.TabIndex = 3;
            this.matrixMLabel.Text = "&M :";
            // 
            // matrixM_NUD
            // 
            this.matrixM_NUD.Location = new System.Drawing.Point(323, 3);
            this.matrixM_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixM_NUD.Name = "matrixM_NUD";
            this.matrixM_NUD.Size = new System.Drawing.Size(63, 23);
            this.matrixM_NUD.TabIndex = 4;
            this.matrixM_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.matrixM_NUD.ValueChanged += new System.EventHandler(this.matrixM_NUD_ValueChanged);
            // 
            // originDGV
            // 
            this.originDGV.AllowUserToAddRows = false;
            this.originDGV.AllowUserToDeleteRows = false;
            this.originDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.originDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.originDGV.ColumnHeadersVisible = false;
            this.originDGV.Location = new System.Drawing.Point(12, 48);
            this.originDGV.Name = "originDGV";
            this.originDGV.RowHeadersVisible = false;
            this.originDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.originDGV.RowTemplate.Height = 25;
            this.originDGV.Size = new System.Drawing.Size(305, 218);
            this.originDGV.TabIndex = 6;
            // 
            // resultDGV
            // 
            this.resultDGV.AllowUserToAddRows = false;
            this.resultDGV.AllowUserToDeleteRows = false;
            this.resultDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDGV.ColumnHeadersVisible = false;
            this.resultDGV.Location = new System.Drawing.Point(323, 48);
            this.resultDGV.Name = "resultDGV";
            this.resultDGV.RowHeadersVisible = false;
            this.resultDGV.RowTemplate.Height = 25;
            this.resultDGV.Size = new System.Drawing.Size(305, 218);
            this.resultDGV.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Исходная матрица";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "&Результат";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNeg);
            this.groupBox2.Controls.Add(this.chkPos);
            this.groupBox2.Location = new System.Drawing.Point(147, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 69);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "... в группе из ...";
            // 
            // chkPos
            // 
            this.chkPos.AutoSize = true;
            this.chkPos.Location = new System.Drawing.Point(6, 23);
            this.chkPos.Name = "chkPos";
            this.chkPos.Size = new System.Drawing.Size(184, 19);
            this.chkPos.TabIndex = 15;
            this.chkPos.Text = "&положительных (включая 0)";
            this.chkPos.UseVisualStyleBackColor = true;
            // 
            // chkNeg
            // 
            this.chkNeg.AutoSize = true;
            this.chkNeg.Location = new System.Drawing.Point(6, 44);
            this.chkNeg.Name = "chkNeg";
            this.chkNeg.Size = new System.Drawing.Size(111, 19);
            this.chkNeg.TabIndex = 15;
            this.chkNeg.Text = "отрицательных";
            this.chkNeg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 346);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultDGV);
            this.Controls.Add(this.originDGV);
            this.Controls.Add(this.matrixM_NUD);
            this.Controls.Add(this.matrixMLabel);
            this.Controls.Add(this.matrixN_NUD);
            this.Controls.Add(this.matrixNLabel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonProceed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Куницин Д.С. - задание №1 - вариант 12";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixN_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixM_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioRow;
        private Button buttonReset;
        private RadioButton radioCol;
        private Button buttonProceed;
        private Label matrixNLabel;
        private NumericUpDown matrixN_NUD;
        private Label matrixMLabel;
        private NumericUpDown matrixM_NUD;
        private DataGridView originDGV;
        private DataGridView resultDGV;
        private Label label2;
        private Label label3;
        private GroupBox groupBox2;
        private CheckBox chkNeg;
        private CheckBox chkPos;
    }
}