namespace TicTacToe_AI
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
            this.bottom_left = new System.Windows.Forms.Button();
            this.bottom_right = new System.Windows.Forms.Button();
            this.bottom_center = new System.Windows.Forms.Button();
            this.center_center = new System.Windows.Forms.Button();
            this.center_right = new System.Windows.Forms.Button();
            this.center_left = new System.Windows.Forms.Button();
            this.top_center = new System.Windows.Forms.Button();
            this.top_right = new System.Windows.Forms.Button();
            this.top_left = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottom_left
            // 
            this.bottom_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom_left.Location = new System.Drawing.Point(12, 673);
            this.bottom_left.Name = "bottom_left";
            this.bottom_left.Size = new System.Drawing.Size(300, 300);
            this.bottom_left.TabIndex = 0;
            this.bottom_left.UseVisualStyleBackColor = true;
            // 
            // bottom_right
            // 
            this.bottom_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom_right.Location = new System.Drawing.Point(696, 673);
            this.bottom_right.Name = "bottom_right";
            this.bottom_right.Size = new System.Drawing.Size(300, 300);
            this.bottom_right.TabIndex = 1;
            this.bottom_right.UseVisualStyleBackColor = true;
            // 
            // bottom_center
            // 
            this.bottom_center.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottom_center.Location = new System.Drawing.Point(356, 673);
            this.bottom_center.Name = "bottom_center";
            this.bottom_center.Size = new System.Drawing.Size(300, 300);
            this.bottom_center.TabIndex = 2;
            this.bottom_center.UseVisualStyleBackColor = true;
            // 
            // center_center
            // 
            this.center_center.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_center.Location = new System.Drawing.Point(356, 341);
            this.center_center.Name = "center_center";
            this.center_center.Size = new System.Drawing.Size(300, 300);
            this.center_center.TabIndex = 5;
            this.center_center.UseVisualStyleBackColor = true;
            // 
            // center_right
            // 
            this.center_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_right.Location = new System.Drawing.Point(696, 341);
            this.center_right.Name = "center_right";
            this.center_right.Size = new System.Drawing.Size(300, 300);
            this.center_right.TabIndex = 4;
            this.center_right.UseVisualStyleBackColor = true;
            // 
            // center_left
            // 
            this.center_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center_left.Location = new System.Drawing.Point(12, 341);
            this.center_left.Name = "center_left";
            this.center_left.Size = new System.Drawing.Size(300, 300);
            this.center_left.TabIndex = 3;
            this.center_left.UseVisualStyleBackColor = true;
            // 
            // top_center
            // 
            this.top_center.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_center.Location = new System.Drawing.Point(356, 12);
            this.top_center.Name = "top_center";
            this.top_center.Size = new System.Drawing.Size(300, 300);
            this.top_center.TabIndex = 8;
            this.top_center.UseVisualStyleBackColor = true;
            // 
            // top_right
            // 
            this.top_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_right.Location = new System.Drawing.Point(696, 12);
            this.top_right.Name = "top_right";
            this.top_right.Size = new System.Drawing.Size(300, 300);
            this.top_right.TabIndex = 7;
            this.top_right.UseVisualStyleBackColor = true;
            // 
            // top_left
            // 
            this.top_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_left.Location = new System.Drawing.Point(12, 12);
            this.top_left.Name = "top_left";
            this.top_left.Size = new System.Drawing.Size(300, 300);
            this.top_left.TabIndex = 6;
            this.top_left.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 985);
            this.Controls.Add(this.top_center);
            this.Controls.Add(this.top_right);
            this.Controls.Add(this.top_left);
            this.Controls.Add(this.center_center);
            this.Controls.Add(this.center_right);
            this.Controls.Add(this.center_left);
            this.Controls.Add(this.bottom_center);
            this.Controls.Add(this.bottom_right);
            this.Controls.Add(this.bottom_left);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe AI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bottom_left;
        private System.Windows.Forms.Button bottom_right;
        private System.Windows.Forms.Button bottom_center;
        private System.Windows.Forms.Button center_center;
        private System.Windows.Forms.Button center_right;
        private System.Windows.Forms.Button center_left;
        private System.Windows.Forms.Button top_center;
        private System.Windows.Forms.Button top_right;
        private System.Windows.Forms.Button top_left;
    }
}

