using System;


namespace D8S.W0007
{
    public class PageTitles : IPageTitles
    {
        #region Infrastructure

        public static IPageTitles Instance { get; } = new PageTitles();


        private PageTitles()
        {
        }

        #endregion
    }
}


namespace D8S.W0007.Raw
{
    public class PageTitles : IPageTitles
    {
        #region Infrastructure

        public static IPageTitles Instance { get; } = new PageTitles();


        private PageTitles()
        {
        }

        #endregion
    }
}