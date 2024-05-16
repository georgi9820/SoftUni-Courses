using System.Text;

string title = Console.ReadLine();
string content = Console.ReadLine();

StringBuilder html = new StringBuilder();
html.AppendLine("<h1>");
html.AppendLine(title);
html.AppendLine("</h1>");

html.AppendLine("<article>");
html.AppendLine(content);
html.AppendLine("</article>");

string input;
while ((input = Console.ReadLine()) != "end of comments")
{
    html.AppendLine("<div>");
    html.AppendLine(input);
    html.AppendLine("</div>");
}

Console.WriteLine(html);