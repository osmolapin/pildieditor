
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.initialResolution = new System.Windows.Forms.Label();
            this.xResInput = new System.Windows.Forms.TextBox();
            this.yResInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(420, 200);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(348, 245);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image files | *.jpg; *.jpeg; *.png;";
            this.openFileDialog1.Multiselect = true;
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(12, 99);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Vali pilt";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(12, 392);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Salvesta";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // initialResolution
            // 
            this.initialResolution.AutoSize = true;
            this.initialResolution.Location = new System.Drawing.Point(420, 182);
            this.initialResolution.Name = "initialResolution";
            this.initialResolution.Size = new System.Drawing.Size(38, 15);
            this.initialResolution.TabIndex = 3;
            this.initialResolution.Text = "label1";
            this.initialResolution.Visible = false;
            // 
            // xResInput
            // 
            this.xResInput.Location = new System.Drawing.Point(102, 271);
            this.xResInput.Name = "xResInput";
            this.xResInput.Size = new System.Drawing.Size(100, 23);
            this.xResInput.TabIndex = 4;
            // 
            // yResInput
            // 
            this.yResInput.Location = new System.Drawing.Point(139, 332);
            this.yResInput.Name = "yResInput";
            this.yResInput.Size = new System.Drawing.Size(100, 23);
            this.yResInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.yResInput);
            this.Controls.Add(this.xResInput);
            this.Controls.Add(this.initialResolution);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label initialResolution;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.TextBox xResInput;
        private System.Windows.Forms.TextBox yResInput;
    }
}

