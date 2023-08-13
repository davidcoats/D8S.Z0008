using System;


namespace D8S.Z0008
{
    public class Links : ILinks
    {
        #region Infrastructure

        public static ILinks Instance { get; } = new Links();


        private Links()
        {
        }

        #endregion
    }
}
