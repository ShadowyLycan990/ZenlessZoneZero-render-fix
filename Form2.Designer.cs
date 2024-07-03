namespace ZZZ_Render_Fix
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.rbDirectX11 = new System.Windows.Forms.RadioButton();
            this.rbDirectX12 = new System.Windows.Forms.RadioButton();
            this.rbOpenGL = new System.Windows.Forms.RadioButton();
            this.rbVulkan = new System.Windows.Forms.RadioButton();
            this.rbDirectX11Single = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbDirectX11
            // 
            this.rbDirectX11.AutoSize = true;
            this.rbDirectX11.Location = new System.Drawing.Point(30, 72);
            this.rbDirectX11.Name = "rbDirectX11";
            this.rbDirectX11.Size = new System.Drawing.Size(75, 17);
            this.rbDirectX11.TabIndex = 0;
            this.rbDirectX11.TabStop = true;
            this.rbDirectX11.Text = "DirectX 11";
            this.rbDirectX11.UseVisualStyleBackColor = true;
            // 
            // rbDirectX12
            // 
            this.rbDirectX12.AutoSize = true;
            this.rbDirectX12.Location = new System.Drawing.Point(30, 95);
            this.rbDirectX12.Name = "rbDirectX12";
            this.rbDirectX12.Size = new System.Drawing.Size(75, 17);
            this.rbDirectX12.TabIndex = 1;
            this.rbDirectX12.TabStop = true;
            this.rbDirectX12.Text = "DirectX 12";
            this.rbDirectX12.UseVisualStyleBackColor = true;
            // 
            // rbOpenGL
            // 
            this.rbOpenGL.AutoSize = true;
            this.rbOpenGL.Location = new System.Drawing.Point(30, 118);
            this.rbOpenGL.Name = "rbOpenGL";
            this.rbOpenGL.Size = new System.Drawing.Size(90, 17);
            this.rbOpenGL.TabIndex = 2;
            this.rbOpenGL.TabStop = true;
            this.rbOpenGL.Text = "OpenGL Core";
            this.rbOpenGL.UseVisualStyleBackColor = true;
            // 
            // rbVulkan
            // 
            this.rbVulkan.AutoSize = true;
            this.rbVulkan.Location = new System.Drawing.Point(30, 141);
            this.rbVulkan.Name = "rbVulkan";
            this.rbVulkan.Size = new System.Drawing.Size(58, 17);
            this.rbVulkan.TabIndex = 3;
            this.rbVulkan.TabStop = true;
            this.rbVulkan.Text = "Vulkan";
            this.rbVulkan.UseVisualStyleBackColor = true;
            // 
            // rbDirectX11Single
            // 
            this.rbDirectX11Single.AutoSize = true;
            this.rbDirectX11Single.Location = new System.Drawing.Point(121, 72);
            this.rbDirectX11Single.Name = "rbDirectX11Single";
            this.rbDirectX11Single.Size = new System.Drawing.Size(150, 17);
            this.rbDirectX11Single.TabIndex = 4;
            this.rbDirectX11Single.TabStop = true;
            this.rbDirectX11Single.Text = "DirectX 11 (Single Thread)";
            this.rbDirectX11Single.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(294, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(257, 225);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(213, 205);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 36);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Shortcut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose your renderer!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rbDirectX11Single);
            this.Controls.Add(this.rbVulkan);
            this.Controls.Add(this.rbOpenGL);
            this.Controls.Add(this.rbDirectX12);
            this.Controls.Add(this.rbDirectX11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Zenless Zone Zero Crash Fixer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDirectX11;
        private System.Windows.Forms.RadioButton rbDirectX12;
        private System.Windows.Forms.RadioButton rbOpenGL;
        private System.Windows.Forms.RadioButton rbVulkan;
        private System.Windows.Forms.RadioButton rbDirectX11Single;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}