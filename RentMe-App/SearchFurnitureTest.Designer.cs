
namespace RentMe_App
{
    partial class SearchFurnitureTest
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
            this.searchFurnitureUserControl1 = new RentMe_App.UserControls.SearchFurnitureUserControl();
            this.SuspendLayout();
            // 
            // searchFurnitureUserControl1
            // 
            this.searchFurnitureUserControl1.Location = new System.Drawing.Point(16, 5);
            this.searchFurnitureUserControl1.Name = "searchFurnitureUserControl1";
            this.searchFurnitureUserControl1.Size = new System.Drawing.Size(800, 500);
            this.searchFurnitureUserControl1.TabIndex = 0;
            // 
            // SearchFurnitureTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.searchFurnitureUserControl1);
            this.Name = "SearchFurnitureTest";
            this.Text = "Test Search Furniture Control";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.SearchFurnitureUserControl searchFurnitureUserControl1;
    }
}

