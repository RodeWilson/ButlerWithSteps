using System;

namespace ButlerWithSteps
{
    public class Step_2_Options : Step
    {
        private Step _option1;
        private Step _option2;

        public Step_2_Options()
        {
            _option1 = new Step_3_Option1();
            _option2 = new Step_3_Option2();

            _option1.SetPrevious(this);
            _option2.SetPrevious(this);
        }

        public override void Show()
        {
            Log("[Step 2]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Please choose one of the following:");
                Display("");
                Display("[1] Option 1");
                Display("[2] Option 2");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.D1 && input.Key != ConsoleKey.D2);

            if (input.Key == ConsoleKey.D1)
            {
                _option1.Show();
            }

            if (input.Key == ConsoleKey.D2)
            {
                _option2.Show();
            }
        }
    }
}