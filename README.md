# Weekly Alarm
## Simple weekly alarm, made when your windows OS didn't come with this feature
![Main scren](https://github.com/ladbsoft/Weekly_Alarm/blob/master/MainScreen.png "Main screen")

I created this program in 2012. Back then I had just upgraded to Windows 7, and I was still bothered by Windows not coming with a proper alarm program. I decided I should create one, so I did. Now, several years after, I was taking a look at my old code and decided to upload it. So here it is.

The program lets you add alarms for a single or multiple week days, with the possibility of selecting the audio file to use, and has a small algorithm to ensure at least some kind of audio comes out, even if some errors appear (the audio file no longer existing, an error in the player object...). It would not produce any sound if your speakers are off, of course (believe me, this happened to me a couple of times... 😁)

The order of sounds to use is:

- The custom audio file selected by the user
- The builtin alarm.mp3 file
- A series of system beeps

For distribution, I have now created a simple Inno Setup, which for now, needs **admin privileges** to run properly.

Will I continue this anytime? Maybe 😊
