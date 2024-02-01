namespace TP._02;

public class Printer
{
    private double _cost;
    private int _nbsheets;
    private double _totalPrice;

    #region constructeur
    public Printer(double prix, int nombrePages, double prixTotal)
    {
        _totalPrice = prixTotal;
        _nbsheets = nombrePages;
        _cost = prix;
    }
    #endregion

    #region accesseur
    public double Cost
    {
        get => _cost;
        set => _cost = value;
    }

    public int Nbsheets
    {
        get => _nbsheets;
        set => _nbsheets = value;
    }

    public double TotalPrice
    {
        get => _totalPrice;
        set => _totalPrice = value;
    }
    #endregion

    public void TakeMoney()
    {
        this.Cost = 0.0;
    }

    public void LoadSheets(int number)
    {
        this.Nbsheets += number;
    }

    public void Print(int nb)
    {
        
            var final = Nbsheets - nb;
            var compteur = 0;
            while ((Nbsheets != final) & (Nbsheets != 0))
            {
                this.Nbsheets--;
                compteur++;

                if (compteur <= 10)
                {
                    this.Cost = 0.25;
                }
                else
                {
                    if (compteur <= 30)
                    {
                        this.Cost = 0.20;
                    }
                }

                this.Cost = 0.10;
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