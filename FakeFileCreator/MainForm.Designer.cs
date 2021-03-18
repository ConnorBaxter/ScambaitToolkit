
namespace FakeFileCreator
{
    partial class MainForm
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
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnPictures = new System.Windows.Forms.Button();
            this.btnVideos = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(12, 12);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(212, 23);
            this.btnDocuments.TabIndex = 0;
            this.btnDocuments.Text = "Create Fake Documents";
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnPictures
            // 
            this.btnPictures.Location = new System.Drawing.Point(12, 41);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(212, 23);
            this.btnPictures.TabIndex = 1;
            this.btnPictures.Text = "Create Fake Pictures";
            this.btnPictures.UseVisualStyleBackColor = true;
            // 
            // btnVideos
            // 
            this.btnVideos.Location = new System.Drawing.Point(12, 70);
            this.btnVideos.Name = "btnVideos";
            this.btnVideos.Size = new System.Drawing.Size(212, 23);
            this.btnVideos.TabIndex = 2;
            this.btnVideos.Text = "Create Fake Vidoes";
            this.btnVideos.UseVisualStyleBackColor = true;
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(12, 99);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(212, 23);
            this.btnMusic.TabIndex = 3;
            this.btnMusic.Text = "Create Fake Music";
            this.btnMusic.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 138);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnVideos);
            this.Controls.Add(this.btnPictures);
            this.Controls.Add(this.btnDocuments);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "FakeFileCreator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.Button btnVideos;
        private System.Windows.Forms.Button btnMusic;
    }
}

