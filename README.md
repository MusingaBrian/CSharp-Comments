## C# Comments

## C# Comments, Whitespace and Variable Declaration Rule For Code Readability.

```
/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
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

```

```

/*
   This code reverses a message, counts the number of times
   a particular character appears, then prints the results
   to the console window.
 */

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);

int x = 0;

foreach (char i in charMessage)
{
    if (i == 'o') x++;
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

```
