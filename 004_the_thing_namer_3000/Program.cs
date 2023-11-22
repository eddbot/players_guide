Console.WriteLine("What kind of thing are we talking about?");
string? a = Console.ReadLine(); // the thing
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string? b = Console.ReadLine(); // a description of the thing
string c = "Doom"; /* a spicy suffix - removed the 'of' :) */
string d = "3000"; /* just like Andre */
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

// Question - aside from comments how could you make this code clearer?

// Answer - make the variable names more descriptive! (use string interpolation, but we haven't covered that yet :) )