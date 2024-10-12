
namespace stop_Watch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hourlb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seclb = new System.Windows.Forms.Label();
            this.msiclb = new System.Windows.Forms.Label();
            this.minlb = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "hour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stop Watch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // hourlb
            // 
            this.hourlb.AutoSize = true;
            this.hourlb.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlb.Location = new System.Drawing.Point(103, 171);
            this.hourlb.Name = "hourlb";
            this.hourlb.Size = new System.Drawing.Size(32, 21);
            this.hourlb.TabIndex = 2;
            this.hourlb.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Micro Sec";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(287, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // seclb
            // 
            this.seclb.AutoSize = true;
            this.seclb.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seclb.Location = new System.Drawing.Point(459, 171);
            this.seclb.Name = "seclb";
            this.seclb.Size = new System.Drawing.Size(32, 21);
            this.seclb.TabIndex = 6;
            this.seclb.Text = "00";
            this.seclb.Click += new System.EventHandler(this.label7_Click);
            // 
            // msiclb
            // 
            this.msiclb.AutoSize = true;
            this.msiclb.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msiclb.Location = new System.Drawing.Point(642, 171);
            this.msiclb.Name = "msiclb";
            this.msiclb.Size = new System.Drawing.Size(32, 21);
            this.msiclb.TabIndex = 7;
            this.msiclb.Text = "00";
            // 
            // minlb
            // 
            this.minlb.AutoSize = true;
            this.minlb.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minlb.Location = new System.Drawing.Point(293, 171);
            this.minlb.Name = "minlb";
            this.minlb.Size = new System.Drawing.Size(32, 21);
            this.minlb.TabIndex = 8;
            this.minlb.Text = "00";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(88, 223);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 9;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(261, 223);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 10;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(440, 223);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(75, 23);
            this.resume.TabIndex = 11;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(621, 223);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 12;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.minlb);
            this.Controls.Add(this.msiclb);
            this.Controls.Add(this.seclb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hourlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hourlb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label seclb;
        private System.Windows.Forms.Label msiclb;
        private System.Windows.Forms.Label minlb;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Timer timer1;
    }
}

