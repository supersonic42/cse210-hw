/*
Project: Eternal Quest
Author: Anton Sanakoev

Exceeding requirements:
1. Instead of keeping total score of the Goal Manager in the file, i decided to count it dynamically:
Each time file is loaded, program runs throughs all goals and calculates total score by calling CalculatePoints() 
function for each goal.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new();
        goalManager.Start();
    }
}