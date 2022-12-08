namespace ProjectStudents.UI
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
            this.t_address = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_age = new System.Windows.Forms.TextBox();
            this.t_fullName = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Retrieval = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(498, 80);
            this.t_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(148, 26);
            this.t_address.TabIndex = 0;
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(657, 80);
            this.t_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(148, 26);
            this.t_id.TabIndex = 1;
            // 
            // t_age
            // 
            this.t_age.Location = new System.Drawing.Point(339, 80);
            this.t_age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_age.Name = "t_age";
            this.t_age.Size = new System.Drawing.Size(148, 26);
            this.t_age.TabIndex = 2;
            // 
            // t_fullName
            // 
            this.t_fullName.Location = new System.Drawing.Point(180, 80);
            this.t_fullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.t_fullName.Name = "t_fullName";
            this.t_fullName.Size = new System.Drawing.Size(148, 26);
            this.t_fullName.TabIndex = 3;
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(4, 8);
            this.start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(112, 52);
            this.start.TabIndex = 4;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Input
            // 
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.Location = new System.Drawing.Point(4, 69);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(112, 46);
            this.Input.TabIndex = 5;
            this.Input.Text = "Input";
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(716, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // Retrieval
            // 
            this.Retrieval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrieval.Location = new System.Drawing.Point(4, 125);
            this.Retrieval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Retrieval.Name = "Retrieval";
            this.Retrieval.Size = new System.Drawing.Size(130, 51);
            this.Retrieval.TabIndex = 10;
            this.Retrieval.Text = "Retrieval";
            this.Retrieval.UseVisualStyleBackColor = true;
            this.Retrieval.Click += new System.EventHandler(this.Retrieval_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Delete.Location = new System.Drawing.Point(4, 184);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(130, 57);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Retrieval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.start);
            this.Controls.Add(this.t_fullName);
            this.Controls.Add(this.t_age);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.t_address);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_address;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_age;
        private System.Windows.Forms.TextBox t_fullName;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Retrieval;
        private System.Windows.Forms.Button Delete;
    }
}

