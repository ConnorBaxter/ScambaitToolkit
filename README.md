# ScambaitToolkit
C# .Net Framework scambait toolkit. Replacements for standard Windows programs with a little extra added ;)
Recomended to replace the actual programs on the vm and disable alternitives such as wordpad

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
