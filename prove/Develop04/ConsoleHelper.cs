
using System;

class ConsoleHelper
{
  // Method to write a message in white color
  static void Write(string msg)
  {
    Console.WriteLine(msg);
    Console.ForegroundColor = ConsoleColor.White;
  }

  // Method to display message in green color
  public void GreenMsg(string msg)
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Write(msg);
  }

  // Method to display message in red color
  public void RedMsg(string msg)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Write(msg);
  }

  // Method to get integer input from user within specified range
  public int GetIntFromUser(string askMsg, int maxValue, int minValue = 1)
  {
    int userNumber;
    bool inputValid;

    // Loop until valid input is received
    do
    {
      Console.Write(askMsg);
      inputValid = int.TryParse(Console.ReadLine(), out userNumber);

      // Checking if input is within range
      if (inputValid)
      {
        inputValid = userNumber >= minValue && userNumber <= maxValue;
      }

      // Displaying error message if input is invalid
      if (!inputValid)
      {
        RedMsg("Your response is not quite right. Please try again.");
      }
    } while (!inputValid);

    return userNumber;
  }
}