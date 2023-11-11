namespace TestMyJourneyToWork
{
    using Calculator;
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void SustainabilityWeighting_CalculateForDeisel()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 100.0,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 3,
                transportMode = TransportModes.deisel
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(6000, sustainabilityWeighting);
        }

        [TestMethod]
        public void SustainabilityWeighting_CalculateForPetrol()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 90.0,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 5,
                transportMode = TransportModes.petrol
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(4473.872584108804, sustainabilityWeighting);
        }

        [TestMethod]
        public void SustainabilityWeighting_CalculateForHybrid()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 33.0,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 4,
                transportMode = TransportModes.hybrid
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(1584, sustainabilityWeighting);
        }

        [TestMethod]
        public void SustainabilityWeighting_CalculateForElectric()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 1.0,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 7,
                transportMode = TransportModes.electric
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(34.796786765290705, sustainabilityWeighting);
        }
        [TestMethod]
        public void SustainabilityWeighting_CalculateForMotorbike()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 99,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 5,
                transportMode = TransportModes.motorbike
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(2970, sustainabilityWeighting);
        }

        [TestMethod]
        public void SustainabilityWeighting_CalculateForElectrickbike()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 99,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 5,
                transportMode = TransportModes.electricbike
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(1980, sustainabilityWeighting);
        }
        [TestMethod]
        public void SustainabilityWeighting_CalculateForTrain()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 13,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 4,
                transportMode = TransportModes.train
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(193.86781197804817, sustainabilityWeighting);
        }
        [TestMethod]
        public void SustainabilityWeighting_CalculateForBus()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 11,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 2,
                transportMode = TransportModes.bus
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(132, sustainabilityWeighting);
        }
        [TestMethod]
        public void SustainabilityWeighting_CalculateForTram()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 50,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 5,
                transportMode = TransportModes.tram
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(932.0567883560009, sustainabilityWeighting);
        }

        [TestMethod]
        public void SustainabilityWeighting_CalculateForCycling()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 44,
                milesOrKms = DistanceMeasurement.miles,
                numDays = 2,
                transportMode = TransportModes.cycling
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(0.88, sustainabilityWeighting);
        }
        [TestMethod]
        public void SustainabilityWeighting_CalculateForWalking()
        {
            // Arrange
            Calculator calculator = new Calculator
            {
                distance = 1000,
                milesOrKms = DistanceMeasurement.kms,
                numDays = 2,
                transportMode = TransportModes.walking
            };

            // Act
            double sustainabilityWeighting = calculator.sustainabilityWeighting;

            // Assert
            Assert.AreEqual(12.427423844746679, sustainabilityWeighting);
        }


    }

}