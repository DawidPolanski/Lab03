Console.ForegroundColor = ConsoleColor.Green;
while(true)
{
    Console.Write("Enter string to encode base64: ");
    string stringinput = Console.ReadLine();
    string encodeString = Base64Encode(stringinput);
    Console.Write("Your input {0} encode to base64 {1}", stringinput, encodeString);
    Console.ReadKey();
    Console.Clear();
}

string Base64Encode(string text)
{
    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(text);
    return System.Convert.ToBase64String(plainTextBytes);
}