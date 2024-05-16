string data = Console.ReadLine();
string[] dataArr = data.Split(", ");
string title = dataArr[0];
string content = dataArr[1];
string author = dataArr[2];

Article article = new Article(title, content, author);

int numberOfCommands = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfCommands; i++)
{
    string inputCommand = Console.ReadLine();
    string[] commandsArr = inputCommand.Split(": ");
    string commandName = commandsArr[0];
    string commandParameter = commandsArr[1];

    switch (commandName)
    {
        case "Edit":
            article.Edit(commandParameter);
            break;
        case "ChangeAuthor":
            article.ChangeAuthor(commandParameter);
            break;
        case "Rename":
            article.Rename(commandParameter);
            break;
    }
}

Console.WriteLine(article);
