namespace LeaffreyRental
{
    partial class Splash
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
            this.RentButton = new System.Windows.Forms.Button();
            this.ExpensesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RentButton
            // 
            this.RentButton.AutoSize = true;
            this.RentButton.BackColor = System.Drawing.Color.ForestGreen;
            this.RentButton.BackgroundImage = global::LeaffreyRental.Properties.Resources.leaf_910532_640;
            this.RentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RentButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentButton.ForeColor = System.Drawing.Color.DarkRed;
            this.RentButton.Location = new System.Drawing.Point(67, 189);
            this.RentButton.Name = "RentButton";
            this.RentButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RentButton.Size = new System.Drawing.Size(127, 75);
            this.RentButton.TabIndex = 0;
            this.RentButton.Text = "Rent";
            this.RentButton.UseVisualStyleBackColor = false;
            this.RentButton.Click += new System.EventHandler(this.RentButton_Click);
            // 
            // ExpensesButton
            // 
            this.ExpensesButton.AutoSize = true;
            this.ExpensesButton.BackColor = System.Drawing.Color.ForestGreen;
            this.ExpensesButton.BackgroundImage = global::LeaffreyRental.Properties.Resources.Flipleaf_910532_640;
            this.ExpensesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExpensesButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpensesButton.ForeColor = System.Drawing.Color.DarkRed;
            this.ExpensesButton.Location = new System.Drawing.Point(67, 55);
            this.ExpensesButton.Name = "ExpensesButton";
            this.ExpensesButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ExpensesButton.Size = new System.Drawing.Size(127, 75);
            this.ExpensesButton.TabIndex = 1;
            this.ExpensesButton.Text = " Expenses";
            this.ExpensesButton.UseVisualStyleBackColor = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::LeaffreyRental.Properties.Resources.leaves_291024_640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(283, 340);
            this.Controls.Add(this.ExpensesButton);
            this.Controls.Add(this.RentButton);
            this.Name = "Splash";
            this.Text = "Leaffrey Management";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RentButton;
        private System.Windows.Forms.Button ExpensesButton;
    }
}

