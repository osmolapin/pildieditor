
namespace Pildieditimisprogramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.initialResolution = new System.Windows.Forms.Label();
            this.xResInput = new System.Windows.Forms.TextBox();
            this.yResInput = new System.Windows.Forms.TextBox();
            this.slider = new System.Windows.Forms.TrackBar();
            this.ResetSlider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicNotSelectedTxt = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files | *.jpg; *.jpeg; *.png;";
            this.openFileDialog1.Multiselect = true;
            // 
            // BtnSelect
            // 
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.Location = new System.Drawing.Point(81, 107);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(214, 53);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Vali pilt";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(81, 309);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(214, 53);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Salvesta";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // initialResolution
            // 
            this.initialResolution.AutoSize = true;
            this.initialResolution.Location = new System.Drawing.Point(426, 194);
            this.initialResolution.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.initialResolution.Name = "initialResolution";
            this.initialResolution.Size = new System.Drawing.Size(57, 25);
            this.initialResolution.TabIndex = 3;
            this.initialResolution.Text = "label1";
            this.initialResolution.Visible = false;
            // 
            // xResInput
            // 
            this.xResInput.Location = new System.Drawing.Point(154, 186);
            this.xResInput.Margin = new System.Windows.Forms.Padding(5);
            this.xResInput.Name = "xResInput";
            this.xResInput.Size = new System.Drawing.Size(141, 33);
            this.xResInput.TabIndex = 4;
            // 
            // yResInput
            // 
            this.yResInput.Location = new System.Drawing.Point(154, 238);
            this.yResInput.Margin = new System.Windows.Forms.Padding(5);
            this.yResInput.Name = "yResInput";
            this.yResInput.Size = new System.Drawing.Size(141, 33);
            this.yResInput.TabIndex = 5;
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(535, 28);
            this.slider.Margin = new System.Windows.Forms.Padding(5);
            this.slider.Maximum = 20;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(213, 45);
            this.slider.TabIndex = 6;
            this.slider.Value = 10;
            // 
            // ResetSlider
            // 
            this.ResetSlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSlider.Location = new System.Drawing.Point(587, 83);
            this.ResetSlider.Margin = new System.Windows.Forms.Padding(5);
            this.ResetSlider.Name = "ResetSlider";
            this.ResetSlider.Size = new System.Drawing.Size(107, 38);
            this.ResetSlider.TabIndex = 7;
            this.ResetSlider.Text = "Reset";
            this.ResetSlider.UseVisualStyleBackColor = true;
            this.ResetSlider.Click += new System.EventHandler(this.ResetSlider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Programm piltide redigeerimiseks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pildi heledus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "tume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "hele";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(68, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "X suurus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(68, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y suurus";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 461);
            this.panel1.TabIndex = 15;
            // 
            // PicNotSelectedTxt
            // 
            this.PicNotSelectedTxt.AutoSize = true;
            this.PicNotSelectedTxt.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PicNotSelectedTxt.Location = new System.Drawing.Point(459, 309);
            this.PicNotSelectedTxt.Name = "PicNotSelectedTxt";
            this.PicNotSelectedTxt.Size = new System.Drawing.Size(289, 37);
            this.PicNotSelectedTxt.TabIndex = 16;
            this.PicNotSelectedTxt.Text = "Ühtegi pilti ei ole valitud";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(13, 16);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(344, 209);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(13, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 204);
            this.listBox1.TabIndex = 14;
            this.listBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(413, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 246);
            this.panel2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.PicNotSelectedTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetSlider);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.yResInput);
            this.Controls.Add(this.xResInput);
            this.Controls.Add(this.initialResolution);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Photon";
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label initialResolution;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox xResInput;
        private System.Windows.Forms.TextBox yResInput;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Button ResetSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PicNotSelectedTxt;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

