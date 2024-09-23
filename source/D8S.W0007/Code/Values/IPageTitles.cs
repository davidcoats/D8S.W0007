using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.W0007
{
    [ValuesMarker]
    public partial interface IPageTitles : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IPageTitles _Raw => Raw.PageTitles.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPageTitles.Riya_and_Vedu"/>
        public string For_Home => _Raw.Riya_and_Vedu;

        /// <summary>
        /// <para><value>Our Story</value></para>
        /// </summary>
        public string For_OurStory => $"{_Raw.Riya_and_Vedu} - Our Story";

        /// <summary>
        /// <para><value>Schedule</value></para>
        /// </summary>
        public string For_Schedule => $"{_Raw.Riya_and_Vedu} - Schedule";

        /// <summary>
        /// <para><value>Location</value></para>
        /// </summary>
        public string For_Location => $"{_Raw.Riya_and_Vedu} - Location";

        /// <summary>
        /// <para><value>RSVP</value></para>
        /// </summary>
        public string For_RSVP => $"{_Raw.Riya_and_Vedu} - RSVP";
    }
}
