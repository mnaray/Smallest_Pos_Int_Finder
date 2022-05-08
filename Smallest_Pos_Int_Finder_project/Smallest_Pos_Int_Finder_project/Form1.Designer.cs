
namespace Smallest_Pos_Int_Finder_project
{
    partial class MainWindow
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
            this.path_text = new System.Windows.Forms.Label();
            this.path_input = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.solution_text = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path_text
            // 
            this.path_text.AutoSize = true;
            this.path_text.Location = new System.Drawing.Point(41, 199);
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(55, 15);
            this.path_text.TabIndex = 0;
            this.path_text.Text = "File path:";
            // 
            // path_input
            // 
            this.path_input.Location = new System.Drawing.Point(41, 218);
            this.path_input.Name = "path_input";
            this.path_input.Size = new System.Drawing.Size(438, 23);
            this.path_input.TabIndex = 1;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(41, 247);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(55, 22);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // solution_text
            // 
            this.solution_text.AutoSize = true;
            this.solution_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solution_text.Location = new System.Drawing.Point(41, 325);
            this.solution_text.Name = "solution_text";
            this.solution_text.Size = new System.Drawing.Size(71, 21);
            this.solution_text.TabIndex = 3;
            this.solution_text.Text = "Solution:";
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solution.Location = new System.Drawing.Point(41, 346);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(22, 30);
            this.solution.TabIndex = 4;
            this.solution.Text = "-";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.solution_text);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.path_input);
            this.Controls.Add(this.path_text);
            this.Name = "MainWindow";
            this.Text = "Smallest Positive Int Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label path_text;
        private System.Windows.Forms.TextBox path_input;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Label solution_text;
        private System.Windows.Forms.Label solution;
    }
}

