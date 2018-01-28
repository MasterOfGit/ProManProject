using ProMan_Simulator.Helper;

namespace ProMan_Simulator.Test
{
    public abstract class BaseTest
    {
        protected HttpHelper _httphelper;
        protected int ID;

        public BaseTest()
        {
            _httphelper = new HttpHelper(@"http://localhost:50435/");
        }

    }
}
