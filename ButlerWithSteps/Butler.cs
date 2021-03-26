using System.Collections.Generic;

namespace ButlerWithSteps
{
    public class Butler
    {
        public Butler()
        {

        }

        public void Run()
        {
            var welcome = new Step_1_Welcome();

            welcome.Show();
        }
    }
}