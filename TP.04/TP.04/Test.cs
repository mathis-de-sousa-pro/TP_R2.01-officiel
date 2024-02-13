namespace TP._04;

public class Test
{
    
    private static int _compteur;
    private int _val;

    public int Val
    {
        get => _val;
        set => _val = value;
    }
    
    public Test()
    {
        ++_compteur;
        Val = 0;
    }

    public Test(Test elem)
    {
        ++_compteur;
        Val = elem.Val;
    }
    
    ~Test()
    {
        --_compteur;
    }

    public static int Combien()
    {
        return _compteur; 
    }
    
    #region equals

    protected bool Equals(Test other)
    {
        return _val == other._val;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Test)obj);
    }

    public override int GetHashCode()
    {
        return _val;
    }

    public static bool operator ==(Test? left, Test? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Test? left, Test? right)
    {
        return !Equals(left, right);
    }

    #endregion

}