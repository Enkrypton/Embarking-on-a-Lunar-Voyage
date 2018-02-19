using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Twinkle : StoryboardObjectGenerator
    {
        [Configurable]
        public string File;

        [Configurable]
        public int Start;

        [Configurable]
        public int End;

        public override void Generate()
        {
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
		    for(int i = 0; i < 40; i++)
            {
                double RandT = Random(beat, beat * 4);
                var Sprite = GetLayer("Stars").CreateSprite(File);

                Sprite.Move(Start, Random(-80, 720), Random(40, 430));
                
                Sprite.StartLoopGroup(Start, (End - Start) / (int)RandT);
                Sprite.Fade(OsbEasing.OutQuad, 0, RandT, 1, 0);
                Sprite.Scale(OsbEasing.OutQuad, 0, RandT, 0.7, 0);
                Sprite.EndGroup();
                
            }

            for(int i = 0; i < 40; i++)
            {
                double RandT = Random(beat, beat * 4);
                var Sprite = GetLayer("Stars").CreateSprite(File);

                Sprite.Move(Start, Random(-80, 720), Random(40, 430));
                
                Sprite.StartLoopGroup(Start, (End - Start) / (int)RandT);
                Sprite.Fade(OsbEasing.OutQuad, 0, RandT, 1, 0);
                Sprite.Scale(OsbEasing.OutQuad, 0, RandT, 0.7, 0);
                Sprite.EndGroup();
                
            }

            //Top 
		    for(int i = 0; i < 10; i++)
            {
                double RandT = Random(beat, beat * 4);
                var Sprite = GetLayer("Stars").CreateSprite(File);

                Sprite.Move(Start, Random(20, 450), Random(40, 120));
                
                Sprite.StartLoopGroup(Start, (End - Start) / (int)RandT);
                Sprite.Fade(OsbEasing.OutQuad, 0, RandT, 1, 0);
                Sprite.Scale(OsbEasing.OutQuad, 0, RandT, 0.7, 0);
                Sprite.EndGroup();
                
            }
            
        }
    }
}
