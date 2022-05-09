
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.path_text = new System.Windows.Forms.Label();
            this.path_input = new System.Windows.Forms.TextBox();
            this.run_button = new System.Windows.Forms.Button();
            this.solution_text = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.info_title = new System.Windows.Forms.Label();
            this.info_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // path_text
            // 
            this.path_text.AutoSize = true;
            this.path_text.Location = new System.Drawing.Point(47, 344);
            this.path_text.Name = "path_text";
            this.path_text.Size = new System.Drawing.Size(94, 20);
            this.path_text.TabIndex = 0;
            this.path_text.Text = "Full file path:";
            // 
            // path_input
            // 
            this.path_input.Location = new System.Drawing.Point(47, 370);
            this.path_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.path_input.Name = "path_input";
            this.path_input.Size = new System.Drawing.Size(500, 27);
            this.path_input.TabIndex = 1;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(47, 408);
            this.run_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(63, 29);
            this.run_button.TabIndex = 2;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // solution_text
            // 
            this.solution_text.AutoSize = true;
            this.solution_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solution_text.Location = new System.Drawing.Point(47, 468);
            this.solution_text.Name = "solution_text";
            this.solution_text.Size = new System.Drawing.Size(90, 28);
            this.solution_text.TabIndex = 3;
            this.solution_text.Text = "Solution:";
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solution.Location = new System.Drawing.Point(47, 496);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(28, 37);
            this.solution.TabIndex = 4;
            this.solution.Text = "-";
            // 
            // info_title
            // 
            this.info_title.AutoSize = true;
            this.info_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_title.Location = new System.Drawing.Point(47, 30);
            this.info_title.Name = "info_title";
            this.info_title.Size = new System.Drawing.Size(115, 28);
            this.info_title.TabIndex = 5;
            this.info_title.Text = "Information";
            // 
            // info_text
            // 
            this.info_text.AutoSize = true;
            this.info_text.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.info_text.Location = new System.Drawing.Point(47, 62);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(747, 230);
            this.info_text.TabIndex = 6;
            this.info_text.Text = resources.GetString("info_text.Text");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.info_text);
            this.Controls.Add(this.info_title);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.solution_text);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.path_input);
            this.Controls.Add(this.path_text);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label info_title;
        private System.Windows.Forms.Label info_text;
    }
}

