namespace tpGestionBibliothèque
{
    partial class Form1
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
            this.bt_GestionLivres = new System.Windows.Forms.Button();
            this.bt_GestionAdhérents = new System.Windows.Forms.Button();
            this.bt_GestionEmprunts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_GestionLivres
            // 
            this.bt_GestionLivres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GestionLivres.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_GestionLivres.Location = new System.Drawing.Point(150, 34);
            this.bt_GestionLivres.Name = "bt_GestionLivres";
            this.bt_GestionLivres.Size = new System.Drawing.Size(225, 74);
            this.bt_GestionLivres.TabIndex = 0;
            this.bt_GestionLivres.Text = "Gestion Livres";
            this.bt_GestionLivres.UseVisualStyleBackColor = true;
            this.bt_GestionLivres.Click += new System.EventHandler(this.bt_GestionLivres_Click);
            // 
            // bt_GestionAdhérents
            // 
            this.bt_GestionAdhérents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GestionAdhérents.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_GestionAdhérents.Location = new System.Drawing.Point(150, 155);
            this.bt_GestionAdhérents.Name = "bt_GestionAdhérents";
            this.bt_GestionAdhérents.Size = new System.Drawing.Size(225, 74);
            this.bt_GestionAdhérents.TabIndex = 1;
            this.bt_GestionAdhérents.Text = "Gestion Adhérents";
            this.bt_GestionAdhérents.UseVisualStyleBackColor = true;
            this.bt_GestionAdhérents.Click += new System.EventHandler(this.bt_GestionAdhérents_Click);
            // 
            // bt_GestionEmprunts
            // 
            this.bt_GestionEmprunts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GestionEmprunts.ForeColor = System.Drawing.Color.DarkRed;
            this.bt_GestionEmprunts.Location = new System.Drawing.Point(151, 260);
            this.bt_GestionEmprunts.Name = "bt_GestionEmprunts";
            this.bt_GestionEmprunts.Size = new System.Drawing.Size(225, 74);
            this.bt_GestionEmprunts.TabIndex = 2;
            this.bt_GestionEmprunts.Text = "Gestion Emprunts";
            this.bt_GestionEmprunts.UseVisualStyleBackColor = true;
            this.bt_GestionEmprunts.Click += new System.EventHandler(this.bt_GestionEmprunts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 373);
            this.Controls.Add(this.bt_GestionEmprunts);
            this.Controls.Add(this.bt_GestionAdhérents);
            this.Controls.Add(this.bt_GestionLivres);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_GestionLivres;
        private System.Windows.Forms.Button bt_GestionAdhérents;
        private System.Windows.Forms.Button bt_GestionEmprunts;
    }
}

