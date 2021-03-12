# Fake Event Viewer

## Why Did You Make This?
This application was made because I noticed it lacked the event viewer from the ScambaitingToolkit even though the legit version of this app
is commonly used in Tech Support Scams.

## What Does it Do?
This application will display a warning message which more or less states that warnings and errors are not signs of infection. It will also
be stated that the message is displayed because it was "detected" ;-) that an outside connection launched the program. When the user clicks
"OK", a convincingly similar window to the real Event Viewer will open. However, none of the features will work because it's merely a
screenshot.

## How to Install
The installation process should be the same as the rest of the tools. Again, it is recommended you use a VM.
Preferably, to have a matching fit with the rest of your apps, Windows 8.1 should be used. Although, you can easily replace the screenshot installation
/images/eventvwr.png. Just make sure that the picture is 795 x 519 pixels.

## Compiling
My favourite .Net language is Boo. Therefore, I coded the app in Boo. If you want to compile the app yourself, you'll need to either install Boo with
Nant and rebuild the project almost from scratch or you can download SharpDevelop 4.4 and open the .sln file with it once you've installed it.
I recommend the latter, because it is much easier to proceed that way. But doing the former ensures you have a more up-to-date version of Boo on your
computer. That's for you to decide.