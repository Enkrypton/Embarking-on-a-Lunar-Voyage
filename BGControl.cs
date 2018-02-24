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
    public class BGControl : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            //Init BG
            var Background_Normal = GetLayer("Background").CreateSprite("sb/bgs/bg_normal.jpg");
            var Background_Bright = GetLayer("Background").CreateSprite("sb/bgs/bg_bright.jpg");
            var Background_Dark = GetLayer("Background_Dark").CreateSprite("sb/bgs/bg_dark.jpg");
            var Background_Desat = GetLayer("BackgroundUp").CreateSprite("sb/bgs/bg_desat.jpg");
            var Background_DesatLow = GetLayer("Background_DesatLow").CreateSprite("sb/bgs/bg_desat.jpg");
            var Dim = GetLayer("Background").CreateSprite("sb/bgs/dim.png");
            var Black = GetLayer("Background").CreateSprite("sb/bgs/dim.png");
            var Vig = GetLayer("Background_Top").CreateSprite("sb/bgs/vignette.png");
            var bye = GetLayer("Background").CreateSprite("maybe.jpg");
            bye.Fade(0, 0);

            //---Starting BG--- [PART1 - MENTAI]
            Black.Fade(0,15564,1,1); //black start
            Black.Scale(0, 480.0/988);

            Flash(15447); 
            
            Background_Dark.Fade(15565,15566,0,1);         //fade in
            Background_Dark.Fade(15566,30330,1,1);         //maintain
            Background_Dark.Fade(30330,30331,0,0);         //reset
            Background_Dark.Scale(15565, 480.0/988);      //size
            
            Background_Normal.Fade(30447,60330,1,1);    //maintain
            Background_Normal.Scale(30447, 480.0/988); //size  

            //Starting BG dim into CursorFollow
            Dim.Fade(28690,30330,0,1); //dim
            Dim.Fade(30330,30448,1,1); //maintain
            Dim.Fade(30448,30449,0,0); //reset

            //---Cursor Follow--- [PART2 - AKITOSHI]
            Vig.Fade(30447,60330,1,1);
            Vig.Scale(30447, 480.0/1080);
            //30447 to 60330 is CursorFollow
            CursorFollow(30448,60213, 16,0,0,0.8,1.2,true,Color4.White);


            //---After Intro--- [PART3 - MENTAI]
            Flash(60330);
            Pulse(60330,90447);
            //spectrum in Spectrum 1 

            //---After Pulse--- [PART4 - AKITOSHI]
            Background_Normal.Fade(90447,93143,1,0);    //fade out
            Background_Bright.Scale(90330, 480.0/988); //size
            Background_Dark.Fade(60330,120447,1,1);     //maintain dark in bg

            //Background_Normal.Fade(105447,120447,0,1);  //fade back normal

            PulseSingleOnDark(94197);
            PulseSingleOnDark(97947);
            PulseSingleOnDark(101697);
            PulseSingleOnDark(103572);

            //---Kiai One--- [PART5 MENTAI]
            //Background_Normal.Fade(120447,150447,1,1);  //maintain
            Background_Dark.Fade(120447,150447,1,1);  //maintain
            Background_Dark.Fade(150447,150682,1,0);
            
            Twinkle(120447,126424); 
            Twinkle(126072,128182); //Pulse Twinkle
            Twinkle(127947,141658);
            Twinkle(141072,143768); //Pulse Twinkle
            Twinkle(133572,135682); //Pulse Twinkle
            Twinkle(135447,136151); //Pulse Twinkle
            Twinkle(142947,150447);
            Twinkle(135447,137322); //Pulse Twinkle
            Twinkle(148572,150330); //Pulse Twinkle

            PulseSingleOnDarkKiai(120447);
            PulseSingleOnDarkKiai(126072);
            PulseSingleOnDarkKiai(126541);
            PulseSingleOnDarkKiai(127010);
            PulseSingleOnDarkKiai(127479);
            PulseSingleOnDarkKiai(127947);
            PulseSingleOnDarkKiai(133572);
            PulseSingleOnDarkKiai(135447);

            PulseSingleOnDarkKiai(141072);
            PulseSingleOnDarkKiai(141541);
            PulseSingleOnDarkKiai(142010);
            PulseSingleOnDarkKiai(142479);
            PulseSingleOnDarkKiai(142947);
            PulseSingleOnDarkKiai(148572);

            //---After Kiai One--- [PART6 AKITOSHI] 
            Dim.Fade(157831,163806,0,0); 
            Background_Desat.Fade(154197,157830,0,1); //Fade in
            Background_Desat.Scale(154192,480.0/988);
            Background_Desat.Fade(157830,160174,1,0); //Fade out
            Background_Desat.Fade(160175,160176,0,0); //reset
            Background_Dark.Fade(157829,157829,0,0); //Reset 
            Background_Dark.Fade(157830,163807,1,1);
            Background_Dark.Fade(163807,164041,1,0);
            Background_Dark.Fade(163808,163809,0,0); //reset
            Background_Normal.Fade(165330,165448,0,1);
            Background_Normal.Fade(165448,179925,1,1);
            Background_Normal.Fade(179926,179927,0,0); //reset
            PulseSingleOnNormal(169197);
            PulseSingleOnNormal(176422); 
            PulseSingleOnNormal(172834); 
            Twinkle(161697,163455); //Pulse Twinkle
            Twinkle(169197,170788); //Pulse Twinkle
            Twinkle(172834,174300); //Pulse Twinkle
            Twinkle(176422,177855); //Pulse Twinkle
            Background_Normal.Fade(179925,207613,1,1); //maintain 
            Background_Normal.Fade(207613,214249,1,0); //out 179925
            Flash(179925);
            PulseSingleOnNormal(193821); 
            Twinkle(193821,207722);
            PulseSingleOnNormal(200772);
            Twinkle(200772,202510); //Pulse Twinkle
            PulseSingleOnNormal(202510);
            Twinkle(202510,204247); //Pulse Twinkle
            PulseSingleOnNormal(204247);
            Twinkle(204247,205985); //Pulse Twinkle
            Background_DesatLow.Fade(0,207613,0,0);
            Background_DesatLow.Fade(207613,239047,1,1); //maintain
            Background_DesatLow.Scale(90330, 480.0/988); //size
            PulseSingleOnDark(223387);
            PulseSingleOnDark(230350);
            Background_Dark.Fade(235572,235680,0,1);
            Background_Dark.Fade(235680,242631,1,1); //maintain
            Background_Dark.Fade(242632,242633,0,0); //reset
            Background_Normal.Fade(239047,239155,0,1);
            Background_Normal.Fade(239155,247735,1,1); //maintain
            Background_Normal.Fade(247735,247843,1,0);
            Background_Normal.Fade(239156,247737,0,0); //reset 
            Twinkle(242522,244260); //Pulse twinkle
            PulseSingleOnNormal(245997);
            Background_Normal.Fade(249472, 249579, 0, 1);
            Background_Normal.Fade(249579, 260244, 1,1);
            Background_Normal.Fade(260244, 260436, 1,0);
            Twinkle(255976,260244);
            Flash(261698);
            Background_Normal.Fade(261698,305835,1,1);
            Background_Normal.Fade(305835,329595,1,0); 
            Background_Normal.Fade(329595,329712,0,1);
            Background_Normal.Fade(329712,331470,1,1);
            Background_Normal.Fade(331470,331587,1,0);
            Background_Dark.Fade(330996,361235,1,1);
            Background_Dark.Fade(361235, 363345,1,0); 
            Flash(267215);
            Pulse(272732,283077);
            Pulse(283422,287904);
            Pulse(289284,293422);
            Pulse(294801,299629);
            Pulse(300318,304456);
            Flash(331470);

            CursorFollow(221647,235137,16,300,300,0.5,1.2,true,Color4.White); //


            


            
        }

        void Flash (int Start){
            var Flash = GetLayer("Background").CreateSprite("sb/bgs/flash.png");
            Flash.Fade(OsbEasing.OutCubic, Start, Start + 1200, 1, 0);
        }

        void Pulse (int Start, int End){
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            var Background = GetLayer("Background_Top").CreateSprite("sb/bgs/bg_normal.jpg");
            //var Background_Back = GetLayer("Background_Back").CreateSprite("sb/bgs/bg_normal.jpg");

            Background.Fade(Start, End+beat, 0.5, 0.5); 

            for(double i = Start; i < End; i += beat)
            {
                Background.Scale(OsbEasing.OutQuad, i, i + beat, 480.0 / 973, 480.0 / 988);
                //Background_Back.Scale(OsbEasing.OutQuad, i, i + beat, 480.0 / 1180, 480.0 / 1200);
                Background.Fade(i, i + beat, 0.2, 0);
            }
        }
        void PulseSingleBright(int now){
            var beat = Beatmap.GetTimingPointAt(now).BeatDuration;
            var Background = GetLayer("Background").CreateSprite("sb/bgs/bg_bright.jpg");
            Background.Scale(OsbEasing.OutQuad, now, now + beat, 480.0 / 973, 480.0 / 988);
        }

        void PulseSingleOnNormal(int Start){
            var Background = GetLayer("Background_Top").CreateSprite("sb/bgs/bg_bright.jpg");
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            Background.Scale(OsbEasing.OutQuad, Start, Start + beat, 480.0 / 973, 480.0 / 988);
            Background.Fade(Start, Start + 700, 1,0);
        }

        void PulseSingleOnDark(int Start){
            var Background = GetLayer("Background_Dark").CreateSprite("sb/bgs/bg_normal.jpg");
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            Background.Scale(OsbEasing.OutQuad, Start, Start + beat, 480.0 / 973, 480.0 / 988);
            Background.Fade(Start, Start + 700, 1,0);
        }

        void PulseSingleOnDarkKiai(int Start){
            var Background = GetLayer("Background_Dark").CreateSprite("sb/bgs/bg_normal.jpg");
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
            Background.Scale(OsbEasing.OutQuad, Start, Start + beat, 480.0 / 973, 480.0 / 988);
            Background.Fade(Start, Start + 700, 1,0);
        }

        void Twinkle(int Start, int End){
            var beat = Beatmap.GetTimingPointAt(Start).BeatDuration;
		    for(int i = 0; i < 40; i++)
            {
                double RandT = Random(beat, beat * 4);
                var Sprite = GetLayer("Stars").CreateSprite("sb/particles/star1.png");

                Sprite.Move(Start, Random(-80, 720), Random(40, 430));
                
                Sprite.StartLoopGroup(Start, (End - Start) / (int)RandT);
                Sprite.Fade(OsbEasing.OutQuad, 0, RandT, 1, 0);
                Sprite.Scale(OsbEasing.OutQuad, 0, RandT, 0.7, 0);
                Sprite.EndGroup();
                
            }

            for(int i = 0; i < 40; i++)
            {
                double RandT = Random(beat, beat * 4);
                var Sprite = GetLayer("Stars").CreateSprite("sb/particles/star1.png");

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
                var Sprite = GetLayer("Stars").CreateSprite("sb/particles/star1.png");

                Sprite.Move(Start, Random(20, 450), Random(40, 120));
                
                Sprite.StartLoopGroup(Start, (End - Start) / (int)RandT);
                Sprite.Fade(OsbEasing.OutQuad, 0, RandT, 1, 0);
                Sprite.Scale(OsbEasing.OutQuad, 0, RandT, 0.7, 0);
                Sprite.EndGroup();
                
            }
        }

        void CursorFollow(int StartTime, int EndTime, int BeatDivisor, int FadeTime, int FadeInTime, double Fade, double Scale, bool Additive, Color4 Color){
            var CursorLayer = GetLayer("Spotlight");
            var Cursor = CursorLayer.CreateSprite("sb/stage/spot.png",OsbOrigin.Centre,new Vector2(320,240));
            Cursor.Fade(OsbEasing.None, StartTime, StartTime + FadeInTime , 0, Fade);
            Cursor.Fade(OsbEasing.None, StartTime + FadeTime, StartTime, 0, Fade);
            Cursor.Fade(OsbEasing.None, EndTime, EndTime + FadeTime, Fade, 0);
            Cursor.Scale(StartTime, Scale);
            Cursor.Color(StartTime, Color);
            var beat = Beatmap.GetTimingPointAt(StartTime);
            var BeatDived = beat.Bpm / BeatDivisor;
            OsuHitObject previousHitobject = null;
            foreach (var currentHitobject in Beatmap.HitObjects)
            {
                if(currentHitobject.StartTime >= StartTime && currentHitobject.StartTime <= EndTime)
                {
                  if(previousHitobject == null)
                 {
                     var I = currentHitobject.StartTime;
                     var beforeI = currentHitobject.StartTime;
                     Cursor.Move(OsbEasing.None,beforeI,I,currentHitobject.Position,currentHitobject.Position);
                    if(currentHitobject is OsuSlider)
                    {
                    var timestep = Beatmap.GetTimingPointAt((int)currentHitobject.StartTime).BeatDuration / BeatDivisor;
                    var startTime = currentHitobject.StartTime;
                    for(var i = currentHitobject.StartTime; i < currentHitobject.EndTime; i += timestep)
                    {
                     var endTime = i + timestep;
                     var startPosition = Cursor.PositionAt(i);
                     Cursor.Move(i, endTime, startPosition, currentHitobject.PositionAtTime(endTime));
                    }

                    if (Additive)
                    {
                    Cursor.Additive(StartTime, EndTime);
                    }
                 }
                 }
                 if (previousHitobject != null)
                {
                    var I = currentHitobject.StartTime;
                    if(previousHitobject is OsuSlider){
                    var beforeI = previousHitobject.EndTime;
                    Cursor.Move(OsbEasing.None,beforeI,I,previousHitobject.EndPosition,currentHitobject.Position);

                }else if(previousHitobject is OsuCircle){
                        var beforeI = previousHitobject.StartTime;
                        Cursor.Move(OsbEasing.None,beforeI,I,previousHitobject.Position,currentHitobject.Position);
                    }

                    if (currentHitobject is OsuSlider)
                    {
                    var timestep = Beatmap.GetTimingPointAt((int)currentHitobject.StartTime).BeatDuration / BeatDivisor;
                    var startTime = currentHitobject.StartTime;
                    for(var i = currentHitobject.StartTime; i < currentHitobject.EndTime; i += timestep)
                    {
                     var endTime = i + timestep;
                     var startPosition = Cursor.PositionAt(i);
                     Cursor.Move(i, endTime, startPosition, currentHitobject.PositionAtTime(endTime));
                    }
                }

                 }

                 previousHitobject = currentHitobject;
                }
            }
        }
    }
}
