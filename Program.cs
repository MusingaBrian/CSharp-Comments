/*  This is a multiline comment
string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

Random random = new Random();

string[] orderIDs = new string[5];

//Looping Through Each of Blank OrderID.
for (int i = 0; i < orderIDs.Length; i++)
{
    //Get a random value that equates to ASCII letters A through E.
    int prefixValue = random.Next(65, 70);

    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();

    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString();

    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}

// Print out each orderID
foreach (string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
