using System.Collections.Generic;
/// <summary>
/// Struktur eines Name-Werte-Paares:
/// </summary>
public struct NameWertPaar
{
    /// <summary>
    /// Name des Name-Werte-Paares
    /// </summary>
    public string name;
    /// <summary>
    /// Wert des Name-Werte-Paares
    /// </summary>
    public int wert;
    /// <summary>
    /// To String-Methode überstreiben für eine vernünftige Anzeige:
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return base.ToString();
    }
}

/// <summary>
/// Erlaubt die Angabe einer Range, also eines Intervalls zwischen zwei Zahlen.
/// </summary>
public struct Range
{
    /// <summary>
    /// Untere Grenze des Intervals (der Range)
    /// </summary>
    public int lower;
    /// <summary>
    /// Obere Grenze des Intervals (der Range)
    /// </summary>
    public int upper;

    /// <summary>
    /// Das Interval (die Range):
    /// </summary>
    /// <param name="p"></param>
    /// <param name="p_2"></param>
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