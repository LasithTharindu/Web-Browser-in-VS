namespace Browser
{
    partial class From1
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
            this.bntBack = new System.Windows.Forms.Button();
            this.bntForward = new System.Windows.Forms.Button();
            this.bntGo = new System.Windows.Forms.Button();
            this.bntNewtab = new System.Windows.Forms.Button();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntBack
            // 
            this.bntBack.Location = new System.Drawing.Point(12, 12);
            this.bntBack.Name = "bntBack";
            this.bntBack.Size = new System.Drawing.Size(36, 23);
            this.bntBack.TabIndex = 0;
            this.bntBack.Text = "<";
            this.bntBack.UseVisualStyleBackColor = true;
            this.bntBack.Click += new System.EventHandler(this.bntBack_Click);
            // 
            // bntForward
            // 
            this.bntForward.Location = new System.Drawing.Point(54, 12);
            this.bntForward.Name = "bntForward";
            this.bntForward.Size = new System.Drawing.Size(36, 23);
            this.bntForward.TabIndex = 1;
            this.bntForward.Text = ">";
            this.bntForward.UseVisualStyleBackColor = true;
            this.bntForward.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntGo
            // 
            this.bntGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntGo.Location = new System.Drawing.Point(779, 11);
            this.bntGo.Name = "bntGo";
            this.bntGo.Size = new System.Drawing.Size(42, 23);
            this.bntGo.TabIndex = 2;
            this.bntGo.Text = "Go";
            this.bntGo.UseVisualStyleBackColor = true;
            this.bntGo.Click += new System.EventHandler(this.bntGo_Click);
            // 
            // bntNewtab
            // 
            this.bntNewtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntNewtab.Location = new System.Drawing.Point(827, 12);
            this.bntNewtab.Name = "bntNewtab";
            this.bntNewtab.Size = new System.Drawing.Size(75, 23);
            this.bntNewtab.TabIndex = 3;
            this.bntNewtab.Text = "New Tab";
            this.bntNewtab.UseVisualStyleBackColor = true;
            this.bntNewtab.Click += new System.EventHandler(this.bntNewtab_Click);
            // 
            // textUrl
            // 
            this.textUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textUrl.Location = new System.Drawing.Point(134, 14);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(625, 20);
            this.textUrl.TabIndex = 4;
            this.textUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textUrl_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(949, 476);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(941, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(935, 444);
            this.webBrowser.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(908, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 529);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.bntNewtab);
            this.Controls.Add(this.bntGo);
            this.Controls.Add(this.bntForward);
            this.Controls.Add(this.bntBack);
            this.Name = "From1";
            this.Text = "WebBrowser";
            this.Load += new System.EventHandler(this.From1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBack;
        private System.Windows.Forms.Button bntForward;
        private System.Windows.Forms.Button bntGo;
        private System.Windows.Forms.Button bntNewtab;
        private System.Windows.Forms.TextBox textUrl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button button5;
    }
}

