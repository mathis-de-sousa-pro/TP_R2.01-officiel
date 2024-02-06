namespace TP._03_exo_2;

/// <summary>
/// Represents a time
/// </summary>
public class Time
{
    private int _seconds;

    #region constructeur

    /// <summary>
    /// Init the time with a number of seconds
    /// </summary>
    /// <param name="s">a nbr of seconds</param>
    public Time(int s) => _seconds = s;

    /// <summary>
    /// Init the time
    /// </summary>
    /// <param name="h">number of hours</param>
    /// <param name="m">number of minutes</param>
    /// <param name="s">number of seconds</param>
    public Time(int h, int m, int s) => _seconds = s + m*60 + h*3600;
    
    #endregion
    public override string ToString() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
    public int Hours => _seconds / 3600; 
    public int Minutes => (_seconds - Hours*3600) / 60; 
    public int Seconds => Math.Abs(_seconds - (_seconds - Hours*3600) - (_seconds - Minutes*60)); 
    
    /// <summary>
    /// Add some seconds
    /// </summary>
    /// <param name="nbsecs">the number of seconds to add</param>
    public void Add(int nbsecs) => _seconds += nbsecs;
    
}
