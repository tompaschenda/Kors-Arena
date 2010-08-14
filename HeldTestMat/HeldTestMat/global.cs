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
/// Kombination einer Namensliste und einem zugehörigen Wert pro Namensliste.
/// </summary>
public struct NamenslisteWertPaar
{
    /// <summary>
    /// Enthält eine Liste von STrings
    /// </summary>
    public List<string> namensListe;

    /// <summary>
    /// Enthält für jede Liste von Namen einen Wert
    /// </summary>
    public int wert;
}


/// <summary>
/// Struktur, in der sowohl ein Name als auch ein Subname angegeben werden können.
/// Beispiel: "Geländekunde" => "Höhlenkundig"
/// </summary>
public struct nameSubnamePaar
{
    /// <summary>
    /// Primärer Name
    /// </summary>
    public string name;
    /// <summary>
    /// Subname (der Spezialisierung, etc.)
    /// </summary>
    public string nameSubname;
}

/// <summary>
/// Struktur, die zwei Ints enthält, die Minimum und Maximum eines Intervals beschreiben.
/// </summary>
public struct minMaxPaar
{
    /// <summary>
    /// Minimaler Wert
    /// </summary>
    public int min;
    /// <summary>
    /// Maximaler Wert
    /// </summary>
    public int max;
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
    public T getValue(int result)
    {
        foreach (Range r in this.Keys)
        {
            if (r.contains(result))
            {
                return this[r];
            }
        }
        throw new System.ArgumentOutOfRangeException("result", result, "Für den übergebenen Wert ist kein Bereich in der Range Map vorhanden.");
    }
    /*
    public void Add(Range r, T value)
    {
        map.Add(r, value);
    }
     */
}