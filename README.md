# ScambaitToolkit
C# .Net Framework scambait toolkit. Replacements for standard Windows programs with a little extra added ;)

Recomended to replace the actual programs on the vm and disable alternitives such as wordpad. If you have any requests of features feel free to ask either on discord (BlueberryHype#6486) or create an issue.

> *Read Setup.md for recommended intallation procedure*

Feature list will likely get more sarcastic as items are added

1. Syskey
   * After setting a password the passwords are written to a textfile for inspection.
   * Numerous popups with a message of your chosing(by editing settings.txt) are show which move as you try to hover over them
   * They will dissapear after time set by the code (will be added to settings eventally)
   * The amount of popups is determined based on the length of the password set
   * Please note this is not actually syskey and wont lock the computer.
   * SysKey is no longer in Windows 10 so scammers might not try to use on Windows 10 but will still appear to work if they do try.
   * Reccommneded for Windows 7 virtual machines.
  
1. Notepad
   * Still in development.
   * Pressing tab key inserts "TAB" into textbox.
   * Trying to enter a colon or semicolon will print a smiley face :-)
   * Trying to enter a hyphen will insert an underscore.
   * Font chooser works as expected as of now but will be intentionally broken in the future.
   * Font slowly gets bigger as notepad is open
   * Font scale level using Ctrl+[ and Ctrl+ ] but in reverse.
   
1. Giftcard Generator
   * Very simple random number generator.
   * Just creates "realistic" gift card number and pins.
   * i.e correct card number length and charset and pin length.
   * Scammers normally have to type these into notepad so wont realise they arent real until later on.
   
1. Tree
   * Completley reworked as I was overcomplicating a very simple program, reduced filesize from ~46Kb to ~6Kb.
   * Has 2 modes which can be chosen by changing a boolean inside Program.cs in Main
        * Can run forever so tree never ends (scammer like to run tree and then type something that will displayed when it ends)
        * OR
        * Can append a message to the output of tree confirming that there are no viruses present on the machine.
   * Everyone knows that tree.exe is the No. 1 antivirus on the Windows Platform [Citation Needed]
   
1. Netstat
   * Doesnt run netstat at all.
   * Pretends to run netstat.
   * Displays zero connections on no protocol with no forigen address and no state.
   * Displays a message proving that a lack of netstat connections proves that their are no hackers in the system.
   * Netstat is an elite tool only used by the best of the blue team to defend agasint dark web pro hackers.

1. Event Viewer 2.0
   * Thanks to @RealDoigt for the first version, however to try and keep the project mainly C# it has been rewritten (original still available in deprecated/eventvwr_boo)
   * Fake Event viewer
   * Uses screenshots of event viewer componets to mimic disabled controls
   * Displays warning that event viewer is disabled 
   * Offers ability to re-enbaled by going into options and typing "I am a stupid scammer"
   * Doesnt actually do anything after typing this
   * Looks kinda fake due to using screenshots however I couldnt replicate the orignal look using winforms

1. GOD Ransomware
   > Please read this if you intend to use it
   * Fake ransomware that acts as a real one.
   * prints scary messages such as "all your file are belong to us" and "file x has been encrypted".
   * big red countdown timer for extra terror.
   * [_!IMPORTANT!_]ALT+F4 and clicking the close button are disabled. Right click + "payment link" to actually close the form!
   * No files are actually encrypted!
   * Most things about the program are easily changed from the txt files included [message, bitcoin address, file names]
   * More customizability to this is in progress, i.e. name of ransomware, colours, make it differnent per machine.
