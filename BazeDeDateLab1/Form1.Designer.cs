namespace BazeDeDateLab1
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
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.actorsListBox = new System.Windows.Forms.ListBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.updateMovieButton = new System.Windows.Forms.Button();
            this.actorNameTextBox = new System.Windows.Forms.TextBox();
            this.updateActorButton = new System.Windows.Forms.Button();
            this.deleteActorButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.addActorButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(46, 238);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(332, 31);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load from file";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies";
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.ItemHeight = 16;
            this.moviesListBox.Location = new System.Drawing.Point(46, 67);
            this.moviesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(332, 132);
            this.moviesListBox.TabIndex = 2;
            this.moviesListBox.SelectedIndexChanged += new System.EventHandler(this.moviesListBox_SelectedIndexChanged);
            // 
            // actorsListBox
            // 
            this.actorsListBox.FormattingEnabled = true;
            this.actorsListBox.ItemHeight = 16;
            this.actorsListBox.Location = new System.Drawing.Point(417, 67);
            this.actorsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.actorsListBox.Name = "actorsListBox";
            this.actorsListBox.Size = new System.Drawing.Size(207, 132);
            this.actorsListBox.TabIndex = 3;
            this.actorsListBox.SelectedIndexChanged += new System.EventHandler(this.actorsListBox_SelectedIndexChanged);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(118, 286);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(184, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(118, 323);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(184, 22);
            this.yearTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(118, 361);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(184, 22);
            this.countryTextBox.TabIndex = 6;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(118, 401);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(184, 22);
            this.ratingTextBox.TabIndex = 7;
            // 
            // updateMovieButton
            // 
            this.updateMovieButton.Location = new System.Drawing.Point(46, 443);
            this.updateMovieButton.Name = "updateMovieButton";
            this.updateMovieButton.Size = new System.Drawing.Size(159, 32);
            this.updateMovieButton.TabIndex = 8;
            this.updateMovieButton.Text = "Update movie";
            this.updateMovieButton.UseVisualStyleBackColor = true;
            this.updateMovieButton.Click += new System.EventHandler(this.updateMovieButton_Click);
            // 
            // actorNameTextBox
            // 
            this.actorNameTextBox.Location = new System.Drawing.Point(417, 247);
            this.actorNameTextBox.Name = "actorNameTextBox";
            this.actorNameTextBox.Size = new System.Drawing.Size(207, 22);
            this.actorNameTextBox.TabIndex = 9;
            // 
            // updateActorButton
            // 
            this.updateActorButton.Location = new System.Drawing.Point(417, 286);
            this.updateActorButton.Name = "updateActorButton";
            this.updateActorButton.Size = new System.Drawing.Size(95, 33);
            this.updateActorButton.TabIndex = 10;
            this.updateActorButton.Text = "Update actor";
            this.updateActorButton.UseVisualStyleBackColor = true;
            this.updateActorButton.Click += new System.EventHandler(this.updateActorButton_Click);
            // 
            // deleteActorButton
            // 
            this.deleteActorButton.Location = new System.Drawing.Point(526, 286);
            this.deleteActorButton.Name = "deleteActorButton";
            this.deleteActorButton.Size = new System.Drawing.Size(98, 33);
            this.deleteActorButton.TabIndex = 11;
            this.deleteActorButton.Text = "Delete selected actor";
            this.deleteActorButton.UseVisualStyleBackColor = true;
            this.deleteActorButton.Click += new System.EventHandler(this.deleteActorButton_Click);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(118, 481);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(184, 32);
            this.addMovieButton.TabIndex = 12;
            this.addMovieButton.Text = "Add a new movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(223, 443);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(155, 32);
            this.deleteMovieButton.TabIndex = 13;
            this.deleteMovieButton.Text = "Delete movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            this.deleteMovieButton.Click += new System.EventHandler(this.deleteMovieButton_Click);
            // 
            // addActorButtton
            // 
            this.addActorButtton.Location = new System.Drawing.Point(462, 325);
            this.addActorButtton.Name = "addActorButtton";
            this.addActorButtton.Size = new System.Drawing.Size(121, 33);
            this.addActorButtton.TabIndex = 14;
            this.addActorButtton.Text = "Add actor";
            this.addActorButtton.UseVisualStyleBackColor = true;
            this.addActorButtton.Click += new System.EventHandler(this.addActorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 516);
            this.Controls.Add(this.addActorButtton);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.deleteActorButton);
            this.Controls.Add(this.updateActorButton);
            this.Controls.Add(this.actorNameTextBox);
            this.Controls.Add(this.updateMovieButton);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.actorsListBox);
            this.Controls.Add(this.moviesListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.ListBox actorsListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Button updateMovieButton;
        private System.Windows.Forms.TextBox actorNameTextBox;
        private System.Windows.Forms.Button updateActorButton;
        private System.Windows.Forms.Button deleteActorButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Button deleteMovieButton;
        private System.Windows.Forms.Button addActorButtton;
    }
}

