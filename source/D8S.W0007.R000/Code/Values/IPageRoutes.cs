using System;

using R5T.T0131;
using R5T.T0143;


namespace D8S.W0007.R000
{
    [ValuesMarker]
    public partial interface IPageRoutes : IValuesMarker
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public Raw.IPageRoutes _Raw => Raw.PageRoutes.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <inheritdoc cref="Raw.IPageRoutes._backslash"/>
        public const string Home = Raw.IPageRoutes._backslash;

        /// <summary>
        /// <para><value>/our-story</value></para>
        /// </summary>
        public const string OurStory = "/our-story";

        /// <summary>
        /// <para><value>/schedule</value></para>
        /// </summary>
        public const string Schedule = "/schedule";

        /// <summary>
        /// <para><value>/location</value></para>
        /// </summary>
        public const string Location = "/location";

        /// <summary>
        /// <para><value>/RSVP</value></para>
        /// </summary>
        public const string RSVP = "/RSVP";
    }
}
