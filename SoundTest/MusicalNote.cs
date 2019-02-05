using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTest
{
    public class MusicalNote
    {
        public MusicalNote(bool stretched = false)
        {
            if (!stretched)
            {
                Do1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\do1.wav";
                Re1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\re1.wav";
                Mi1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\mi1.wav";
                Fa1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\fa1.wav";
                Sol1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\sol1.wav";
                La1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\la1.wav";
                Si1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\si1.wav";
                Do2 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\default\do2.wav";
            }
            else
            {
                Do1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\do1.wav";
                Re1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\re1.wav";
                Mi1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\mi1.wav";
                Fa1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\fa1.wav";
                Sol1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\sol1.wav";
                La1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\la1.wav";
                Si1 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\si1.wav";
                Do2 = @"D:\GitHub\SoundTest\SoundTest\SoundTest\musicalnote\stretched\do2.wav";
            }
        }

        public string Do1 { get; set; }
        public string Re1 { get; set; }
        public string Mi1 { get; set; }
        public string Fa1 { get; set; }
        public string Sol1 { get; set; }
        public string La1 { get; set; }
        public string Si1 { get; set; }
        public string Do2 { get; set; }
    }
}
