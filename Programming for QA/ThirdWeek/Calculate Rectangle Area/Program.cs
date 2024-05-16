int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int area = RectangleArea(width, height);
Console.WriteLine(area);

static int RectangleArea(int width, int height)
{
    return width * height;
}
