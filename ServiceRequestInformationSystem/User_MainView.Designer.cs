namespace ServiceRequestInformationSystem
{
    partial class User_MainView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl_RequestList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_RequestList
            // 
            this.gridControl_RequestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_RequestList.Location = new System.Drawing.Point(0, 0);
            this.gridControl_RequestList.MainView = this.gridView1;
            this.gridControl_RequestList.Name = "gridControl_RequestList";
            this.gridControl_RequestList.Size = new System.Drawing.Size(733, 359);
            this.gridControl_RequestList.TabIndex = 0;
            this.gridControl_RequestList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_RequestList.Load += new System.EventHandler(this.gridControl_RequestList_Load);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl_RequestList;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // User_MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_RequestList);
            this.Name = "User_MainView";
            this.Size = new System.Drawing.Size(733, 359);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_RequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_RequestList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
