# Steamroller

ITS TIME TO ROLL SOME **S T E A M**

(not to be confused with Steam, a Valve product.)

## Setup

LISTEN UP YOU SLAGTOTHS

I'm gonna show you how to fully automate your steamworks. No more rubberbands, no more stacking ps4 controllers on top of each other (I'm looking at you, Fuma), AAANNND no more running back to your ps4 every 5 minutes to make sure your steamworks didn't reset.

Thats right you can even steamworks while you **SLEEP**.
Hell you can even steamworks when you're half way across the world if you wanted!

All you need is a PS4, a Windows PC, and (obviously) a copy of MHWorld: Iceborne.

### Downloads:

First we gotta download some shit. get all these:

#### RemotePlay
Get yourself remoteplay. Set that good shit up. Follow the guide on the download page: https://remoteplay.dl.playstation.net/remoteplay/lang/en/index.html

Make sure the account you sign into remoate play with is the same as the one you play MH on.

#### PS4Macro
Now you gotta get PS4Macro. This is the program that this script is built on top of. It sends controller commands to the remoateplay window, even if there isn't a controller connected to your PC: https://github.com/komefai/PS4Macro/releases

Download the zip from the latest release and extract it somewhere. I don't care where, anywhere is good. Maybe not System32, but you do you.

#### Steamroller
Now you need my script. I also included a settings file for PS4Macro to make this setup easy.

https://github.com/UncleClapton/MHWI-Steamroller/releases

Download the zip from the latest release, and extract it to the same folder you put PS4Macro in. Make sure `settings.xml` and the 2 DLLs are in the **same directory** as `PS4Macro.exe`

### Configuration

Open up `settings.xml` in any text editor.

By default, your controller **MUST NOT** be connected to your PC when PS4Macro is running. If you want to play the game through Remote Play normally, **remove** this line from the settings file:
```
<EmulateController>true</EmulateController>
```
There are limitations to both choices here. Read more about limitations below.



If you want to skip cutscenes while running steamworks, replace:
```
<StartupFile>Steamroller.dll</StartupFile>
```
with:
```
<StartupFile>SteamrollerSkipCutscene.dll</StartupFile>
```


### Running with **FULL STEAM**

Make sure you're in The Steamworks screen to begin with. All this script knows how to do is press R2 (and sometimes options) until the end of time.

First, start up Remote Play.

If you didn't remove `<EmulateController>` from your settings file, then you don't need your controller connected to the PC. In fact you shouldn't have it connected at all.

Connect to your PS4. Wait for the game window to appear **BEFORE** starting `PS4Macro.exe`

**AFTER** you have successfully connected to your PS4, start `PS4Macro.exe` and press the play button.

If you did everything right, you will now be **HARNESSING THE FULL POWER OF AUTOMATED S T E A M**

You're welcome.


## Limitations
* Since you cannot have a controller on the same user as a remote play user, leaving controller emulation on means that there is no way to control the game while the script is running. For the most of us who don't play through Remote Play, this is fine. Just reconnect your controller to the PS4 when you're done, and the ps4 will, in turn, disconnect Remote Play.
* If you turn off controller emulation, your PS4 controller must always be connected to your PC while the script is running, even though it cannot be used to control the game while the script is running.
