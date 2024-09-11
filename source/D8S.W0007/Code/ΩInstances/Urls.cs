using System;


namespace D8S.W0007
{
    public class Urls : IUrls
    {
        #region Infrastructure

        public static IUrls Instance { get; } = new Urls();


        private Urls()
        {
        }

        #endregion
    }
}


namespace D8S.W0007.Raw
{
    public class Urls : IUrls
    {
        #region Infrastructure

        public static IUrls Instance { get; } = new Urls();


        private Urls()
        {
        }

        #endregion
    }
}