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
    public class Effects : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            HitLight1();
            thinEFFECT();
            StreamLight(86698, 88455);
            ThinStreamLight(96073, 97830);
            StreamLight(146698, 148104);
            boosh();
            StreamLight(192084,193713);
            StreamLight(193821,205876);
            StreamLight(253422,254428);
            StreamLight(256538,257382); 
            StreamLight(259440,260244);
            StreamLight(271353,272646);
            StreamLight(293594,294111);
            StreamLight(299629,299973);
            StreamLight(300146,300232);
            StreamLight(303077,305404);
            StreamLight(306354,307741);
            StreamLight(309140,310915);
            StreamLight(312013,312939);
            StreamLight(315015,315400);
            StreamLight(318145,318547);
            StreamLight(329595,331114); 
            StreamLight(344595,346352);
            StreamLight(359595,361235);
            StreamLight(282042,282387);

            //200776 205993 

        }

        void boosh()
        {
            var beat = Beatmap.GetTimingPointAt(126072).BeatDuration;
            int[] bsh = {126073, 126541, 127010, 127479,
            141073,141541,142010, 142479, 133573,
            205985,206419,206854,207288,
            265835, 266180,266525,266870,
            287904, 288249, 288594 };
            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach (var time in bsh)
                {
                    if (time >= hitobject.StartTime - 5 && time <= hitobject.StartTime + 5)
                    {
                        var big = GetLayer("Effects").CreateSprite("sb/stage/big_r.png", OsbOrigin.Centre, hitobject.Position);
                        big.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.25, 0.25 * 3);
                        big.Fade(OsbEasing.InQuart, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                        
                        var hitlight = GetLayer("Effects").CreateSprite("sb/stage/hl.png", OsbOrigin.Centre, hitobject.Position);
                        hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.7, 0.7 * 2);
                        hitlight.Fade(OsbEasing.InQuart, hitobject.StartTime, hitobject.EndTime + 1000, 0.6, 0);
                        for (int i = 0; i < 25; i++)
                        {
                            var square = GetLayer("Effects").CreateSprite("sb/particles/pixel.png", OsbOrigin.Centre);


                            double t = Random(0, Math.PI * 2);
                            var radius = Random(20, 150);
                            double x = radius * Math.Cos(t) + hitobject.Position.X;
                            double y = radius * Math.Sin(t) + hitobject.Position.Y;

                            square.Move(OsbEasing.OutExpo, hitobject.StartTime + Random(0, 100), hitobject.StartTime + 1000, hitobject.Position, x, y);
                            square.Fade(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + beat * 16, 1, 0);
                            square.Scale(hitobject.StartTime, Random(1, 1.2));
                        }
                    }
                }
            }

        }
        void ThinStreamLight(int StartTime, int EndTime)
        {
            var beat = Beatmap.GetTimingPointAt(30448).BeatDuration;
            var hitobjectLayer = GetLayer("Effects");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime)
                    continue;

                var hitlight = GetLayer("Effects").CreateSprite("sb/stage/small_r.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 0.10, 0.10 * 3);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 1, 0);

            }
        }

        void StreamLight(int StartTime, int EndTime)
        {
            var beat = Beatmap.GetTimingPointAt(30448).BeatDuration;
            var hitobjectLayer = GetLayer("Effects");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime)
                    continue;

                var hitlight = GetLayer("Effects").CreateSprite("sb/stage/hl.png", OsbOrigin.Centre, hitobject.Position);
                hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.7, 0.7 * 2);
                hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);

            }
        }



        void thinEFFECT()
        {
            var beat = Beatmap.GetTimingPointAt(30448).BeatDuration;
            var hitobjectLayer = GetLayer("Effects");
            int[] melody1 = {60448,61385,62323,63260,63729,64198,65604,66073,67479,67713,67948,68885,69823,
            70760, 71229, 71698, 73104, 73573, 74276, 74979, 75448, 76385, 77323, 78260, 78729, 79198, 80604,
            81073, 82479, 82713, 82948, 83885, 84823, 85760, 86229,
            //part 2
            105916,106385,106854, 107323, 107791, 108260, 109198, 109666, 110135, 110604, 111073,113416, 113885, 114354,
            114823, 115291, 115760, 116229, 116698, 117166, 117635, 118104,
            //part 3 kiai
            121619, 121854, 122088, 122323, 122791, 123260, 123494, 123729, 124198,
            129119, 129354, 129588, 129823, 130291, 130760, 130994, 131229, 131463, 131698,
            134744, 134979, 135213, 136619, 136854, 137088, 137323, 137791, 138260, 138494, 138729, 139198,
            144119, 144354, 144588, 144823, 145291, 145760, 145994, 146229, 146463,
            //part 4
            179907, 180776,181646,182515,182950,183385,184689,185124,186428,186646,186863,187733,188602,189477,189912,
            190346,191649,207080, 
            207733,211211,214689,219907, 242522, 
            //part 5 182515 179907 180776 181646 182515 214689 219907 
            252818, 255976, 257476,258917,
            //MID
            283249,283422,283594,
            //super hihg speed part boom boom boom  
            284629,284801,284973,285146,285491,285835,286008,286180,286525,
            288077,288766,288939,
            290146,290318,290491,290663,291008,291353,291525,291698,291870,292042,293422,294284,
            294456, 295663,295835,296008,296180,296870,297042,297215,297387,297560,
            299111,299456,301180,301353,301525,301698,302042,302387,302560,302732,302904,
            //idk anymore  
            305491,311458, 331233, 331470};
            foreach (var hitobject in Beatmap.HitObjects)
            {
                foreach (var time in melody1)
                {
                    if (time >= hitobject.StartTime - 5 && time <= hitobject.StartTime + 5)
                    {

                        var thin = GetLayer("Effects").CreateSprite("sb/stage/small_r.png", OsbOrigin.Centre, hitobject.Position);
                        var thinb = GetLayer("Effects").CreateSprite("sb/stage/small_rb.png", OsbOrigin.Centre, hitobject.Position);
                        thin.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 0.10, 0.10 * 3);
                        thin.Fade(OsbEasing.InQuart, hitobject.StartTime, hitobject.EndTime + 700, 1, 0);
                        thinb.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 0.10, 0.10 * 3);
                        thinb.Fade(OsbEasing.InQuart, hitobject.StartTime, hitobject.EndTime + 700, 1, 0);
                        for (int i = 0; i < 25; i++)
                        {
                            var square = GetLayer("Effects").CreateSprite("sb/particles/pixel.png", OsbOrigin.Centre);


                            double t = Random(0, Math.PI * 2);
                            var radius = Random(20, 150);
                            double x = radius * Math.Cos(t) + hitobject.Position.X;
                            double y = radius * Math.Sin(t) + hitobject.Position.Y;

                            square.Move(OsbEasing.OutExpo, hitobject.StartTime + Random(0, 100), hitobject.StartTime + 1000, hitobject.Position, x, y);
                            square.Fade(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + beat * 16, 1, 0);
                            square.Scale(hitobject.StartTime, Random(1, 1.2));

                        }
                    }
                }
            }
        }

        void HitLight1()
        {
            var beat = Beatmap.GetTimingPointAt(30448).BeatDuration;

            //ring 1 or small ring with light NOT thinEFFECT!!!
            int[] r1 = { 30448, 31385, 32323, 33260, 33729, 35604, 36073 , 37479, 37713, 38885, 39823, 40760,
            41229, 43104, 43573, 44276, 44979, 47323, 48260, 48729, 50604, 51073, 52479, 52713, 54823, 55760,
            56229, 58573, 58104,
            93260, 100760,
            163807,164041,164276, 164510, 164744, 164979,
            178186,178620,179055,179490,
            221646,222080,222515,222952,225128,225563, 225998, 226433, 226863,228174,228602,229037,229472,229907, //here
            232080,232950,233820,
            //changes 221646 222080 226863 228602 232080 232950
            247950,248169,248604,249038,
            260351,261028,261363,
            307914,308261,308608,311093,313689,314064,314439,
            317545,319966,320376,320792,323746,323964,324183,325065,325954,326845,327293,327744,327744,
            332407,333345,334282,335220,336157,337095,338032,338970,339907,340845,341782,342720,343657,
            346470,350220,353970,357720,361235,
            281008,281180,281353,281525,281698,281870};
            //247950 245993

            //ring big, or EFFECT
            int[] rb = {34198, 35135, 37948, 41698, 42635, 45448, 46385, 49198, 52948, 53885, 56698, 57635,
            88573,89041,89510,89979,
            94198, 90448, 97948, 
            105448,112948, 118573, 120448, 101698, 103573, 127948, 135448, 142948, 148573,
            150448, 165448, 169198, 172834, 176422,
            193820,200776,202515,204254,205124, 205993, 206428, 206863,207298,
            223387,230341, 235559,239037,242515,245993,261698, 267215,272732,278249, 
            283766, 289284,294801,
            298939,299284,299973,300318,
            305834,279629,280318}; 

            //200776 193820 202515 204254 205124 205993 219907 230341 235559  261698

            //highlights
            int[] hl = { 90916, 91385, 91854, 92088, 92323, 92791, 94666, 95135, 99588, 98416, 98885, 99354, 99823,
            100291, 101229, 102166, 102635, 103104};

            foreach (var hitobject in Beatmap.HitObjects)
            {
                //hit light
                foreach (var time in hl)
                {
                    if (time >= hitobject.StartTime - 5 && time <= hitobject.StartTime + 5)
                    {
                        if (hitobject is OsuSlider)
                        {
                            var hitlight = GetLayer("Effects").CreateSprite("sb/stage/hl.png", OsbOrigin.Centre, hitobject.Position);
                            hitlight.Scale(OsbEasing.OutCubic, hitobject.EndTime, hitobject.EndTime + 1000, 0.7, 0.7 * 2);
                            hitlight.Fade(OsbEasing.OutCubic, hitobject.EndTime, hitobject.EndTime + 1000, 1, 0);
                            hitlight.Move(hitobject.EndTime, hitobject.EndPosition);
                        }
                        else
                        {
                            var hitlight = GetLayer("Effects").CreateSprite("sb/stage/hl.png", OsbOrigin.Centre, hitobject.Position);
                            hitlight.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.7, 0.7 * 2);
                            hitlight.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                        }
                    }

                }

                //big ring
                foreach (var time in rb) 
                {
                    if (time >= hitobject.StartTime - 5 && time <= hitobject.StartTime + 5)
                    {
                        var big = GetLayer("Effects").CreateSprite("sb/stage/big_r.png", OsbOrigin.Centre, hitobject.Position);
                        big.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 0.25, 0.25 * 3);
                        big.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 1000, 1, 0);
                        for (int i = 0; i < 25; i++)
                        {
                            var square = GetLayer("Effects").CreateSprite("sb/particles/pixel.png", OsbOrigin.Centre);


                            double t = Random(0, Math.PI * 2);
                            var radius = Random(20, 150);
                            double x = radius * Math.Cos(t) + hitobject.Position.X;
                            double y = radius * Math.Sin(t) + hitobject.Position.Y;

                            square.Move(OsbEasing.OutExpo, hitobject.StartTime + Random(0, 100), hitobject.StartTime + 1000, hitobject.Position, x, y);
                            square.Fade(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + beat * 16, 1, 0);
                            square.Scale(hitobject.StartTime, Random(1, 1.2));
                        }
                    }
                }
                //small ring
                foreach (var time in r1)
                {
                    if (time >= hitobject.StartTime - 5 && time <= hitobject.StartTime + 5)
                    {
                        var thin = GetLayer("Effects").CreateSprite("sb/stage/small_r.png", OsbOrigin.Centre, hitobject.Position);
                        var thinb = GetLayer("Effects").CreateSprite("sb/stage/small_rb.png", OsbOrigin.Centre, hitobject.Position);
                        thin.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 0.10, 0.10 * 3);
                        thin.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 1, 0);
                        thinb.Scale(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 0.10, 0.10 * 3);
                        thinb.Fade(OsbEasing.OutCubic, hitobject.StartTime, hitobject.EndTime + 700, 1, 0);
                        //thin.Additive(hitobject.StartTime, hitobject.EndTime + 700);
                        //thinb.Additive(hitobject.StartTime, hitobject.EndTime + 700);
                        for (int i = 0; i < 25; i++)
                        {
                            var square = GetLayer("Effects").CreateSprite("sb/particles/pixel.png", OsbOrigin.Centre);


                            double t = Random(0, Math.PI * 2);
                            var radius = Random(20, 150);
                            double x = radius * Math.Cos(t) + hitobject.Position.X;
                            double y = radius * Math.Sin(t) + hitobject.Position.Y;

                            square.Move(OsbEasing.OutExpo, hitobject.StartTime + Random(0, 100), hitobject.StartTime + 1000, hitobject.Position, x, y);
                            square.Fade(OsbEasing.OutExpo, hitobject.StartTime, hitobject.StartTime + beat * 16, 1, 0);
                            square.Scale(hitobject.StartTime, Random(1, 1.2));
                        }
                    }
                }
            }
        }
    }
}
