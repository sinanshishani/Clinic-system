using EClinic.Framework.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace EClinic.Enums
{
    public enum DiseaseCause
    {
        [LocalizedDescription("CongenitalDisease")]
        CongenitalDisease = 1,

        [LocalizedDescription("NonCongenitalDiseaseFateAndDestiny")]
        NonCongenitalDiseaseFateAndDestiny = 2,

        [LocalizedDescription("NormalInjury")]
        NormalInjury = 3,

        [LocalizedDescription("SportsInjury")]
        SportsInjury = 4,

        [LocalizedDescription("TrafficAccidentInjury")]
        TrafficAccidentInjury = 5,

        [LocalizedDescription("BrawlInjury")]
        BrawlInjury = 6
    }
}
