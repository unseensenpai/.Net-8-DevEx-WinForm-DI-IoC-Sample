namespace IoC.DI.WinForm.Sample
{
    partial class Container
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BBI_SubForm = new DevExpress.XtraBars.BarButtonItem();
            RP_MainMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            RPG_MainMenu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, ribbonControl1.SearchEditItem, BBI_SubForm });
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 2;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { RP_MainMenu });
            ribbonControl1.Size = new System.Drawing.Size(1278, 158);
            // 
            // BBI_SubForm
            // 
            BBI_SubForm.Caption = "SubForm";
            BBI_SubForm.Id = 1;
            BBI_SubForm.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BBI_SubForm.ImageOptions.Image");
            BBI_SubForm.Name = "BBI_SubForm";
            BBI_SubForm.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            BBI_SubForm.ItemClick += BBI_SubForm_ItemClick;
            // 
            // RP_MainMenu
            // 
            RP_MainMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { RPG_MainMenu });
            RP_MainMenu.Name = "RP_MainMenu";
            RP_MainMenu.Text = "Ana Menü";
            // 
            // RPG_MainMenu
            // 
            RPG_MainMenu.ItemLinks.Add(BBI_SubForm);
            RPG_MainMenu.Name = "RPG_MainMenu";
            RPG_MainMenu.Text = "Menü";
            // 
            // Container
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1278, 719);
            Controls.Add(ribbonControl1);
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("Container.IconOptions.Image");
            IsMdiContainer = true;
            Name = "Container";
            Ribbon = ribbonControl1;
            Text = "Container";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage RP_MainMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RPG_MainMenu;
        private DevExpress.XtraBars.BarButtonItem BBI_SubForm;
    }
}

