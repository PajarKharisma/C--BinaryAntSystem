namespace BinarryAntSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jumlahSemutInput = new System.Windows.Forms.TextBox();
            this.evaporasiInput = new System.Windows.Forms.TextBox();
            this.jumlahIterasiInput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.barangGridView = new System.Windows.Forms.DataGridView();
            this.tasGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tampilkanDetailButton = new System.Windows.Forms.Button();
            this.IterasiKe = new System.Windows.Forms.TextBox();
            this.hasilGridView = new System.Windows.Forms.DataGridView();
            this.prosesButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasilGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah Semut :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai Evaporasi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Iterasi :";
            // 
            // jumlahSemutInput
            // 
            this.jumlahSemutInput.Location = new System.Drawing.Point(98, 10);
            this.jumlahSemutInput.Name = "jumlahSemutInput";
            this.jumlahSemutInput.Size = new System.Drawing.Size(37, 20);
            this.jumlahSemutInput.TabIndex = 3;
            // 
            // evaporasiInput
            // 
            this.evaporasiInput.Location = new System.Drawing.Point(241, 10);
            this.evaporasiInput.Name = "evaporasiInput";
            this.evaporasiInput.Size = new System.Drawing.Size(38, 20);
            this.evaporasiInput.TabIndex = 4;
            // 
            // jumlahIterasiInput
            // 
            this.jumlahIterasiInput.Location = new System.Drawing.Point(386, 10);
            this.jumlahIterasiInput.Name = "jumlahIterasiInput";
            this.jumlahIterasiInput.Size = new System.Drawing.Size(39, 20);
            this.jumlahIterasiInput.TabIndex = 5;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(16, 40);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(219, 20);
            this.txtInput.TabIndex = 6;
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(241, 38);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(75, 23);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "input file";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 464);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.barangGridView);
            this.tabPage1.Controls.Add(this.tasGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // barangGridView
            // 
            this.barangGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.barangGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barangGridView.Location = new System.Drawing.Point(343, 6);
            this.barangGridView.Name = "barangGridView";
            this.barangGridView.Size = new System.Drawing.Size(362, 393);
            this.barangGridView.TabIndex = 1;
            // 
            // tasGridView
            // 
            this.tasGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tasGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tasGridView.Location = new System.Drawing.Point(6, 6);
            this.tasGridView.Name = "tasGridView";
            this.tasGridView.Size = new System.Drawing.Size(331, 393);
            this.tasGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tampilkanDetailButton);
            this.tabPage2.Controls.Add(this.IterasiKe);
            this.tabPage2.Controls.Add(this.hasilGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hasil";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(9, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(696, 149);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detail Iterasi : ";
            // 
            // tampilkanDetailButton
            // 
            this.tampilkanDetailButton.Location = new System.Drawing.Point(247, 253);
            this.tampilkanDetailButton.Name = "tampilkanDetailButton";
            this.tampilkanDetailButton.Size = new System.Drawing.Size(99, 24);
            this.tampilkanDetailButton.TabIndex = 2;
            this.tampilkanDetailButton.Text = "Tampilkan";
            this.tampilkanDetailButton.UseVisualStyleBackColor = true;
            // 
            // IterasiKe
            // 
            this.IterasiKe.Location = new System.Drawing.Point(85, 256);
            this.IterasiKe.Name = "IterasiKe";
            this.IterasiKe.Size = new System.Drawing.Size(156, 20);
            this.IterasiKe.TabIndex = 1;
            // 
            // hasilGridView
            // 
            this.hasilGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hasilGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hasilGridView.Location = new System.Drawing.Point(7, 7);
            this.hasilGridView.Name = "hasilGridView";
            this.hasilGridView.Size = new System.Drawing.Size(698, 240);
            this.hasilGridView.TabIndex = 0;
            // 
            // prosesButton
            // 
            this.prosesButton.Location = new System.Drawing.Point(16, 536);
            this.prosesButton.Name = "prosesButton";
            this.prosesButton.Size = new System.Drawing.Size(96, 23);
            this.prosesButton.TabIndex = 9;
            this.prosesButton.Text = "Proses";
            this.prosesButton.UseVisualStyleBackColor = true;
            this.prosesButton.Click += new System.EventHandler(this.ProsesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 571);
            this.Controls.Add(this.prosesButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.jumlahIterasiInput);
            this.Controls.Add(this.evaporasiInput);
            this.Controls.Add(this.jumlahSemutInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barangGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasilGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox jumlahSemutInput;
        private System.Windows.Forms.TextBox evaporasiInput;
        private System.Windows.Forms.TextBox jumlahIterasiInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView barangGridView;
        private System.Windows.Forms.DataGridView tasGridView;
        private System.Windows.Forms.Button prosesButton;
        private System.Windows.Forms.TextBox IterasiKe;
        private System.Windows.Forms.DataGridView hasilGridView;
        private System.Windows.Forms.Button tampilkanDetailButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

