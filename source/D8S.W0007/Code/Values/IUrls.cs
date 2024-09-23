using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.W0007
{
    [ValuesMarker]
    public partial interface IUrls : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IUrls _Raw => Raw.Urls.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IUrls.N_001"/>
        public string Example_Image => _Raw.N_001;

        /// <inheritdoc cref="Raw.IUrls.N_002"/>
        public string Example_Image_Small => _Raw.N_002;

        /// <inheritdoc cref="Raw.IUrls.N_001"/>
        public string Example_Image_Header => _Raw.N_007;


        /// <inheritdoc cref="Raw.IUrls.N_019"/>
        public string Image_Bombay => _Raw.N_019;

        /// <inheritdoc cref="Raw.IUrls.N_003"/>
        public string Image_Bombay_Local => _Raw.N_003;

        /// <inheritdoc cref="Raw.IUrls.N_020"/>
        public string Image_Brunch => _Raw.N_020;

        /// <inheritdoc cref="Raw.IUrls.N_011"/>
        public string Image_Brunch_Local => _Raw.N_011;

        /// <inheritdoc cref="Raw.IUrls.N_021"/>
        public string Image_Calcutta => _Raw.N_021;

        /// <inheritdoc cref="Raw.IUrls.N_004"/>
        public string Image_Calcutta_Local => _Raw.N_004;

        /// <inheritdoc cref="Raw.IUrls.N_022"/>
        public string Image_ForRSVPHeader => _Raw.N_022;

        /// <inheritdoc cref="Raw.IUrls.N_014"/>
        public string Image_ForRSVPHeader_Local => _Raw.N_014;

        /// <inheritdoc cref="Raw.IUrls.N_023"/>
        public string Image_Ceremony => _Raw.N_023;

        /// <inheritdoc cref="Raw.IUrls.N_010"/>
        public string Image_Ceremony_Local => _Raw.N_010;

        /// <inheritdoc cref="Raw.IUrls.N_024"/>
        public string Image_ForOurStory => _Raw.N_024;

        /// <inheritdoc cref="Raw.IUrls.N_043"/>
        public string Image_ForOurStory_Banner => _Raw.N_043;

        /// <inheritdoc cref="Raw.IUrls.N_046"/>
        public string Image_ForOurStory_HePutARingOnIt => _Raw.N_046;

        /// <inheritdoc cref="Raw.IUrls.N_045"/>
        public string Image_ForOurStory_TheFuture => _Raw.N_045;

        /// <inheritdoc cref="Raw.IUrls.N_018"/>
        public string Image_ForOurStory_LoveAtFirstSight => _Raw.N_044;

        /// <inheritdoc cref="Raw.IUrls.N_018"/>
        public string Image_ForOurStory_Local => _Raw.N_018;

        /// <inheritdoc cref="Raw.IUrls.N_025"/>
        public string Image_ForHomeCelebration => _Raw.N_025;

        /// <inheritdoc cref="Raw.IUrls.N_015"/>
        public string Image_ForHomeCelebration_Local => _Raw.N_015;

        /// <inheritdoc cref="Raw.IUrls.N_026"/>
        public string Image_ForHomeFarewellBrunch => _Raw.N_026;

        /// <inheritdoc cref="Raw.IUrls.N_016"/>
        public string Image_ForHomeFarewellBrunch_Local => _Raw.N_016;

        /// <inheritdoc cref="Raw.IUrls.N_027"/>
        public string Image_ForHomeMeetAndGreet => _Raw.N_027;

        /// <inheritdoc cref="Raw.IUrls.N_017"/>
        public string Image_ForHomeMeetAndGreet_Local => _Raw.N_017;

        /// <inheritdoc cref="Raw.IUrls.N_028"/>
        public string Image_Jaipur_ForSchedule => _Raw.N_028;

        /// <inheritdoc cref="Raw.IUrls.N_008"/>
        public string Image_Jaipur_ForSchedule_Local => _Raw.N_008;

        /// <inheritdoc cref="Raw.IUrls.N_029"/>
        public string Image_MarryMe => _Raw.N_029;

        /// <inheritdoc cref="Raw.IUrls.N_006"/>
        public string Image_MarryMe_Local => _Raw.N_006;

        /// <inheritdoc cref="Raw.IUrls.N_030"/>
        public string Image_MehndiAndSangeet => _Raw.N_030;

        /// <inheritdoc cref="Raw.IUrls.N_009"/>
        public string Image_MehndiAndSangeet_Local => _Raw.N_009;

        /// <inheritdoc cref="Raw.IUrls.N_031"/>
        public string Image_ForLocationHeader => _Raw.N_031;

        /// <inheritdoc cref="Raw.IUrls.N_013"/>
        public string Image_ForLocationHeader_Local => _Raw.N_013;

        /// <inheritdoc cref="Raw.IUrls.N_032"/>
        public string Image_RiyaAndVedant_Small => _Raw.N_032;

        /// <inheritdoc cref="Raw.IUrls.N_012"/>
        public string Image_RiyaAndVedant_Small_Local => _Raw.N_012;

        /// <inheritdoc cref="Raw.IUrls.N_047"/>
        public string Image_RSVP_Banner => _Raw.N_047;

        /// <inheritdoc cref="Raw.IUrls.N_033"/>
        public string Image_Singapore => _Raw.N_033;

        /// <inheritdoc cref="Raw.IUrls.N_005"/>
        public string Image_Singapore_Local => _Raw.N_005;

        /// <inheritdoc cref="Raw.IUrls.N_034"/>
        public string Image_ForSchedule_HaldiAndLunch => _Raw.N_034;

        /// <inheritdoc cref="Raw.IUrls.N_035"/>
        public string Image_ForSchedule_MehndiAndLunch => _Raw.N_035;

        /// <inheritdoc cref="Raw.IUrls.N_036"/>
        public string Image_ForSchedule_SangeetAndDinner => _Raw.N_036;

        /// <inheritdoc cref="Raw.IUrls.N_032"/>
        public string Image_ForOpenGraph => _Raw.N_032;

        /// <inheritdoc cref="Raw.IUrls.N_037"/>
        public string Image_ForMainPage_Location => _Raw.N_037;

        /// <inheritdoc cref="Raw.IUrls.N_038"/>
        public string Image_ForMainPage_OurStory => _Raw.N_038;

        /// <inheritdoc cref="Raw.IUrls.N_039"/>
        public string Image_ForMainPage_Main => _Raw.N_039;

        /// <inheritdoc cref="Raw.IUrls.N_040"/>
        public string Image_ForLocation_Banner => _Raw.N_040;

        /// <inheritdoc cref="Raw.IUrls.N_042"/>
        public string Image_ForLocation_Venue => _Raw.N_042;
    }
}
