namespace CreateFile
{
    partial class frmCreateFile
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
            btnSave = new Button();
            btnEnter = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar como";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(182, 282);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(91, 23);
            btnEnter.TabIndex = 9;
            btnEnter.Text = "Ingresar";
            btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(316, 282);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(89, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmCreateFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 342);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Controls.Add(btnSave);
            Name = "frmCreateFile";
            Text = "frmCreateFile";
            Controls.SetChildIndex(btnSave, 0);
            Controls.SetChildIndex(btnEnter, 0);
            Controls.SetChildIndex(btnExit, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnEnter;
        private Button btnExit;
    }
}