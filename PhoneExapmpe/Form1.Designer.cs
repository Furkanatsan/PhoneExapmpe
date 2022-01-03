
namespace PhoneExapmpe
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
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnIphone = new System.Windows.Forms.Button();
            this.btnNokia = new System.Windows.Forms.Button();
            this.btnSamsung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDefault.Location = new System.Drawing.Point(76, 31);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(143, 75);
            this.btnDefault.TabIndex = 0;
            this.btnDefault.Text = "DEFAULT";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnIphone
            // 
            this.btnIphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIphone.Location = new System.Drawing.Point(76, 112);
            this.btnIphone.Name = "btnIphone";
            this.btnIphone.Size = new System.Drawing.Size(143, 75);
            this.btnIphone.TabIndex = 1;
            this.btnIphone.Text = "IPHONE";
            this.btnIphone.UseVisualStyleBackColor = true;
            this.btnIphone.Click += new System.EventHandler(this.btnIphone_Click);
            // 
            // btnNokia
            // 
            this.btnNokia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNokia.Location = new System.Drawing.Point(76, 193);
            this.btnNokia.Name = "btnNokia";
            this.btnNokia.Size = new System.Drawing.Size(143, 75);
            this.btnNokia.TabIndex = 1;
            this.btnNokia.Text = "NOKIA";
            this.btnNokia.UseVisualStyleBackColor = true;
            this.btnNokia.Click += new System.EventHandler(this.btnNokia_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSamsung.Location = new System.Drawing.Point(76, 274);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(143, 75);
            this.btnSamsung.TabIndex = 1;
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.UseVisualStyleBackColor = true;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "abstract: soyut=>abstract calass,interface\r\nconcrete: somut=>class,newlanabilenle" +
    "r";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.btnNokia);
            this.Controls.Add(this.btnIphone);
            this.Controls.Add(this.btnDefault);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnIphone;
        private System.Windows.Forms.Button btnNokia;
        private System.Windows.Forms.Button btnSamsung;
        private System.Windows.Forms.Label label1;
    }
}

