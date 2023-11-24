Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](AcceptanceTests/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
  Scenario: Check Carbon-Friendly Message
    Given I have a calculator
    And I set the distance to "20" kilometers
    And I select the distance measurement as "Kilometers"
    And I set the number of days to "3"
    And I select the transport mode as "Cycling"
    When the user clicks on calculate
    Then the carbon-friendly message should be "Thank you for being environmentally friendly."
