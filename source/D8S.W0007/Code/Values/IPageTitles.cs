using System;

using R5T.T0131;
using R5T.T0143;


#pragma warning disable IDE0130
namespace D8S.W0007
{
    [ValuesMarker]
    public partial interface IPageTitles : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IPageTitles _Raw => Raw.PageTitles.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPageTitles.Riya_and_Vedant"/>
        public string For_Home => _Raw.Riya_and_Vedant;

        /// <summary>
        /// <para><value>Riya and Vedant - Our Story</value></para>
        /// </summary>
        public string For_OurStory => $"{_Raw.Riya_and_Vedant} - Our Story";

        /// <summary>
        /// <para><value>Riya and Vedant - Timeline</value></para>
        /// </summary>
        public string For_Timeline => $"{_Raw.Riya_and_Vedant} - Timeline";

        /// <summary>
        /// <para><value>Riya and Vedant - Location</value></para>
        /// </summary>
        public string For_Location => $"{_Raw.Riya_and_Vedant} - Location";

        /// <summary>
        /// <para><value>Riya and Vedant - RSVP</value></para>
        /// </summary>
        public string For_RSVP => $"{_Raw.Riya_and_Vedant} - RSVP";
    }
}
