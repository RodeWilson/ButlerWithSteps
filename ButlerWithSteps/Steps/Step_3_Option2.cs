using System;

namespace ButlerWithSteps
{
    public class Step_3_Option2 : Step
    {
        public Step_3_Option2()
        {

        }

        public override void Show()
        {
            Log("[Option 2]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Option 2");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.Escape);

            base.Back();
        }
    }
}