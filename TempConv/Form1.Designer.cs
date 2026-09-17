namespace TempConv
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTempreture = new Label();
            lblDiffer = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnpoint = new Button();
            btn0 = new Button();
            btnCle = new Button();
            btnplus = new Button();
            btnDel = new Button();
            cmbUnit = new ComboBox();
            SuspendLayout();
            // 
            // lblTempreture
            // 
            lblTempreture.AutoSize = true;
            lblTempreture.BackColor = SystemColors.ActiveCaptionText;
            lblTempreture.Font = new Font("Segoe UI", 16F);
            lblTempreture.ForeColor = SystemColors.ControlLightLight;
            lblTempreture.Location = new Point(27, 35);
            lblTempreture.Name = "lblTempreture";
            lblTempreture.Padding = new Padding(20, 10, 115, 10);
            lblTempreture.Size = new Size(172, 65);
            lblTempreture.TabIndex = 17;
            lblTempreture.Text = "0";
            lblTempreture.Click += lblTempreture_Click;
            // 
            // lblDiffer
            // 
            lblDiffer.AutoSize = true;
            lblDiffer.BackColor = SystemColors.ActiveCaptionText;
            lblDiffer.Font = new Font("Segoe UI", 16F);
            lblDiffer.ForeColor = SystemColors.ControlLightLight;
            lblDiffer.Location = new Point(27, 270);
            lblDiffer.Name = "lblDiffer";
            lblDiffer.Size = new Size(166, 45);
            lblDiffer.TabIndex = 15;
            lblDiffer.Text = "labelDiffer";
            lblDiffer.Click += lblDiffer_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonHighlight;
            btn1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn1.Location = new Point(399, 30);
            btn1.Name = "btn1";
            btn1.Size = new Size(56, 55);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonHighlight;
            btn2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn2.Location = new Point(508, 30);
            btn2.Name = "btn2";
            btn2.Size = new Size(58, 55);
            btn2.TabIndex = 13;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Transparent;
            btn3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn3.Location = new Point(622, 30);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 55);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonHighlight;
            btn4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn4.Location = new Point(399, 102);
            btn4.Name = "btn4";
            btn4.Size = new Size(56, 55);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonHighlight;
            btn5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn5.Location = new Point(508, 102);
            btn5.Name = "btn5";
            btn5.Size = new Size(58, 55);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Transparent;
            btn6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn6.Location = new Point(622, 102);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 55);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonHighlight;
            btn7.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn7.Location = new Point(399, 187);
            btn7.Name = "btn7";
            btn7.Size = new Size(56, 55);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonHighlight;
            btn8.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn8.Location = new Point(508, 187);
            btn8.Name = "btn8";
            btn8.Size = new Size(58, 55);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Transparent;
            btn9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn9.Location = new Point(622, 187);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 55);
            btn9.TabIndex = 6;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnpoint
            // 
            btnpoint.BackColor = SystemColors.ButtonHighlight;
            btnpoint.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnpoint.Location = new Point(399, 260);
            btnpoint.Name = "btnpoint";
            btnpoint.Size = new Size(56, 55);
            btnpoint.TabIndex = 5;
            btnpoint.Text = ".";
            btnpoint.UseVisualStyleBackColor = false;
            btnpoint.Click += btnpoint_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ButtonHighlight;
            btn0.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btn0.Location = new Point(509, 260);
            btn0.Name = "btn0";
            btn0.Size = new Size(57, 55);
            btn0.TabIndex = 4;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnCle
            // 
            btnCle.BackColor = SystemColors.ButtonHighlight;
            btnCle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnCle.Location = new Point(399, 332);
            btnCle.Name = "btnCle";
            btnCle.Size = new Size(105, 55);
            btnCle.TabIndex = 3;
            btnCle.Text = "Clear";
            btnCle.UseVisualStyleBackColor = false;
            btnCle.Click += btnCle_Click;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.Transparent;
            btnplus.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnplus.Location = new Point(622, 260);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(60, 55);
            btnplus.TabIndex = 2;
            btnplus.Text = "+/-";
            btnplus.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.IndianRed;
            btnDel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(577, 332);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(105, 55);
            btnDel.TabIndex = 1;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // cmbUnit
            // 
            cmbUnit.BackColor = SystemColors.ControlLightLight;
            cmbUnit.Font = new Font("Segoe UI", 16F);
            cmbUnit.ForeColor = SystemColors.ActiveCaptionText;
            cmbUnit.Location = new Point(27, 159);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(196, 53);
            cmbUnit.TabIndex = 0;
            cmbUnit.SelectedIndexChanged += cmbUnit_SelectedIndexChanged;
            // 
            // Form1
            // 
            BackColor = Color.Black;
            ClientSize = new Size(708, 460);
            Controls.Add(cmbUnit);
            Controls.Add(btnDel);
            Controls.Add(btnplus);
            Controls.Add(btnCle);
            Controls.Add(btn0);
            Controls.Add(btnpoint);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblDiffer);
            Controls.Add(lblTempreture);
            Name = "Form1";
            Text = "TempConv";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTempreture;
        private Label lblDiffer;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnpoint;
        private Button btn0;
        private Button btnCle;
        private Button btnplus;
        private Button btnDel;
        private ComboBox cmbUnit;
    }
}
