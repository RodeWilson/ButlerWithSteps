using System;

namespace ButlerWithSteps
{
    public class Step_3_Option1 : Step
    {
        public Step_3_Option1()
        {

        }

        public override void Show()
        {
            Log("[Option 1]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Option 1");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.Escape);

            base.Back();
        }
    }
}