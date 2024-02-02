namespace TP._02;

public class Printer
{
    private float _cost;
    private int _nbsheets;
    private float _totalPrice;

    #region constructeur
    public Printer(float prix, int nombrePages, float prixTotal)
    {
        _totalPrice = prixTotal;
        _nbsheets = nombrePages;
        _cost = prix;
    }
    #endregion

    #region accesseur
    public float Cost
    {
        get => _cost;
        set => _cost = value;
    }

    public int Nbsheets
    {
        get => _nbsheets;
        set => _nbsheets = value;
    }

    public float TotalPrice
    {
        get => _totalPrice;
        set => _totalPrice = value;
    }
    #endregion

    public void TakeMoney()
    {
        this.TotalPrice = 0.0f;
    }

    public void LoadSheets(int number)
    {
        this.Nbsheets += number;
    }

    public void Print(int nb)
    {
        
            var final = Nbsheets - nb;
            if (final < 0) {final = 0;}
            var compteur = 0;
            while (Nbsheets != final)
            {
                this.Nbsheets--;
                compteur++;

                if (compteur <= 10)
                {
                    this.Cost = 0.25f;
                }
                else if (compteur <= 30)
                {
                    this.Cost = 0.20f;
                }
                
                else {this.Cost = 0.10f;}
                
                TotalPrice += Cost;
            }
    }

    public bool Isempty()
    {
        return this._nbsheets == 0;
    }

    public bool HaveEnoughSheets(int nb)
    {
        return this._nbsheets >= nb;
    }
}