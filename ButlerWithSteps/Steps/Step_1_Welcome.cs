using System;

namespace ButlerWithSteps
{
    public class Step_1_Welcome : Step
    {
        private readonly Step _next;

        public Step_1_Welcome()
        {
            _next = new Step_2_Options();
            _next.SetPrevious(this);
        }

        public override void Show()
        {
            Log("[Step 1]");

            ConsoleKeyInfo input;

            do
            {
                Console.Clear();

                Display("Welcome, dear guest.");
                Display("My name is Alfred and I will guide you.");
                Display("");
                Display("Please hit [ENTER] to continue...");
                Display("");

                input = Console.ReadKey();
            }
            while (input.Key != ConsoleKey.Enter);

            _next.Show();
        }
    }
}