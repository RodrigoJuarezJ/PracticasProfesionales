
namespace PracticasProfesionales
{
    partial class FrmMenú
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdviser = new MetroFramework.Controls.MetroButton();
            this.btnCoach = new MetroFramework.Controls.MetroButton();
            this.btnCompany = new MetroFramework.Controls.MetroButton();
            this.btnContact = new MetroFramework.Controls.MetroButton();
            this.btnCoordinator = new MetroFramework.Controls.MetroButton();
            this.btnStudent = new MetroFramework.Controls.MetroButton();
            this.btnMajor = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnAdviser
            // 
            this.btnAdviser.Location = new System.Drawing.Point(35, 78);
            this.btnAdviser.Name = "btnAdviser";
            this.btnAdviser.Size = new System.Drawing.Size(144, 45);
            this.btnAdviser.TabIndex = 0;
            this.btnAdviser.Text = "Adviser";
            this.btnAdviser.UseSelectable = true;
            this.btnAdviser.Click += new System.EventHandler(this.btnAdviser_Click);
            // 
            // btnCoach
            // 
            this.btnCoach.Location = new System.Drawing.Point(239, 78);
            this.btnCoach.Name = "btnCoach";
            this.btnCoach.Size = new System.Drawing.Size(144, 45);
            this.btnCoach.TabIndex = 1;
            this.btnCoach.Text = "Coach";
            this.btnCoach.UseSelectable = true;
            this.btnCoach.Click += new System.EventHandler(this.btnCoach_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(439, 78);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(144, 45);
            this.btnCompany.TabIndex = 2;
            this.btnCompany.Text = "Company";
            this.btnCompany.UseSelectable = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(35, 170);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(144, 45);
            this.btnContact.TabIndex = 3;
            this.btnContact.Text = "Contact";
            this.btnContact.UseSelectable = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnCoordinator
            // 
            this.btnCoordinator.Location = new System.Drawing.Point(239, 170);
            this.btnCoordinator.Name = "btnCoordinator";
            this.btnCoordinator.Size = new System.Drawing.Size(144, 45);
            this.btnCoordinator.TabIndex = 4;
            this.btnCoordinator.Text = "Coordinator";
            this.btnCoordinator.UseSelectable = true;
            this.btnCoordinator.Click += new System.EventHandler(this.btnCoordinator_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(439, 170);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(144, 45);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseSelectable = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnMajor
            // 
            this.btnMajor.Location = new System.Drawing.Point(239, 254);
            this.btnMajor.Name = "btnMajor";
            this.btnMajor.Size = new System.Drawing.Size(144, 45);
            this.btnMajor.TabIndex = 6;
            this.btnMajor.Text = "Major";
            this.btnMajor.UseSelectable = true;
            this.btnMajor.Click += new System.EventHandler(this.btnMajor_Click);
            // 
            // FrmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 320);
            this.Controls.Add(this.btnMajor);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnCoordinator);
            this.Controls.Add(this.btnContact);
            this.Controls.Add(this.btnCompany);
            this.Controls.Add(this.btnCoach);
            this.Controls.Add(this.btnAdviser);
            this.Name = "FrmMenú";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdviser;
        private MetroFramework.Controls.MetroButton btnCoach;
        private MetroFramework.Controls.MetroButton btnCompany;
        private MetroFramework.Controls.MetroButton btnContact;
        private MetroFramework.Controls.MetroButton btnCoordinator;
        private MetroFramework.Controls.MetroButton btnStudent;
        private MetroFramework.Controls.MetroButton btnMajor;
    }
}

