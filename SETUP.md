This is mainly for Windows 7 as that is the VM I use for scambaiting. Im sure the procedure is similiar or identical for Windows 10.

# Netstat and Tree
1. Create a folder on the VM where you will store this projects versions of programs.
1. Rename Netstat.exe to netstat.com and Tree.exe to tree.com (Not yet tested on Windows 10)
1. Click Start > Computer > Properties > Advanced System Settings > Environment Variables
1. Find the PATH entry in the Systems Variables groupbox
1. Click edit
1. At the *start* of the path value box add the path of your created folder (Dont forget the ";" at the end)
1. Click OK / Apply on each window
1. Open up a CMD instance and test, if it doesnt work try again.
> *be careful using this - editing path can go wrong and trust me its annoying to fix*

# SysKey and Notepad
1. Click start button and type "notepad"
1. The first result should be a shortcut to the real notepad
1. Right click and goto properties
1. Change the shortcut location to the location of your fake notepad
> This should work 9/10 times, if you also add the folder location to path then both the start menu shortcut and running notepad.exe from command line should open the fake notepad. I'm not sure of any other ways to run notepad so this should work most in most scenarios.


-- Alternative Method --
Another way to do this is to just rename the origninal files to something else and replace them with these.
This is far from ideal but I'm still researching a better way to start these instead.
It is not as simple as putting them in the same folder as above as if you open this from CMD it will open the fake versions but if you open these from start menu it will open the real version. If anyone has a way to do this without overwriting the originals please let me know.
