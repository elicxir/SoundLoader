# SoundLoader
Package for loading local music files as AudioClip.

## Install

### Install Dependency
Window -> Package Manager -> AddPackage fom git url
|Package|version|URL|
|---|---|---|
|UniTask|2.3.1|https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask|

### Install SoundLoader
Window -> Package Manager -> AddPackage fom git url

https://github.com/elicxir/SoundLoader.git

## How to Use

```Csharp
//Load local sound file as AudioClip
AudioClip audioclip = await LoadLocalSoundFile(filepath);
```
