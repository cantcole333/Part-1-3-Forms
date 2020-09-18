namespace Part_1_3_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.lblInstructionName = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblInstructionAge = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblInstrucionHeight = new System.Windows.Forms.Label();
            this.txtInputHeight = new System.Windows.Forms.TextBox();
            this.barAge = new System.Windows.Forms.TrackBar();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(0, 12);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(181, 27);
            this.txtInputName.TabIndex = 0;
            this.txtInputName.TextChanged += new System.EventHandler(this.txtInputName_TextChanged);
            // 
            // lblInstructionName
            // 
            this.lblInstructionName.AutoSize = true;
            this.lblInstructionName.Location = new System.Drawing.Point(0, 471);
            this.lblInstructionName.Name = "lblInstructionName";
            this.lblInstructionName.Size = new System.Drawing.Size(166, 20);
            this.lblInstructionName.TabIndex = 1;
            this.lblInstructionName.Text = "Please enter your name:";
            this.lblInstructionName.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(0, 444);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(1517, 27);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Click Me";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInstructionAge
            // 
            this.lblInstructionAge.AutoSize = true;
            this.lblInstructionAge.Location = new System.Drawing.Point(0, 424);
            this.lblInstructionAge.Name = "lblInstructionAge";
            this.lblInstructionAge.Size = new System.Drawing.Size(154, 20);
            this.lblInstructionAge.TabIndex = 4;
            this.lblInstructionAge.Text = "Please enter your age:";
            this.lblInstructionAge.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(0, 404);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(117, 20);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "jjjjjjjjjjjjjjjjjjjjjjjjjjj";
            this.lblMessage.Click += new System.EventHandler(this.lblMessageAge_Click);
            // 
            // lblInstrucionHeight
            // 
            this.lblInstrucionHeight.AutoSize = true;
            this.lblInstrucionHeight.Location = new System.Drawing.Point(0, 384);
            this.lblInstrucionHeight.Name = "lblInstrucionHeight";
            this.lblInstrucionHeight.Size = new System.Drawing.Size(386, 20);
            this.lblInstrucionHeight.TabIndex = 9;
            this.lblInstrucionHeight.Text = "Please enter your height in meters to two decimal places:";
            this.lblInstrucionHeight.Click += new System.EventHandler(this.lblInstrucionHeight_Click);
            // 
            // txtInputHeight
            // 
            this.txtInputHeight.Location = new System.Drawing.Point(0, 357);
            this.txtInputHeight.Name = "txtInputHeight";
            this.txtInputHeight.Size = new System.Drawing.Size(1517, 27);
            this.txtInputHeight.TabIndex = 10;
            this.txtInputHeight.TextChanged += new System.EventHandler(this.txtInputHeight_TextChanged);
            // 
            // barAge
            // 
            this.barAge.Location = new System.Drawing.Point(0, 301);
            this.barAge.Maximum = 50;
            this.barAge.Name = "barAge";
            this.barAge.Size = new System.Drawing.Size(1517, 56);
            this.barAge.TabIndex = 11;
            this.barAge.Scroll += new System.EventHandler(this.barAge_Scroll);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(0, 281);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 20);
            this.lblAge.TabIndex = 12;
            this.lblAge.Click += new System.EventHandler(this.lblAge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 518);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.barAge);
            this.Controls.Add(this.txtInputHeight);
            this.Controls.Add(this.lblInstrucionHeight);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblInstructionAge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInstructionName);
            this.Controls.Add(this.txtInputName);
            this.Name = "Form1";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.Label lblInstructionName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblInstructionAge;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblInstrucionHeight;
        private System.Windows.Forms.TextBox txtInputHeight;
        private System.Windows.Forms.TrackBar barAge;
        private System.Windows.Forms.Label lblAge;
    }
}

