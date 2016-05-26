namespace Battleship
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
            this.StartButton = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.Normalbutton = new System.Windows.Forms.Button();
            this.Horizontal = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(45, 59);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(182, 59);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "NEW_GAME";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(308, 59);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(75, 23);
            this.AutoButton.TabIndex = 2;
            this.AutoButton.Text = "Xml_Load";
            this.AutoButton.UseVisualStyleBackColor = true;
            // 
            // Normalbutton
            // 
            this.Normalbutton.Location = new System.Drawing.Point(425, 59);
            this.Normalbutton.Name = "Normalbutton";
            this.Normalbutton.Size = new System.Drawing.Size(75, 23);
            this.Normalbutton.TabIndex = 3;
            this.Normalbutton.Text = "הכנס ידני";
            this.Normalbutton.UseVisualStyleBackColor = true;
            // 
            // Horizontal
            // 
            this.Horizontal.FormattingEnabled = true;
            this.Horizontal.Items.AddRange(new object[] {
            "אופקי",
            "אנכי"});
            this.Horizontal.Location = new System.Drawing.Point(403, 115);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(121, 21);
            this.Horizontal.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(403, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 447);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Horizontal);
            this.Controls.Add(this.Normalbutton);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.Button Normalbutton;
        private System.Windows.Forms.ComboBox Horizontal;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

