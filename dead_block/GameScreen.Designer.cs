
namespace dead_block
{
    partial class GameScreen
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
            this.txtammo = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.Label();
            this.txthealth = new System.Windows.Forms.Label();
            this.healthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // txtammo
            // 
            this.txtammo.AutoSize = true;
            this.txtammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtammo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtammo.Location = new System.Drawing.Point(12, 7);
            this.txtammo.Name = "txtammo";
            this.txtammo.Size = new System.Drawing.Size(93, 24);
            this.txtammo.TabIndex = 0;
            this.txtammo.Text = "Ammo: 0";
            // 
            // txtscore
            // 
            this.txtscore.AutoSize = true;
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtscore.Location = new System.Drawing.Point(330, 7);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(71, 24);
            this.txtscore.TabIndex = 2;
            this.txtscore.Text = "Kills: 0";
            // 
            // txthealth
            // 
            this.txthealth.AutoSize = true;
            this.txthealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthealth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txthealth.Location = new System.Drawing.Point(618, 7);
            this.txthealth.Name = "txthealth";
            this.txthealth.Size = new System.Drawing.Size(82, 24);
            this.txthealth.TabIndex = 3;
            this.txthealth.Text = "Health: ";
            // 
            // healthBar
            // 
            this.healthBar.Location = new System.Drawing.Point(706, 8);
            this.healthBar.Name = "healthBar";
            this.healthBar.Size = new System.Drawing.Size(169, 23);
            this.healthBar.TabIndex = 4;
            this.healthBar.Value = 100;
            // 
            // player
            // 
            this.player.Image = global::dead_block.Properties.Resources.up;
            this.player.Location = new System.Drawing.Point(414, 339);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(71, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(887, 440);
            this.Controls.Add(this.player);
            this.Controls.Add(this.healthBar);
            this.Controls.Add(this.txthealth);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtammo);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtammo;
        private System.Windows.Forms.Label txtscore;
        private System.Windows.Forms.Label txthealth;
        private System.Windows.Forms.ProgressBar healthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer GameTimer;
    }
}