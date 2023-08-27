namespace IoC.DI.WinForm.Sample.Forms
{
    partial class SubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubForm));
            ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            BBI_GetEmployees = new DevExpress.XtraBars.BarButtonItem();
            BBI_AddEmployee = new DevExpress.XtraBars.BarButtonItem();
            RP_Services = new DevExpress.XtraBars.Ribbon.RibbonPage();
            RPG_Employee = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            GC_Employees = new DevExpress.XtraGrid.GridControl();
            GV_Employees = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)ribbon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GC_Employees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GV_Employees).BeginInit();
            SuspendLayout();
            // 
            // ribbon
            // 
            ribbon.ExpandCollapseItem.Id = 0;
            ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbon.ExpandCollapseItem, ribbon.SearchEditItem, BBI_GetEmployees, BBI_AddEmployee });
            ribbon.Location = new System.Drawing.Point(0, 0);
            ribbon.MaxItemId = 3;
            ribbon.Name = "ribbon";
            ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { RP_Services });
            ribbon.Size = new System.Drawing.Size(442, 158);
            ribbon.StatusBar = ribbonStatusBar;
            // 
            // BBI_GetEmployees
            // 
            BBI_GetEmployees.Caption = "Employees";
            BBI_GetEmployees.Id = 1;
            BBI_GetEmployees.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BBI_GetEmployees.ImageOptions.Image");
            BBI_GetEmployees.Name = "BBI_GetEmployees";
            BBI_GetEmployees.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            BBI_GetEmployees.ItemClick += BBI_GetEmployees_ItemClick;
            // 
            // BBI_AddEmployee
            // 
            BBI_AddEmployee.Caption = "Add Employee";
            BBI_AddEmployee.Id = 2;
            BBI_AddEmployee.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("BBI_AddEmployee.ImageOptions.Image");
            BBI_AddEmployee.ImageOptions.LargeImage = (System.Drawing.Image)resources.GetObject("BBI_AddEmployee.ImageOptions.LargeImage");
            BBI_AddEmployee.Name = "BBI_AddEmployee";
            BBI_AddEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            BBI_AddEmployee.ItemClick += BBI_AddEmployee_ItemClick;
            // 
            // RP_Services
            // 
            RP_Services.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { RPG_Employee });
            RP_Services.Name = "RP_Services";
            RP_Services.Text = "Services";
            // 
            // RPG_Employee
            // 
            RPG_Employee.ItemLinks.Add(BBI_GetEmployees);
            RPG_Employee.ItemLinks.Add(BBI_AddEmployee);
            RPG_Employee.Name = "RPG_Employee";
            RPG_Employee.Text = "Employee";
            // 
            // ribbonStatusBar
            // 
            ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            ribbonStatusBar.Name = "ribbonStatusBar";
            ribbonStatusBar.Ribbon = ribbon;
            ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // GC_Employees
            // 
            GC_Employees.Dock = System.Windows.Forms.DockStyle.Fill;
            GC_Employees.Location = new System.Drawing.Point(0, 158);
            GC_Employees.MainView = GV_Employees;
            GC_Employees.MenuManager = ribbon;
            GC_Employees.Name = "GC_Employees";
            GC_Employees.Size = new System.Drawing.Size(442, 267);
            GC_Employees.TabIndex = 2;
            GC_Employees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { GV_Employees });
            // 
            // GV_Employees
            // 
            GV_Employees.GridControl = GC_Employees;
            GV_Employees.Name = "GV_Employees";
            // 
            // SubForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(442, 449);
            Controls.Add(GC_Employees);
            Controls.Add(ribbonStatusBar);
            Controls.Add(ribbon);
            Name = "SubForm";
            Ribbon = ribbon;
            StatusBar = ribbonStatusBar;
            Text = "SubForm";
            ((System.ComponentModel.ISupportInitialize)ribbon).EndInit();
            ((System.ComponentModel.ISupportInitialize)GC_Employees).EndInit();
            ((System.ComponentModel.ISupportInitialize)GV_Employees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage RP_Services;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RPG_Employee;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BBI_GetEmployees;
        private DevExpress.XtraBars.BarButtonItem BBI_AddEmployee;
        private DevExpress.XtraGrid.GridControl GC_Employees;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_Employees;
    }
}