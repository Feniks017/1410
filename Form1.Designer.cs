namespace matrix
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.constValueBox = new System.Windows.Forms.TextBox();
            this.constButton = new System.Windows.Forms.Button();
            this.detButton = new System.Windows.Forms.Button();
            this.invButton = new System.Windows.Forms.Button();
            this.tranButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.matrixA = new System.Windows.Forms.DataGridView();
            this.rowA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.colA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.matrixB = new System.Windows.Forms.DataGridView();
            this.rowB = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultMatrix = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colB)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.constValueBox);
            this.groupBox1.Controls.Add(this.constButton);
            this.groupBox1.Controls.Add(this.detButton);
            this.groupBox1.Controls.Add(this.invButton);
            this.groupBox1.Controls.Add(this.tranButton);
            this.groupBox1.Controls.Add(this.plusButton);
            this.groupBox1.Controls.Add(this.minusButton);
            this.groupBox1.Controls.Add(this.multButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.matrixA);
            this.groupBox1.Controls.Add(this.rowA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.colA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "matrix A";
            // 
            // constValueBox
            // 
            this.constValueBox.Location = new System.Drawing.Point(114, 396);
            this.constValueBox.Name = "constValueBox";
            this.constValueBox.Size = new System.Drawing.Size(82, 22);
            this.constValueBox.TabIndex = 13;
            this.constValueBox.TextChanged += new System.EventHandler(this.constValueBox_TextChanged);
            this.constValueBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.constValueBox_KeyPress);
            // 
            // constButton
            // 
            this.constButton.Enabled = false;
            this.constButton.Location = new System.Drawing.Point(9, 393);
            this.constButton.Name = "constButton";
            this.constButton.Size = new System.Drawing.Size(82, 29);
            this.constButton.TabIndex = 12;
            this.constButton.Text = "φA";
            this.constButton.UseVisualStyleBackColor = true;
            this.constButton.Click += new System.EventHandler(this.constButton_Click);
            // 
            // detButton
            // 
            this.detButton.Location = new System.Drawing.Point(222, 355);
            this.detButton.Name = "detButton";
            this.detButton.Size = new System.Drawing.Size(82, 29);
            this.detButton.TabIndex = 11;
            this.detButton.Text = "|A|";
            this.detButton.UseVisualStyleBackColor = true;
            this.detButton.Click += new System.EventHandler(this.detButton_Click);
            // 
            // invButton
            // 
            this.invButton.Location = new System.Drawing.Point(114, 355);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(82, 29);
            this.invButton.TabIndex = 10;
            this.invButton.Text = "Aˉ¹";
            this.invButton.UseVisualStyleBackColor = true;
            this.invButton.Click += new System.EventHandler(this.inverseButton_Click);
            // 
            // tranButton
            // 
            this.tranButton.Location = new System.Drawing.Point(9, 355);
            this.tranButton.Name = "tranButton";
            this.tranButton.Size = new System.Drawing.Size(82, 29);
            this.tranButton.TabIndex = 9;
            this.tranButton.Text = "transpose ";
            this.tranButton.UseVisualStyleBackColor = true;
            this.tranButton.Click += new System.EventHandler(this.transButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(9, 320);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(82, 29);
            this.plusButton.TabIndex = 8;
            this.plusButton.Text = "A + B";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(114, 320);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(82, 29);
            this.minusButton.TabIndex = 7;
            this.minusButton.Text = "A - B";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // multButton
            // 
            this.multButton.Location = new System.Drawing.Point(222, 320);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(82, 29);
            this.multButton.TabIndex = 6;
            this.multButton.Text = "A * B";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClearButton_Click);
            // 
            // matrixA
            // 
            this.matrixA.AllowUserToAddRows = false;
            this.matrixA.AllowUserToDeleteRows = false;
            this.matrixA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixA.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixA.DefaultCellStyle = dataGridViewCellStyle1;
            this.matrixA.Location = new System.Drawing.Point(6, 55);
            this.matrixA.Name = "matrixA";
            this.matrixA.RowHeadersVisible = false;
            this.matrixA.RowHeadersWidth = 30;
            this.matrixA.RowTemplate.Height = 24;
            this.matrixA.Size = new System.Drawing.Size(300, 260);
            this.matrixA.TabIndex = 4;
            this.matrixA.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.matrixA_CellValidating);
            this.matrixA.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixA_EditingControlShowing);
            // 
            // rowA
            // 
            this.rowA.Location = new System.Drawing.Point(143, 27);
            this.rowA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rowA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowA.Name = "rowA";
            this.rowA.Size = new System.Drawing.Size(64, 22);
            this.rowA.TabIndex = 3;
            this.rowA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowA.ValueChanged += new System.EventHandler(this.colRow_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "row";
            // 
            // colA
            // 
            this.colA.Location = new System.Drawing.Point(38, 27);
            this.colA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colA.Name = "colA";
            this.colA.Size = new System.Drawing.Size(64, 22);
            this.colA.TabIndex = 1;
            this.colA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.colA.ValueChanged += new System.EventHandler(this.colRow_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "col";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.matrixB);
            this.groupBox2.Controls.Add(this.rowB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.colB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(316, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 430);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "matrix B";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // matrixB
            // 
            this.matrixB.AllowUserToAddRows = false;
            this.matrixB.AllowUserToDeleteRows = false;
            this.matrixB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.matrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixB.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixB.DefaultCellStyle = dataGridViewCellStyle2;
            this.matrixB.Location = new System.Drawing.Point(6, 55);
            this.matrixB.Name = "matrixB";
            this.matrixB.RowHeadersVisible = false;
            this.matrixB.RowHeadersWidth = 30;
            this.matrixB.RowTemplate.Height = 24;
            this.matrixB.Size = new System.Drawing.Size(300, 260);
            this.matrixB.TabIndex = 4;
            this.matrixB.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.matrixA_CellValidating);
            this.matrixB.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixA_EditingControlShowing);
            // 
            // rowB
            // 
            this.rowB.Location = new System.Drawing.Point(143, 27);
            this.rowB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rowB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowB.Name = "rowB";
            this.rowB.Size = new System.Drawing.Size(64, 22);
            this.rowB.TabIndex = 3;
            this.rowB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowB.ValueChanged += new System.EventHandler(this.colRow_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "row";
            // 
            // colB
            // 
            this.colB.Location = new System.Drawing.Point(38, 27);
            this.colB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.colB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colB.Name = "colB";
            this.colB.Size = new System.Drawing.Size(64, 22);
            this.colB.TabIndex = 1;
            this.colB.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.colB.ValueChanged += new System.EventHandler(this.colRow_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "col";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultMatrix);
            this.groupBox3.Location = new System.Drawing.Point(628, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 430);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "result matrix ";
            // 
            // resultMatrix
            // 
            this.resultMatrix.AllowUserToAddRows = false;
            this.resultMatrix.AllowUserToDeleteRows = false;
            this.resultMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.resultMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultMatrix.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultMatrix.DefaultCellStyle = dataGridViewCellStyle3;
            this.resultMatrix.Location = new System.Drawing.Point(6, 55);
            this.resultMatrix.Name = "resultMatrix";
            this.resultMatrix.ReadOnly = true;
            this.resultMatrix.RowHeadersVisible = false;
            this.resultMatrix.RowHeadersWidth = 30;
            this.resultMatrix.RowTemplate.Height = 24;
            this.resultMatrix.Size = new System.Drawing.Size(300, 260);
            this.resultMatrix.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatrixCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button detButton;
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.Button tranButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView matrixA;
        private System.Windows.Forms.NumericUpDown rowA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown colA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView matrixB;
        private System.Windows.Forms.NumericUpDown rowB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown colB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox constValueBox;
        private System.Windows.Forms.Button constButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView resultMatrix;
    }
}

