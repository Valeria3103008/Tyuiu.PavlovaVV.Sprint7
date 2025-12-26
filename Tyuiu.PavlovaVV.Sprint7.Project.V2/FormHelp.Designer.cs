namespace Tyuiu.PavlovaVV.Sprint7.Project.V2
{
    partial class FormHelp
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
            textBoxQA_PVV = new TextBox();
            buttonOk2_PVV = new Button();
            SuspendLayout();
            // 
            // textBoxQA_PVV
            // 
            textBoxQA_PVV.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxQA_PVV.Location = new Point(0, 0);
            textBoxQA_PVV.Multiline = true;
            textBoxQA_PVV.Name = "textBoxQA_PVV";
            textBoxQA_PVV.Size = new Size(795, 324);
            textBoxQA_PVV.TabIndex = 0;
            textBoxQA_PVV.Text = "Если у вас появились замечания или предложения во время работы с приложением, то можете связаться с разработчиком через почту:\r\n\r\nlerochka_pavlova.08@mail.ru";
            textBoxQA_PVV.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonOk2_PVV
            // 
            buttonOk2_PVV.Location = new Point(317, 356);
            buttonOk2_PVV.Name = "buttonOk2_PVV";
            buttonOk2_PVV.Size = new Size(150, 46);
            buttonOk2_PVV.TabIndex = 1;
            buttonOk2_PVV.Text = "OK";
            buttonOk2_PVV.UseVisualStyleBackColor = true;
            buttonOk2_PVV.Click += buttonOk2_PVV_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk2_PVV);
            Controls.Add(textBoxQA_PVV);
            Name = "FormHelp";
            Text = "Поддержка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxQA_PVV;
        private Button buttonOk2_PVV;
    }
}