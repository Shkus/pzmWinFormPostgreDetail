namespace pzmWinFormPostgre
{
	partial class MainForm
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
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.DGV_loadDetails = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DGV_loadDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView2
			// 
			this.treeView2.Location = new System.Drawing.Point(576, 49);
			this.treeView2.Name = "treeView2";
			this.treeView2.Size = new System.Drawing.Size(531, 372);
			this.treeView2.TabIndex = 2;
			// 
			// DGV_loadDetails
			// 
			this.DGV_loadDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_loadDetails.Location = new System.Drawing.Point(32, 49);
			this.DGV_loadDetails.Name = "DGV_loadDetails";
			this.DGV_loadDetails.Size = new System.Drawing.Size(519, 372);
			this.DGV_loadDetails.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1181, 450);
			this.Controls.Add(this.DGV_loadDetails);
			this.Controls.Add(this.treeView2);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_loadDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.DataGridView DGV_loadDetails;
	}
}