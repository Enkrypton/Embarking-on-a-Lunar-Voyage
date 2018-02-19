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
    public class Txt : StoryboardObjectGenerator
    {
        public override void Generate()
        {     
            var artist = GetLayer("Text").CreateSprite("sb/txt/artist.png");
            var song = GetLayer("Text").CreateSprite("sb/txt/title.png");
            var mappers = GetLayer("Text").CreateSprite("sb/txt/maPPers.png");
            var sber = GetLayer("Text").CreateSprite("sb/txt/noob.png");
            var thanks = GetLayer("Text").CreateSprite("sb/txt/thx.png");

            song.Move(4198, 320, 160);
            artist.Move(7948, 320, 295);
            mappers.Move(11698,320,240);
            sber.Move(350220, 320, 240);
            thanks.Move(353970, 320, 240);
            

            mappers.Fade(11698,11932,0,1);
            mappers.Fade(11932,13573,1,1);
            mappers.Fade(13573,13819,1,0); 
            artist.Fade(7948,8182,0,1);
            artist.Fade(8182,10877,1,1);
            artist.Fade(10877,11580,1,0); 
            song.Fade(4198,4432,0,1);
            song.Fade(4432,10877,1,1);
            song.Fade(10877,11580,1,0);
            sber.Fade(353970,354204,0,1);
            sber.Fade(354204,357485,1,1);
            sber.Fade(357485,357720,1,0);
            thanks.Fade(357720,357954,0,1);
            thanks.Fade(357954,361235,1,1);
            thanks.Fade(361235,363345,1,0);
            
   

            mentai(15447,28807, 15682, 30448);
            akitoshi(30448, 60213, 30565, 60448);
            mentai(60448, 90213, 60682, 90448);
            akitoshi(90448, 120213,90682,120448);
            mentai(120448,150213,120682,150448);
            akitoshi(150448, 207505, 150682, 207722);
            mentai(207722,261530,207939, 261698);
            akitoshi(261698,305663,261870, 305835);
            mentai(305835,346235,306007,346470);



        }
        void mentai(int start, int end, int movestop, int fadeout){
            var mentai = GetLayer("Text").CreateSprite("sb/txt/mentai.png");
            mentai.Fade(start,end,1,1);
            mentai.Fade(end,fadeout,1,0);
            mentai.Move(OsbEasing.OutExpo, start, movestop, -200, 120, 180, 120 );
        }

        void akitoshi(int start, int end, int movestop, int fadeout){
            var akitoshi = GetLayer("Text").CreateSprite("sb/txt/akitoshi.png");
            akitoshi.Fade(start,end,1,1);
            akitoshi.Fade(end,fadeout,1,0);
            akitoshi.Move(OsbEasing.OutExpo, start, movestop, -200, 120, 180, 120 );
        }
    }
}
