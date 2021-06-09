namespace ExpedienteDigital.WindowsService
{
    partial class ProjectInstaller
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
            this.ExpedienteDigitalServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ExpedienteDigitalServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ExpedienteDigitalServiceProcessInstaller
            // 
            this.ExpedienteDigitalServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ExpedienteDigitalServiceProcessInstaller.Password = null;
            this.ExpedienteDigitalServiceProcessInstaller.Username = null;
            // 
            // ExpedienteDigitalServiceInstaller
            // 
            this.ExpedienteDigitalServiceInstaller.Description = "Administra el control de las licencias en ExpedienteDigital.com";
            this.ExpedienteDigitalServiceInstaller.DisplayName = "ExpedienteDigitalService";
            this.ExpedienteDigitalServiceInstaller.ServiceName = "ExpedienteDigitalService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ExpedienteDigitalServiceProcessInstaller,
            this.ExpedienteDigitalServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ExpedienteDigitalServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ExpedienteDigitalServiceInstaller;
    }
}