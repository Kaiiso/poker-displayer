namespace poker_displayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CardGroup = new System.Windows.Forms.GroupBox();
            this.SendCard = new System.Windows.Forms.Button();
            this.CardIndex = new System.Windows.Forms.ComboBox();
            this.PlayerIndex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Card = new System.Windows.Forms.ComboBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerIndex2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.SendNickname = new System.Windows.Forms.Button();
            this.CardGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardGroup
            // 
            this.CardGroup.Controls.Add(this.SendCard);
            this.CardGroup.Controls.Add(this.CardIndex);
            this.CardGroup.Controls.Add(this.PlayerIndex);
            this.CardGroup.Controls.Add(this.label3);
            this.CardGroup.Controls.Add(this.label2);
            this.CardGroup.Controls.Add(this.label1);
            this.CardGroup.Controls.Add(this.Card);
            this.CardGroup.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.CardGroup.Location = new System.Drawing.Point(17, 12);
            this.CardGroup.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CardGroup.Name = "CardGroup";
            this.CardGroup.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CardGroup.Size = new System.Drawing.Size(475, 118);
            this.CardGroup.TabIndex = 2;
            this.CardGroup.TabStop = false;
            this.CardGroup.Text = "Card";
            this.CardGroup.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // SendCard
            // 
            this.SendCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendCard.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendCard.Location = new System.Drawing.Point(342, 58);
            this.SendCard.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.SendCard.Name = "SendCard";
            this.SendCard.Size = new System.Drawing.Size(77, 31);
            this.SendCard.TabIndex = 7;
            this.SendCard.Text = "Send";
            this.SendCard.UseVisualStyleBackColor = false;
            this.SendCard.Click += new System.EventHandler(this.SendCard_Click);
            // 
            // CardIndex
            // 
            this.CardIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardIndex.FormattingEnabled = true;
            this.CardIndex.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CardIndex.Location = new System.Drawing.Point(153, 65);
            this.CardIndex.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.CardIndex.Name = "CardIndex";
            this.CardIndex.Size = new System.Drawing.Size(43, 21);
            this.CardIndex.TabIndex = 6;
            // 
            // PlayerIndex
            // 
            this.PlayerIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerIndex.FormattingEnabled = true;
            this.PlayerIndex.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PlayerIndex.Location = new System.Drawing.Point(48, 65);
            this.PlayerIndex.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.PlayerIndex.Name = "PlayerIndex";
            this.PlayerIndex.Size = new System.Drawing.Size(45, 21);
            this.PlayerIndex.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Card value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player index (1-10)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Card index (1-2)";
            // 
            // Card
            // 
            this.Card.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Card.FormattingEnabled = true;
            this.Card.Items.AddRange(new object[] {
            "AC",
            "2C",
            "3C",
            "4C",
            "5C",
            "6C",
            "7C",
            "8C",
            "9C",
            "10C",
            "JC",
            "QC",
            "KC",
            "AD",
            "2D",
            "3D",
            "4D",
            "5D",
            "6D",
            "7D",
            "8D",
            "9D",
            "10D",
            "JD",
            "QD",
            "KD",
            "AH",
            "2H",
            "3H",
            "4H",
            "5H",
            "6H",
            "7H",
            "8H",
            "9H",
            "10H",
            "JH",
            "QH",
            "KH",
            "AS",
            "2S",
            "3S",
            "4S",
            "5S",
            "6S",
            "7S",
            "8S",
            "9S",
            "10S",
            "JS",
            "QS",
            "KS",
            "null"});
            this.Card.Location = new System.Drawing.Point(244, 65);
            this.Card.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(51, 21);
            this.Card.TabIndex = 1;
            this.Card.SelectedIndexChanged += new System.EventHandler(this.Card_SelectedIndexChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetButton.Location = new System.Drawing.Point(428, 152);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(64, 27);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(428, 202);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SendNickname);
            this.groupBox1.Controls.Add(this.Nickname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PlayerIndex2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nickname";
            // 
            // PlayerIndex2
            // 
            this.PlayerIndex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerIndex2.FormattingEnabled = true;
            this.PlayerIndex2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.PlayerIndex2.Location = new System.Drawing.Point(48, 65);
            this.PlayerIndex2.Margin = new System.Windows.Forms.Padding(1);
            this.PlayerIndex2.Name = "PlayerIndex2";
            this.PlayerIndex2.Size = new System.Drawing.Size(45, 21);
            this.PlayerIndex2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player index (1-10)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player nickname";
            // 
            // Nickname
            // 
            this.Nickname.Location = new System.Drawing.Point(139, 65);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(100, 21);
            this.Nickname.TabIndex = 9;
            // 
            // SendNickname
            // 
            this.SendNickname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SendNickname.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendNickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendNickname.Location = new System.Drawing.Point(281, 58);
            this.SendNickname.Margin = new System.Windows.Forms.Padding(1);
            this.SendNickname.Name = "SendNickname";
            this.SendNickname.Size = new System.Drawing.Size(77, 31);
            this.SendNickname.TabIndex = 10;
            this.SendNickname.Text = "Send";
            this.SendNickname.UseVisualStyleBackColor = false;
            this.SendNickname.Click += new System.EventHandler(this.SendNickname_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(514, 281);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CardGroup);
            this.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Poker Displayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CardGroup.ResumeLayout(false);
            this.CardGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CardGroup;
        private System.Windows.Forms.ComboBox Card;
        private System.Windows.Forms.ComboBox CardIndex;
        private System.Windows.Forms.ComboBox PlayerIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SendCard;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox PlayerIndex2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendNickname;
    }
}

