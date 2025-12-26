namespace Tyuiu.PavlovaVV.Sprint7.Project.V2
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInstruction_PVV = new Label();
            SuspendLayout();
            // 
            // labelInstruction_PVV
            // 
            labelInstruction_PVV.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInstruction_PVV.Location = new Point(12, 9);
            labelInstruction_PVV.Name = "labelInstruction_PVV";
            labelInstruction_PVV.Size = new Size(871, 463);
            labelInstruction_PVV.TabIndex = 0;
            labelInstruction_PVV.Text = resources.GetString("labelInstruction_PVV.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 481);
            Controls.Add(labelInstruction_PVV);
            Name = "FormAbout";
            Text = "Руководство пользователя";
            ResumeLayout(false);
        }

        #endregion

        private Label labelInstruction_PVV;
    }
}