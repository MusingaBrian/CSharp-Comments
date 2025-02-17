﻿/*-----------------------------------------------*/
/*  This is a multiline comment
string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*-----------------------------------------------*/



/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

/*-----------------------------------------------*/



/*
Random random = new Random();

string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);

    string prefix = Convert.ToChar(prefixValue).ToString();

    string suffix = random.Next(1, 1000).ToString();

    orderIDs[i] = prefix + suffix;
}


foreach (string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/


/*-----------------------------------------------*/

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string str = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = str.ToCharArray();

// Reverse the chars
Array.Reverse(charMessage);

int x = 0;

// count the o's
foreach (char i in charMessage)
{
    if (i == 'o') x++;
}

// convert it back to a string
string new_message = new String(charMessage);

// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");