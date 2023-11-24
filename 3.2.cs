using System;
using System.IO;
class Program {
  public static void Main (string[] args) {
    string[] numbers = File.ReadAllText("nums.txt").Split(' ');
    string result = "";
    foreach (var number in numbers) {
      int n = int.Parse(number);
      if (n % 2 != 0) {
        result += number + " ";
      }
    }
    File.WriteAllText("nums.txt", result);
  }
}