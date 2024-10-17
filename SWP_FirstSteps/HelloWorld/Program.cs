Console.WriteLine("Schreiben Sie den Text bei dem Sie a, e, i, o und u zählen wollen");
string inputText = Console.ReadLine();

Console.WriteLine(countVocals(inputText));
string countVocals(string inputText)
{
    string inputLower = inputText.ToLower();
    int countA = 0;
    int countE = 0;
    int countI = 0;
    int countO = 0;
    int countU = 0;
    int insgesamt = 0;
    for (int i = 0; i < inputText.Length; i++)
    {
        char currentLetter = inputLower[i];

        if (currentLetter == 'a')
        {
            countA++;
        }
        else if (currentLetter == 'e')
        {
            countE++; ;
        }
        else if (currentLetter == 'i')
        {
            countI++;
        }
        else if (currentLetter == 'o')
        {
            countO++;
        }
        else if (currentLetter == 'u')
        {
            countU++;
        }        
    }
    string message = $"Es gibt verschiedene Umlaute in diesem Wort:\nA: {countA}\nE: {countE}\nI: {countI}\nO: {countO} \nU: {countU}";
    return message;
}

