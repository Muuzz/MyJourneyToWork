using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private object calculator;
        private ReadOnlySpan<char> distance;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculator = new Calculator();
        }

        [Given(@"I set the distance to ""([^""]*)"" kilometers")]
        public void GivenISetTheDistanceToKilometers(string p0)
        {
            if (calculator == null)
            {
                calculator = new Calculator();
            }

            if (double.TryParse(distance, out double distanceValue))
            {
                calculator.distance = distanceValue;
            }
        }

        [Then(@"the carbon-friendly message should be ""([^""]*)""")]
        public void ThenTheCarbon_FriendlyMessageShouldBe(string p0)
        {
            throw new PendingStepException();
        }
    }
}
