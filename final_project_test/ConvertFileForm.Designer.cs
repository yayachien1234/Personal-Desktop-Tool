namespace final_project_test
{
    partial class ConvertFileForm
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
            this.lbx_ConvertedFile = new System.Windows.Forms.ListBox();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.lbl_SelectedFile = new System.Windows.Forms.Label();
            this.cbx_image = new System.Windows.Forms.ComboBox();
            this.cbx_audio = new System.Windows.Forms.ComboBox();
            this.cbx_video = new System.Windows.Forms.ComboBox();
            this.cbx_other = new System.Windows.Forms.ComboBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_audio = new System.Windows.Forms.Label();
            this.lbl_video = new System.Windows.Forms.Label();
            this.lbl_other = new System.Windows.Forms.Label();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.lbl_saved = new System.Windows.Forms.Label();
            this.pbx_ConvertFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ConvertFile)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx_ConvertedFile
            // 
            this.lbx_ConvertedFile.AllowDrop = true;
            this.lbx_ConvertedFile.FormattingEnabled = true;
            this.lbx_ConvertedFile.ItemHeight = 15;
            this.lbx_ConvertedFile.Location = new System.Drawing.Point(21, 12);
            this.lbx_ConvertedFile.Name = "lbx_ConvertedFile";
            this.lbx_ConvertedFile.Size = new System.Drawing.Size(197, 109);
            this.lbx_ConvertedFile.TabIndex = 0;
            this.lbx_ConvertedFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbx_ConvertedFile_DragDrop);
            this.lbx_ConvertedFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbx_ConvertedFile_DragEnter);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(21, 127);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 1;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // lbl_SelectedFile
            // 
            this.lbl_SelectedFile.AutoSize = true;
            this.lbl_SelectedFile.Location = new System.Drawing.Point(102, 131);
            this.lbl_SelectedFile.Name = "lbl_SelectedFile";
            this.lbl_SelectedFile.Size = new System.Drawing.Size(98, 15);
            this.lbl_SelectedFile.TabIndex = 2;
            this.lbl_SelectedFile.Text = "lbl_SelectedFile";
            // 
            // cbx_image
            // 
            this.cbx_image.FormattingEnabled = true;
            this.cbx_image.Items.AddRange(new object[] {
            ".gif",
            ".bmp",
            ".png",
            ".ico",
            ".jpg",
            ".jpeg"});
            this.cbx_image.Location = new System.Drawing.Point(20, 230);
            this.cbx_image.Name = "cbx_image";
            this.cbx_image.Size = new System.Drawing.Size(121, 23);
            this.cbx_image.TabIndex = 3;
            this.cbx_image.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            // 
            // cbx_audio
            // 
            this.cbx_audio.FormattingEnabled = true;
            this.cbx_audio.Items.AddRange(new object[] {
            ".mp3",
            ".wav"});
            this.cbx_audio.Location = new System.Drawing.Point(170, 230);
            this.cbx_audio.Name = "cbx_audio";
            this.cbx_audio.Size = new System.Drawing.Size(121, 23);
            this.cbx_audio.TabIndex = 4;
            this.cbx_audio.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            // 
            // cbx_video
            // 
            this.cbx_video.FormattingEnabled = true;
            this.cbx_video.Items.AddRange(new object[] {
            ".avi",
            ".mp4",
            ".mov",
            ".wmv",
            ".flv"});
            this.cbx_video.Location = new System.Drawing.Point(320, 230);
            this.cbx_video.Name = "cbx_video";
            this.cbx_video.Size = new System.Drawing.Size(121, 23);
            this.cbx_video.TabIndex = 5;
            this.cbx_video.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            // 
            // cbx_other
            // 
            this.cbx_other.FormattingEnabled = true;
            this.cbx_other.Items.AddRange(new object[] {
            ".pdf"});
            this.cbx_other.Location = new System.Drawing.Point(470, 230);
            this.cbx_other.Name = "cbx_other";
            this.cbx_other.Size = new System.Drawing.Size(121, 23);
            this.cbx_other.TabIndex = 6;
            this.cbx_other.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.Location = new System.Drawing.Point(20, 210);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(41, 15);
            this.lbl_image.TabIndex = 7;
            this.lbl_image.Text = "image";
            // 
            // lbl_audio
            // 
            this.lbl_audio.AutoSize = true;
            this.lbl_audio.Location = new System.Drawing.Point(170, 210);
            this.lbl_audio.Name = "lbl_audio";
            this.lbl_audio.Size = new System.Drawing.Size(38, 15);
            this.lbl_audio.TabIndex = 8;
            this.lbl_audio.Text = "audio";
            // 
            // lbl_video
            // 
            this.lbl_video.AutoSize = true;
            this.lbl_video.Location = new System.Drawing.Point(320, 210);
            this.lbl_video.Name = "lbl_video";
            this.lbl_video.Size = new System.Drawing.Size(38, 15);
            this.lbl_video.TabIndex = 9;
            this.lbl_video.Text = "video";
            // 
            // lbl_other
            // 
            this.lbl_other.AutoSize = true;
            this.lbl_other.Location = new System.Drawing.Point(470, 210);
            this.lbl_other.Name = "lbl_other";
            this.lbl_other.Size = new System.Drawing.Size(36, 15);
            this.lbl_other.TabIndex = 10;
            this.lbl_other.Text = "other";
            // 
            // btn_Convert
            // 
            this.btn_Convert.Location = new System.Drawing.Point(20, 284);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.btn_Convert.TabIndex = 11;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // lbl_saved
            // 
            this.lbl_saved.AutoSize = true;
            this.lbl_saved.Location = new System.Drawing.Point(101, 288);
            this.lbl_saved.Name = "lbl_saved";
            this.lbl_saved.Size = new System.Drawing.Size(60, 15);
            this.lbl_saved.TabIndex = 12;
            this.lbl_saved.Text = "lbl_saved";
            // 
            // pbx_ConvertFile
            // 
            this.pbx_ConvertFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_ConvertFile.InitialImage = null;
            this.pbx_ConvertFile.Location = new System.Drawing.Point(224, 49);
            this.pbx_ConvertFile.Name = "pbx_ConvertFile";
            this.pbx_ConvertFile.Size = new System.Drawing.Size(67, 72);
            this.pbx_ConvertFile.TabIndex = 13;
            this.pbx_ConvertFile.TabStop = false;
            this.pbx_ConvertFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbx_ConvertedFile_DragDrop);
            this.pbx_ConvertFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbx_ConvertedFile_DragEnter);
            // 
            // ConvertFileForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbx_ConvertFile);
            this.Controls.Add(this.lbl_saved);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.lbl_other);
            this.Controls.Add(this.lbl_video);
            this.Controls.Add(this.lbl_audio);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.cbx_other);
            this.Controls.Add(this.cbx_video);
            this.Controls.Add(this.cbx_audio);
            this.Controls.Add(this.cbx_image);
            this.Controls.Add(this.lbl_SelectedFile);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.lbx_ConvertedFile);
            this.Name = "ConvertFileForm";
            this.Text = "ConvertFileForm";
            this.Load += new System.EventHandler(this.ConvertFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ConvertFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_ConvertedFile;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.Label lbl_SelectedFile;
        private System.Windows.Forms.ComboBox cbx_image;
        private System.Windows.Forms.ComboBox cbx_audio;
        private System.Windows.Forms.ComboBox cbx_video;
        private System.Windows.Forms.ComboBox cbx_other;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_audio;
        private System.Windows.Forms.Label lbl_video;
        private System.Windows.Forms.Label lbl_other;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.Label lbl_saved;
        private System.Windows.Forms.PictureBox pbx_ConvertFile;
    }
}