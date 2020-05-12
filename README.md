# ScambaitToolkit
C# .Net Framework scambait toolkit. Replacements for standard Windows programs with a little extra added ;)
Recomended to replace the actual programs on the vm and disable alternitives such as wordpad. If you have any requests of features feel free to ask either on discord (BlueberryHype#6486) or add a issue with the request.

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
   * Font scale level using Ctrl+[ and Ctrl+] but in reverse.
   
1. Giftcard Generator
   * Very simple random number generator
   * Just creates "realistic" gift card number and pins
   * i.e correct card number length and charset and pin length
   * Scammers normally have to type these into notepad so wont realise they arent real until later on
   
1. Tree
   * Contains both the Windows 10 and Windows 7 versions of tree so that it can work on both platforms.
   * Runs the correct version of tree from the command prompt.
   * Appends a message to the output off tree confirming that their are no viruses present on the machine
   * Everyone knows that tree.exe is the No. 1 antivirus on the Windows Platform [Citation Needed]
   
1. Netstat
   * Doesnt run netstat at all
   * Pretends to run netstat
   * Displays zero connections on no protocol with no forigen address and no state 
   * Displays a message proving that a lack of netstat connections proves that their are no hackers in the system
   * Netstat is an elite tool only used by the best of the blue team to defend agasint dark web pro hackers
