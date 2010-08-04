using System.Collections.Generic;
/// <summary>
/// Unser tolles struct.
/// </summary>
public struct NameWertPaar
{
    public string name;
    public int wert;
    public override string ToString()
    {
        return base.ToString();
    }
    public List<List<int>> myMatrix;
    public void foo()
    {
        myMatrix[0][0] = 5;
    }
}

public struct Range
{
    public int lower;
    public int upper;

    public Range(int p, int p_2)
    {
        this.lower = p;
        this.upper = p_2;
    }

    internal bool contains(int value)
    {
        if (lower <= value && value <= upper)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class RangeMap<T> : Dictionary<Range, T>
{
    private Dictionary<Range, T> map;
    public T getValue(int result)
    {
        foreach (Range r in map.Keys)
        {
            if (r.contains(result))
            {
                return map[r];
            }
        }
        throw new System.ArgumentOutOfRangeException();
    }
    /*
    public void Add(Range r, T value)
    {
        map.Add(r, value);
    }
     */
}