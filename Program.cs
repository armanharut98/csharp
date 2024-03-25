Arrow arrow = new Arrow(ArrowHead.Steel, Fletching.TurkeyFeathers, 70);

Console.WriteLine(arrow.GetCost());

enum ArrowHead
{
    Steel,
    Wood,
    Obsidian
};

enum Fletching
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
};

class Arrow
{
    public ArrowHead _head;
    public Fletching _fletching;
    public uint _length = 0;
    
    public Arrow(ArrowHead head, Fletching fletching, uint length)
    {
        _head = head;
        _fletching = fletching;
        if (length >= 60 && length <= 100)
        {
            _length = length;
        }
    }

    public double GetCost()
    {
        double cost = 0;

        if (_head == ArrowHead.Steel)
        {
            cost += 10;
        }
        else if (_head == ArrowHead.Wood)
        {
            cost += 3;
        }
        else
        {
            cost += 5;
        }

        if (_fletching == Fletching.Plastic)
        {
            cost += 10;
        }
        else if (_fletching == Fletching.TurkeyFeathers)
        {
            cost += 5;
        }
        else 
        {
            cost += 3;
        }

        cost += _length * 0.05;

        return cost;
    }
}
