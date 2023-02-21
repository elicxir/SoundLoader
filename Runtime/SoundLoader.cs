using System;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
using Cysharp.Threading.Tasks;

namespace SoundLoader
{
    public static class SoundLoader
    {
        static AudioType GetAudioType(string path)
        {
            AudioType res;
            switch (Path.GetExtension(path))
            {
                case ".ogg":
                    res = AudioType.OGGVORBIS;
                    break;

                case ".wav":
                    res = AudioType.WAV;
                    break;

                case ".mp3":
                    res = AudioType.MPEG;
                    break;

                default:
                    res = AudioType.UNKNOWN;
                    break;
            }

            return res;

        }

        public static async UniTask<AudioClip> LoadLocalSoundFile(string path)
        {
            try
            {
                var url = $"file://{path}";
                var type = GetAudioType(path);

                var req = UnityWebRequestMultimedia.GetAudioClip(url, type);
                await req.SendWebRequest();

                AudioClip myClip = DownloadHandlerAudioClip.GetContent(req);

                // channels : 2
                // loadState : Loaded
                // preloadAudioData : True
                // loadType : Decompress On Load
                // loadInBackground : False

                return myClip;

            }
            catch
            {
                throw new Exception("failed to generate Audio Clip");
            }
        }


    }


}


