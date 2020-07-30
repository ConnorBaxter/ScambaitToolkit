namespace Event_Viewer

partial class MainForm(System.Windows.Forms.Form):
	private components as System.ComponentModel.IContainer = null
	
	protected override def Dispose(disposing as bool) as void:
		if disposing:
			if components is not null:
				components.Dispose()
		super(disposing)
	
	// This method is required for Windows Forms designer support.
	// Do not change the method contents inside the source code editor. The Forms designer might
	// not be able to load this method if it was changed manually.
	private def InitializeComponent():
		self.pictureBox = System.Windows.Forms.PictureBox()
		cast(System.ComponentModel.ISupportInitialize,self.pictureBox).BeginInit()
		self.SuspendLayout()
		# 
		# pictureBox
		# 
		self.pictureBox.ImageLocation = "images/eventvwr.png"
		self.pictureBox.Location = System.Drawing.Point(0, 0)
		self.pictureBox.Name = "pictureBox"
		self.pictureBox.Size = System.Drawing.Size(795, 519)
		self.pictureBox.TabIndex = 0
		self.pictureBox.TabStop = false
		# 
		# MainForm
		# 
		self.AutoScaleDimensions = System.Drawing.SizeF(6, 13)
		self.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		self.ClientSize = System.Drawing.Size(784, 516)
		self.Controls.Add(self.pictureBox)
		self.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		self.MaximizeBox = false
		self.Name = "MainForm"
		self.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		self.Text = "Event Viewer"
		cast(System.ComponentModel.ISupportInitialize,self.pictureBox).EndInit()
		self.ResumeLayout(false)
	private pictureBox as System.Windows.Forms.PictureBox

