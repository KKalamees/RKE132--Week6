string hello = "Hello, world ";

int stringLength = hello.Length;
string trimmedString = hello.Trim();

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));


int wordCounter = 0;

for (int i = 0; i < hello.Length; i++)
{ 
    if(char.IsWhiteSpace(hello[ i]) )
    { 
        wordCounter++;
    }

}

Console.WriteLine($"Word count is {hello}: {wordCounter} words.");
