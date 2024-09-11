using System;

using R5T.T0131;


namespace D8S.W0007
{
    [ValuesMarker]
    public partial interface IPageRoutes : IValuesMarker,
        R000.IPageRoutes
    {
#pragma warning disable IDE1006 // Naming Styles
        public new Raw.IPageRoutes _Raw => Raw.PageRoutes.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
