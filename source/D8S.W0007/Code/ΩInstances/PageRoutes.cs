using System;


namespace D8S.W0007
{
    public class PageRoutes : IPageRoutes
    {
        #region Infrastructure

        public static IPageRoutes Instance { get; } = new PageRoutes();


        private PageRoutes()
        {
        }

        #endregion
    }
}


namespace D8S.W0007.Raw
{
    public class PageRoutes : IPageRoutes
    {
        #region Infrastructure

        public static IPageRoutes Instance { get; } = new PageRoutes();


        private PageRoutes()
        {
        }

        #endregion
    }
}