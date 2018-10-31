namespace Exam2
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
            this.picBx1 = new System.Windows.Forms.PictureBox();
            this.picBx2 = new System.Windows.Forms.PictureBox();
            this.picBx3 = new System.Windows.Forms.PictureBox();
            this.rollBtn = new System.Windows.Forms.Button();
            this.gamblerBtn = new System.Windows.Forms.Button();
            this.startPanel = new System.Windows.Forms.Panel();
            this.txtBtnStarting = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.txtBtnLoss = new System.Windows.Forms.TextBox();
            this.txtBtnGain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBtnCurrentCash = new System.Windows.Forms.TextBox();
            this.txtBtnStartingCash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).BeginInit();
            this.startPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBx1
            // 
            this.picBx1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picBx1.BackgroundImage = global::Exam2.Properties.Resources.bg3;
            this.picBx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx1.Enabled = false;
            this.picBx1.Image = global::Exam2.Properties.Resources.starterSlot;
            this.picBx1.Location = new System.Drawing.Point(28, 95);
            this.picBx1.Name = "picBx1";
            this.picBx1.Size = new System.Drawing.Size(100, 99);
            this.picBx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx1.TabIndex = 1;
            this.picBx1.TabStop = false;
            this.picBx1.Visible = false;
            // 
            // picBx2
            // 
            this.picBx2.BackgroundImage = global::Exam2.Properties.Resources.bg3;
            this.picBx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx2.Enabled = false;
            this.picBx2.Image = global::Exam2.Properties.Resources.starterSlot;
            this.picBx2.Location = new System.Drawing.Point(162, 95);
            this.picBx2.Name = "picBx2";
            this.picBx2.Size = new System.Drawing.Size(100, 99);
            this.picBx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx2.TabIndex = 2;
            this.picBx2.TabStop = false;
            this.picBx2.Visible = false;
            // 
            // picBx3
            // 
            this.picBx3.BackgroundImage = global::Exam2.Properties.Resources.bg3;
            this.picBx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBx3.Enabled = false;
            this.picBx3.Image = global::Exam2.Properties.Resources.starterSlot;
            this.picBx3.Location = new System.Drawing.Point(296, 95);
            this.picBx3.Name = "picBx3";
            this.picBx3.Size = new System.Drawing.Size(100, 99);
            this.picBx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBx3.TabIndex = 3;
            this.picBx3.TabStop = false;
            this.picBx3.Visible = false;
            // 
            // rollBtn
            // 
            this.rollBtn.BackgroundImage = global::Exam2.Properties.Resources.bg3;
            this.rollBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollBtn.Enabled = false;
            this.rollBtn.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rollBtn.Location = new System.Drawing.Point(106, 284);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(213, 57);
            this.rollBtn.TabIndex = 4;
            this.rollBtn.Text = "Get rolling, Creep.";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Visible = false;
            this.rollBtn.Click += new System.EventHandler(this.rollBtn_Click);
            // 
            // gamblerBtn
            // 
            this.gamblerBtn.BackgroundImage = global::Exam2.Properties.Resources.bg3;
            this.gamblerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamblerBtn.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamblerBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gamblerBtn.Location = new System.Drawing.Point(114, 250);
            this.gamblerBtn.Name = "gamblerBtn";
            this.gamblerBtn.Size = new System.Drawing.Size(134, 57);
            this.gamblerBtn.TabIndex = 5;
            this.gamblerBtn.Text = "Go Gambler";
            this.gamblerBtn.UseVisualStyleBackColor = true;
            this.gamblerBtn.Click += new System.EventHandler(this.gamblerBtn_Click);
            // 
            // startPanel
            // 
            this.startPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.startPanel.BackgroundImage = global::Exam2.Properties.Resources.bg5;
            this.startPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.startPanel.Controls.Add(this.label7);
            this.startPanel.Controls.Add(this.txtBtnStarting);
            this.startPanel.Controls.Add(this.label1);
            this.startPanel.Controls.Add(this.gamblerBtn);
            this.startPanel.Location = new System.Drawing.Point(176, 26);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(363, 334);
            this.startPanel.TabIndex = 6;
            // 
            // txtBtnStarting
            // 
            this.txtBtnStarting.Location = new System.Drawing.Point(114, 143);
            this.txtBtnStarting.Name = "txtBtnStarting";
            this.txtBtnStarting.Size = new System.Drawing.Size(134, 23);
            this.txtBtnStarting.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "What Are ya Spending, Stranger?";
            // 
            // statsPanel
            // 
            this.statsPanel.BackgroundImage = global::Exam2.Properties.Resources.bg5;
            this.statsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statsPanel.Controls.Add(this.txtBtnLoss);
            this.statsPanel.Controls.Add(this.txtBtnGain);
            this.statsPanel.Controls.Add(this.label6);
            this.statsPanel.Controls.Add(this.label5);
            this.statsPanel.Controls.Add(this.label4);
            this.statsPanel.Controls.Add(this.txtBtnCurrentCash);
            this.statsPanel.Controls.Add(this.txtBtnStartingCash);
            this.statsPanel.Controls.Add(this.label3);
            this.statsPanel.Controls.Add(this.label2);
            this.statsPanel.Enabled = false;
            this.statsPanel.Location = new System.Drawing.Point(473, 31);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(219, 334);
            this.statsPanel.TabIndex = 7;
            this.statsPanel.Visible = false;
            // 
            // txtBtnLoss
            // 
            this.txtBtnLoss.Enabled = false;
            this.txtBtnLoss.Location = new System.Drawing.Point(155, 280);
            this.txtBtnLoss.Name = "txtBtnLoss";
            this.txtBtnLoss.Size = new System.Drawing.Size(45, 23);
            this.txtBtnLoss.TabIndex = 15;
            // 
            // txtBtnGain
            // 
            this.txtBtnGain.Enabled = false;
            this.txtBtnGain.Location = new System.Drawing.Point(19, 280);
            this.txtBtnGain.Name = "txtBtnGain";
            this.txtBtnGain.Size = new System.Drawing.Size(45, 23);
            this.txtBtnGain.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(155, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Loss";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "This Round: Gain/Loss";
            // 
            // txtBtnCurrentCash
            // 
            this.txtBtnCurrentCash.Enabled = false;
            this.txtBtnCurrentCash.Location = new System.Drawing.Point(54, 151);
            this.txtBtnCurrentCash.Name = "txtBtnCurrentCash";
            this.txtBtnCurrentCash.Size = new System.Drawing.Size(108, 23);
            this.txtBtnCurrentCash.TabIndex = 10;
            // 
            // txtBtnStartingCash
            // 
            this.txtBtnStartingCash.Enabled = false;
            this.txtBtnStartingCash.Location = new System.Drawing.Point(56, 62);
            this.txtBtnStartingCash.Name = "txtBtnStartingCash";
            this.txtBtnStartingCash.Size = new System.Drawing.Size(105, 23);
            this.txtBtnStartingCash.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Cash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Starting Cash";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(28, 26);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(2, 20);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(74, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Min: $0.10  -  Max: $10.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Exam2.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 398);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.picBx3);
            this.Controls.Add(this.picBx2);
            this.Controls.Add(this.picBx1);
            this.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Killer Is 7 Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx3)).EndInit();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.statsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Gambler myGambler;
        private System.Windows.Forms.PictureBox picBx1;
        private System.Windows.Forms.PictureBox picBx2;
        private System.Windows.Forms.PictureBox picBx3;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Button gamblerBtn;
        private System.Windows.Forms.Panel startPanel;
        private System.Windows.Forms.TextBox txtBtnStarting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.TextBox txtBtnLoss;
        private System.Windows.Forms.TextBox txtBtnGain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBtnCurrentCash;
        private System.Windows.Forms.TextBox txtBtnStartingCash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label7;
    }
}

