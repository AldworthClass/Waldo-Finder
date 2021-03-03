namespace WaldoFinder
{
    partial class FormWaldo
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
            this.imgWaldo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgWaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgWaldo
            // 
            this.imgWaldo.BackColor = System.Drawing.Color.Transparent;
            this.imgWaldo.Image = global::WaldoFinder.Properties.Resources.waldo;
            this.imgWaldo.Location = new System.Drawing.Point(252, 332);
            this.imgWaldo.Name = "imgWaldo";
            this.imgWaldo.Size = new System.Drawing.Size(62, 107);
            this.imgWaldo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgWaldo.TabIndex = 0;
            this.imgWaldo.TabStop = false;
            // 
            // FormWaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WaldoFinder.Properties.Resources.waldo_background;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.imgWaldo);
            this.Name = "FormWaldo";
            this.Text = "Where\'s Waldo";
            ((System.ComponentModel.ISupportInitialize)(this.imgWaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgWaldo;
    }
}

