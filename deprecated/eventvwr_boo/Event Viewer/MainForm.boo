namespace Event_Viewer

import System
import System.Collections
import System.Drawing
import System.Windows.Forms

partial class MainForm:
	
	public def constructor():
		
		InitializeComponent()
		Icon = Icon("images/EventVwr.ico")

[STAThread]
public def Main(argv as (string)) as void:
	
	DisplayFakeWarning()
	
	Application.EnableVisualStyles()
	Application.SetCompatibleTextRenderingDefault(false)
	Application.Run(MainForm())

public def DisplayFakeWarning():
	
	em = "Please note that the warnings and errors shown within are trivial, even brand new computers will log warnings and errors over time."
	em = "$(em)\n\nWindows Defender Antivirus is the only application which is officially used to detect potential security flaws. "
	em = "$(em)\n\nThis warning message appeared because this application appears to have been launched remotely. Therefore, all features are disabled."
	
	MessageBox.Show(em, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)