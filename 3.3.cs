using System;
using System.IO;
class Program {
  public static void Main (string[] args) {
    string[] numbers = File.ReadAllText("nums1.txt").Split(' ');
    int[] height = Array.ConvertAll(numbers, int.Parse);
    int maxArea = 0;
    int left = 0;
    int right = height.Length - 1;
    int maxLeft = 0;
    int maxRight = 0;
    while (left < right) {
      int currentArea = Math.Min(height[left], height[right]) * (right - left);
      if (currentArea > maxArea) {
        maxArea = currentArea;
        maxLeft = left;
        maxRight = right;
      }
      if (height[left] < height[right]) {
        left++;
      } else {
        right--;
      }
    }
    Console.WriteLine("Max area: " + maxArea);
    Console.WriteLine("Container barriers: " + "[ " + height[maxLeft] + " ; " + height[maxRight] + " ]");
  }
}