namespace Timer
{
    partial class Timer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.Min = new System.Windows.Forms.RichTextBox();
            this.Sec = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hour = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Min
            // 
            this.Min.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Min.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Min.Location = new System.Drawing.Point(132, 22);
            this.Min.MaxLength = 2;
            this.Min.Multiline = false;
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(60, 60);
            this.Min.TabIndex = 0;
            this.Min.Text = "";
            this.Min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox2_KeyPress);
            // 
            // Sec
            // 
            this.Sec.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sec.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Sec.Location = new System.Drawing.Point(255, 22);
            this.Sec.MaxLength = 2;
            this.Sec.Multiline = false;
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(60, 60);
            this.Sec.TabIndex = 1;
            this.Sec.Text = "";
            this.Sec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Hour
            // 
            this.Hour.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hour.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Hour.Location = new System.Drawing.Point(9, 22);
            this.Hour.MaxLength = 2;
            this.Hour.Multiline = false;
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(60, 60);
            this.Hour.TabIndex = 3;
            this.Hour.Text = "";
            this.Hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RichTextBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(77, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 64);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(137, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 11);
            this.label3.TabIndex = 8;
            this.label3.Text = "by Tom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 6;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "                ";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 177);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.Min);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.Text = "計時器";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Min;
        private System.Windows.Forms.RichTextBox Sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox Hour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

