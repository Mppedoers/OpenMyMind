
namespace GenshinAccount
{
    partial class Plugin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.AutoShoot = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.AutoShoot_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(11, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 21);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "抽卡记录";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.WishExport_Click);
            // 
            // AutoShoot
            // 
            this.AutoShoot.Location = new System.Drawing.Point(146, 7);
            this.AutoShoot.Margin = new System.Windows.Forms.Padding(2);
            this.AutoShoot.Name = "AutoShoot";
            this.AutoShoot.Size = new System.Drawing.Size(131, 21);
            this.AutoShoot.TabIndex = 3;
            this.AutoShoot.Text = "自动弹琴";
            this.AutoShoot.UseVisualStyleBackColor = true;
            this.AutoShoot.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 21);
            this.button2.TabIndex = 4;
            this.button2.Text = "Akebi 翻译";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Sinicization_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 32);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 21);
            this.button3.TabIndex = 5;
            this.button3.Text = "Akebi 使用守则";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Plugin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(287, 128);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AutoShoot);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Icon = global::GenshinAccount.Properties.Resources.hutao;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Plugin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "插件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button AutoShoot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}