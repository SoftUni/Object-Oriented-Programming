namespace SoftUni.UI
{
    public class ProfessorAdminForm : System.Windows.Forms.Form
    {
        // ...
		private void InitializeComponent()
		{
		    AdministrationSystem system = new AdministrationSystem();
			this.SuspendLayout();
			// 
			// ProfessorAdminForm
			// 
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Name = "ProfessorAdminForm";
			this.Text = "Professors";
			this.ResumeLayout(false);
		}
	}
}
