namespace Zoo;

public class Animal
{
    private string _name;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public Animal(string name)
    {
        this.Name = name;
    }
}
