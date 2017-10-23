namespace ExternalMemoryWritter
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.Health = new System.Windows.Forms.Label();
            this.RiffleAmmo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy1_hp_lable = new System.Windows.Forms.Label();
            this.enemy1_xpos_lable = new System.Windows.Forms.Label();
            this.enemy1_ypos_lable = new System.Windows.Forms.Label();
            this.enemy1_zpos_lable = new System.Windows.Forms.Label();
            this.Enemy1_lable = new System.Windows.Forms.Label();
            this.localPlayer_lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assault Cube External Memory Modifier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(41, 71);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 37);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(43, 121);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(142, 35);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.Location = new System.Drawing.Point(245, 88);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(67, 20);
            this.Health.TabIndex = 3;
            this.Health.Text = "Health:";
            // 
            // RiffleAmmo
            // 
            this.RiffleAmmo.AutoSize = true;
            this.RiffleAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RiffleAmmo.Location = new System.Drawing.Point(206, 108);
            this.RiffleAmmo.Name = "RiffleAmmo";
            this.RiffleAmmo.Size = new System.Drawing.Size(106, 20);
            this.RiffleAmmo.TabIndex = 4;
            this.RiffleAmmo.Text = "Rifle Ammo:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy1_hp_lable
            // 
            this.enemy1_hp_lable.AutoSize = true;
            this.enemy1_hp_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy1_hp_lable.Location = new System.Drawing.Point(451, 88);
            this.enemy1_hp_lable.Name = "enemy1_hp_lable";
            this.enemy1_hp_lable.Size = new System.Drawing.Size(67, 20);
            this.enemy1_hp_lable.TabIndex = 5;
            this.enemy1_hp_lable.Text = "Health:";
            // 
            // enemy1_xpos_lable
            // 
            this.enemy1_xpos_lable.AutoSize = true;
            this.enemy1_xpos_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy1_xpos_lable.Location = new System.Drawing.Point(456, 111);
            this.enemy1_xpos_lable.Name = "enemy1_xpos_lable";
            this.enemy1_xpos_lable.Size = new System.Drawing.Size(62, 20);
            this.enemy1_xpos_lable.TabIndex = 6;
            this.enemy1_xpos_lable.Text = "X-Pos:";
            // 
            // enemy1_ypos_lable
            // 
            this.enemy1_ypos_lable.AutoSize = true;
            this.enemy1_ypos_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy1_ypos_lable.Location = new System.Drawing.Point(456, 136);
            this.enemy1_ypos_lable.Name = "enemy1_ypos_lable";
            this.enemy1_ypos_lable.Size = new System.Drawing.Size(62, 20);
            this.enemy1_ypos_lable.TabIndex = 7;
            this.enemy1_ypos_lable.Text = "Y-Pos:";
            // 
            // enemy1_zpos_lable
            // 
            this.enemy1_zpos_lable.AutoSize = true;
            this.enemy1_zpos_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemy1_zpos_lable.Location = new System.Drawing.Point(456, 166);
            this.enemy1_zpos_lable.Name = "enemy1_zpos_lable";
            this.enemy1_zpos_lable.Size = new System.Drawing.Size(61, 20);
            this.enemy1_zpos_lable.TabIndex = 8;
            this.enemy1_zpos_lable.Text = "Z-Pos:";
            // 
            // Enemy1_lable
            // 
            this.Enemy1_lable.AutoSize = true;
            this.Enemy1_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy1_lable.Location = new System.Drawing.Point(456, 42);
            this.Enemy1_lable.Name = "Enemy1_lable";
            this.Enemy1_lable.Size = new System.Drawing.Size(92, 24);
            this.Enemy1_lable.TabIndex = 9;
            this.Enemy1_lable.Text = "Enemy 1";
            // 
            // localPlayer_lable
            // 
            this.localPlayer_lable.AutoSize = true;
            this.localPlayer_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localPlayer_lable.Location = new System.Drawing.Point(245, 39);
            this.localPlayer_lable.Name = "localPlayer_lable";
            this.localPlayer_lable.Size = new System.Drawing.Size(124, 24);
            this.localPlayer_lable.TabIndex = 10;
            this.localPlayer_lable.Text = "Local Player";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 311);
            this.Controls.Add(this.localPlayer_lable);
            this.Controls.Add(this.Enemy1_lable);
            this.Controls.Add(this.enemy1_zpos_lable);
            this.Controls.Add(this.enemy1_ypos_lable);
            this.Controls.Add(this.enemy1_xpos_lable);
            this.Controls.Add(this.enemy1_hp_lable);
            this.Controls.Add(this.RiffleAmmo);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label RiffleAmmo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label enemy1_hp_lable;
        private System.Windows.Forms.Label enemy1_xpos_lable;
        private System.Windows.Forms.Label enemy1_ypos_lable;
        private System.Windows.Forms.Label enemy1_zpos_lable;
        private System.Windows.Forms.Label Enemy1_lable;
        private System.Windows.Forms.Label localPlayer_lable;
    }
}

