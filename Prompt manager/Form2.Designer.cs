namespace Prompt_manager
{
    partial class Form2
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
            this.tb_Ult_negatives = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Ult_negatives
            // 
            this.tb_Ult_negatives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Ult_negatives.Location = new System.Drawing.Point(12, 12);
            this.tb_Ult_negatives.MaxLength = 3276700;
            this.tb_Ult_negatives.Multiline = true;
            this.tb_Ult_negatives.Name = "tb_Ult_negatives";
            this.tb_Ult_negatives.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Ult_negatives.Size = new System.Drawing.Size(776, 426);
            this.tb_Ult_negatives.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Ult_negatives);
            this.Name = "Form2";
            this.Text = "Ultimate negatives";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox tb_Ult_negatives;
    }
}