namespace Tyuiu.PavlovaVV.Sprint7.Project.V2
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            labelInfo_NVA = new Label();
            buttonOk_NVA = new Button();
            SuspendLayout();
            // 
            // labelInfo_NVA
            // 
            labelInfo_NVA.Font = new Font("Segoe UI Semibold", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInfo_NVA.Location = new Point(35, 9);
            labelInfo_NVA.Name = "labelInfo_NVA";
            labelInfo_NVA.Size = new Size(859, 418);
            labelInfo_NVA.TabIndex = 0;
            labelInfo_NVA.Text = resources.GetString("labelInfo_NVA.Text");
            labelInfo_NVA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonOk_NVA
            // 
            buttonOk_NVA.Location = new Point(591, 418);
            buttonOk_NVA.Name = "buttonOk_NVA";
            buttonOk_NVA.Size = new Size(150, 46);
            buttonOk_NVA.TabIndex = 1;
            buttonOk_NVA.Text = "OK";
            buttonOk_NVA.UseVisualStyleBackColor = true;
            buttonOk_NVA.Click += buttonOk_NVA_Click;
            // 
            // FormInstruction
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 488);
            Controls.Add(buttonOk_NVA);
            Controls.Add(labelInfo_NVA);
            Name = "FormInstruction";
            Text = "О разработчике";
            ResumeLayout(false);
        }

        #endregion

        private Label labelInfo_NVA;
        private Button buttonOk_NVA;
    }
}