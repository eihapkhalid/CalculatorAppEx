This is a console application for a calculator. The application has a UIHelper class, which contains the methods for displaying options to the user, and a BusinessLayer (BL) interface, which defines the methods that perform the calculations.

The application supports two calculator types: Normal and Scientific. Normal calculator supports addition, subtraction, multiplication, and division. Scientific calculator supports sin, cos, and tan functions.

The Program class contains the main method, where the application's ServiceCollection is created and registered with the required services. The application's Service Provider is also built, and the UIHelper is instantiated inside a while loop. The user is prompted with options to either use the normal or scientific calculator. The user's selection is read using the Console.ReadLine() method, and the selected option is executed.

In the UIHelper class, the constructor takes four parameters, two instances of the IBusinessLayer interface (one for the normal calculator and one for the scientific calculator) and two instances of the Model classes. The Model classes are used to pass input values and receive calculated results from the BusinessLayer methods.

The BL interface defines the methods that perform calculations for both the Normal and Scientific calculator. The ClsNormalCal and ClsSincCal classes implement the interface for the normal and scientific calculators, respectively. These classes contain the logic for performing the calculations based on the user's input values.

Overall, this is a simple console application that demonstrates the use of interfaces and dependency injection in C#.
