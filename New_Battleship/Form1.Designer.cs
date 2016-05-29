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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.NewGame = new System.Windows.Forms.Button();
            this.AutoButton = new System.Windows.Forms.Button();
            this.Normalbutton = new System.Windows.Forms.Button();
            this.Horizontal = new System.Windows.Forms.ComboBox();
            this.SelectShip = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(425, 59);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(425, 12);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(75, 23);
            this.NewGame.TabIndex = 1;
            this.NewGame.Text = "NEW_GAME";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // AutoButton
            // 
            this.AutoButton.Location = new System.Drawing.Point(200, 59);
            this.AutoButton.Name = "AutoButton";
            this.AutoButton.Size = new System.Drawing.Size(75, 23);
            this.AutoButton.TabIndex = 2;
            this.AutoButton.Text = "Xml_Load";
            this.AutoButton.UseVisualStyleBackColor = true;
            // 
            // Normalbutton
            // 
            this.Normalbutton.Location = new System.Drawing.Point(36, 59);
            this.Normalbutton.Name = "Normalbutton";
            this.Normalbutton.Size = new System.Drawing.Size(75, 23);
            this.Normalbutton.TabIndex = 3;
            this.Normalbutton.Text = "הכנס ידני";
            this.Normalbutton.UseVisualStyleBackColor = true;
            this.Normalbutton.Click += new System.EventHandler(this.Normalbutton_Click);
            // 
            // Horizontal
            // 
            this.Horizontal.DisplayMember = "\"1\"";
            this.Horizontal.FormattingEnabled = true;
            this.Horizontal.Items.AddRange(new object[] {
            "אופקי",
            "אנכי"});
            this.Horizontal.Location = new System.Drawing.Point(403, 115);
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(121, 21);
            this.Horizontal.TabIndex = 4;
            this.Horizontal.ValueMember = "\"1\"";
            this.Horizontal.SelectedIndexChanged += new System.EventHandler(this.Horizontal_SelectedIndexChanged);
            // 
            // SelectShip
            // 
            this.SelectShip.FormattingEnabled = true;
            this.SelectShip.Location = new System.Drawing.Point(403, 158);
            this.SelectShip.Name = "SelectShip";
            this.SelectShip.Size = new System.Drawing.Size(121, 21);
            this.SelectShip.TabIndex = 5;
            this.SelectShip.SelectedIndexChanged += new System.EventHandler(this.SelectShip_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 447);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectShip);
            this.Controls.Add(this.Horizontal);
            this.Controls.Add(this.Normalbutton);
            this.Controls.Add(this.AutoButton);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button AutoButton;
        private System.Windows.Forms.Button Normalbutton;
        private System.Windows.Forms.ComboBox Horizontal;
        private System.Windows.Forms.ComboBox SelectShip;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

