namespace Cheess
{
    partial class PawnLevelUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ChangeToBishop = new System.Windows.Forms.Button();
            this.ChangeToKnight = new System.Windows.Forms.Button();
            this.ChangeToQueen = new System.Windows.Forms.Button();
            this.ChangeToRook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.5F);
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level Up!";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.Control;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.TextBox.Location = new System.Drawing.Point(12, 37);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(364, 16);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = "Please choose what you want to promote Pawn to:";
            // 
            // ChangeToBishop
            // 
            this.ChangeToBishop.Location = new System.Drawing.Point(12, 87);
            this.ChangeToBishop.Name = "ChangeToBishop";
            this.ChangeToBishop.Size = new System.Drawing.Size(75, 23);
            this.ChangeToBishop.TabIndex = 2;
            this.ChangeToBishop.Text = "Bishop";
            this.ChangeToBishop.UseVisualStyleBackColor = true;
            this.ChangeToBishop.Click += new System.EventHandler(this.ChangeToBishop_Click);
            // 
            // ChangeToKnight
            // 
            this.ChangeToKnight.Location = new System.Drawing.Point(93, 87);
            this.ChangeToKnight.Name = "ChangeToKnight";
            this.ChangeToKnight.Size = new System.Drawing.Size(75, 23);
            this.ChangeToKnight.TabIndex = 3;
            this.ChangeToKnight.Text = "Knight";
            this.ChangeToKnight.UseVisualStyleBackColor = true;
            this.ChangeToKnight.Click += new System.EventHandler(this.ChangeToKnight_Click);
            // 
            // ChangeToQueen
            // 
            this.ChangeToQueen.Location = new System.Drawing.Point(174, 87);
            this.ChangeToQueen.Name = "ChangeToQueen";
            this.ChangeToQueen.Size = new System.Drawing.Size(75, 23);
            this.ChangeToQueen.TabIndex = 4;
            this.ChangeToQueen.Text = "Queen";
            this.ChangeToQueen.UseVisualStyleBackColor = true;
            this.ChangeToQueen.Click += new System.EventHandler(this.ChangeToQueen_Click);
            // 
            // ChangeToRook
            // 
            this.ChangeToRook.Location = new System.Drawing.Point(255, 87);
            this.ChangeToRook.Name = "ChangeToRook";
            this.ChangeToRook.Size = new System.Drawing.Size(75, 23);
            this.ChangeToRook.TabIndex = 5;
            this.ChangeToRook.Text = "Rook";
            this.ChangeToRook.UseVisualStyleBackColor = true;
            this.ChangeToRook.Click += new System.EventHandler(this.ChangeToRook_Click);
            // 
            // PawnLevelUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 123);
            this.Controls.Add(this.ChangeToRook);
            this.Controls.Add(this.ChangeToQueen);
            this.Controls.Add(this.ChangeToKnight);
            this.Controls.Add(this.ChangeToBishop);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PawnLevelUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Up!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button ChangeToBishop;
        private System.Windows.Forms.Button ChangeToKnight;
        private System.Windows.Forms.Button ChangeToQueen;
        private System.Windows.Forms.Button ChangeToRook;
    }
}