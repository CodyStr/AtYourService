namespace WindowsFormsApplication1
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
            this.BTNForward = new System.Windows.Forms.Button();
            this.BTNLeft = new System.Windows.Forms.Button();
            this.BTNBackwards = new System.Windows.Forms.Button();
            this.BTNRight = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTouch = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNForward
            // 
            this.BTNForward.Font = new System.Drawing.Font("Wingdings", 32F);
            this.BTNForward.Location = new System.Drawing.Point(89, 24);
            this.BTNForward.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNForward.Name = "BTNForward";
            this.BTNForward.Size = new System.Drawing.Size(59, 64);
            this.BTNForward.TabIndex = 0;
            this.BTNForward.Text = "á";
            this.BTNForward.UseVisualStyleBackColor = true;
            this.BTNForward.Click += new System.EventHandler(this.BTNForward_Click);
            // 
            // BTNLeft
            // 
            this.BTNLeft.Font = new System.Drawing.Font("Wingdings", 32F);
            this.BTNLeft.Location = new System.Drawing.Point(35, 80);
            this.BTNLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNLeft.Name = "BTNLeft";
            this.BTNLeft.Size = new System.Drawing.Size(56, 58);
            this.BTNLeft.TabIndex = 1;
            this.BTNLeft.Text = "ß";
            this.BTNLeft.UseVisualStyleBackColor = true;
            this.BTNLeft.Click += new System.EventHandler(this.BTNLeft_Click);
            // 
            // BTNBackwards
            // 
            this.BTNBackwards.Font = new System.Drawing.Font("Wingdings", 32F);
            this.BTNBackwards.Location = new System.Drawing.Point(89, 80);
            this.BTNBackwards.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNBackwards.Name = "BTNBackwards";
            this.BTNBackwards.Size = new System.Drawing.Size(59, 58);
            this.BTNBackwards.TabIndex = 2;
            this.BTNBackwards.Text = "â";
            this.BTNBackwards.UseVisualStyleBackColor = true;
            this.BTNBackwards.Click += new System.EventHandler(this.BTNBackwards_Click);
            // 
            // BTNRight
            // 
            this.BTNRight.Font = new System.Drawing.Font("Wingdings", 32F);
            this.BTNRight.Location = new System.Drawing.Point(146, 80);
            this.BTNRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNRight.Name = "BTNRight";
            this.BTNRight.Size = new System.Drawing.Size(59, 58);
            this.BTNRight.TabIndex = 3;
            this.BTNRight.Text = "à";
            this.BTNRight.UseVisualStyleBackColor = true;
            this.BTNRight.Click += new System.EventHandler(this.BTNRight_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(16, 181);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 15;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(210, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 15;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(350, 36);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDistance.Multiline = true;
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(57, 21);
            this.txtDistance.TabIndex = 5;
            this.txtDistance.Text = "TextBlock";
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Afstand sensor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Druk knop";
            // 
            // txtTouch
            // 
            this.txtTouch.Location = new System.Drawing.Point(350, 80);
            this.txtTouch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTouch.Multiline = true;
            this.txtTouch.Name = "txtTouch";
            this.txtTouch.Size = new System.Drawing.Size(57, 21);
            this.txtTouch.TabIndex = 8;
            this.txtTouch.Text = "TextBlock";
            this.txtTouch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(350, 124);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(57, 22);
            this.txtColor.TabIndex = 9;
            this.txtColor.Text = "TextBlock";
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kleuren sensor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 320);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtTouch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BTNRight);
            this.Controls.Add(this.BTNBackwards);
            this.Controls.Add(this.BTNLeft);
            this.Controls.Add(this.BTNForward);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNForward;
        private System.Windows.Forms.Button BTNLeft;
        private System.Windows.Forms.Button BTNBackwards;
        private System.Windows.Forms.Button BTNRight;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTouch;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label3;
    }
}

