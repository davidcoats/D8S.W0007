using System;


namespace D8S.W0007.R000
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


namespace D8S.W0007.R000.Raw
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