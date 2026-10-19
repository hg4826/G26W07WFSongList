namespace G26W07WFSongList
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
            listSong = new ListBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblArtist = new Label();
            txtArtist = new TextBox();
            lblRating = new Label();
            numRating = new NumericUpDown();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // listSong
            // 
            listSong.FormattingEnabled = true;
            listSong.Location = new Point(12, 12);
            listSong.Name = "listSong";
            listSong.Size = new Size(1094, 580);
            listSong.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 625);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(62, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "제목";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(100, 620);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(380, 39);
            txtTitle.TabIndex = 2;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Location = new Point(500, 625);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(62, 32);
            lblArtist.TabIndex = 3;
            lblArtist.Text = "가수";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(570, 620);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(260, 39);
            txtArtist.TabIndex = 4;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(850, 625);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(62, 32);
            lblRating.TabIndex = 5;
            lblRating.Text = "별점";
            // 
            // numRating
            // 
            numRating.Location = new Point(920, 620);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(80, 39);
            numRating.TabIndex = 6;
            numRating.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1010, 614);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "➕ 추가";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            //
            // btnDelete
            //
            btnDelete.Location = new Point(1010, 680);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "➖ 삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 831);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(numRating);
            Controls.Add(lblRating);
            Controls.Add(txtArtist);
            Controls.Add(lblArtist);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(listSong);
            Name = "Form1";
            Text = "애창곡";
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listSong;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblArtist;
        private TextBox txtArtist;
        private Label lblRating;
        private NumericUpDown numRating;
        private Button btnAdd;
        private Button btnDelete;
    }
}
