Feature: Web-based Calculator
	In order to be able to make simple calculations
	As a user of multiple devices
	I want to be able to have access to a calculator from all of them

Scenario Outline: Functionalities with two numbers
	Given I have navigated to the web calc's webpage
	When I press <First Number>
	And I press <First Operator>
	And I press <Second Number>
	And I press <Final Key>
	Then the result should be <Result> on the screen

	Examples: 
	| First Number | First Operator | Second Number | Final Key | Result |
	| 1            | +              | 1             | =         | 2      |
	| 5            | -              | 1             | =         | 4      |
	| 5            | x              | 2             | =         | 10     |
	| 8            | ÷              | 2             | =         | 4      |
	| 5            | +              | 5             | %         | 5.25   |

Scenario Outline: Functionalities with one number
	Given I have navigated to the web calc's webpage 
	When I press <First Number>
	And I press <Function Key>
	Then the result should be <Result> on the screen

	Examples: 
	| First Number | Function Key | Result |
	| 1            | ←            | 0      |
	| 5            | CE           | 0      |
	| 5            | ±            | -5     |

