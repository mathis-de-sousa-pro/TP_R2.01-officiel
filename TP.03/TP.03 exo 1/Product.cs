namespace TP._03_exo_1;

/// <summary>
/// A simple product
/// </summary>
public class Product
{

	private static float _vAt;
	private string _code;
	private string _name;
	private float _prixTTC;

	public string Name
	{
		get => _name;
		set => _name = value;
	}

	public float PrixHt
	{
		get => _prixTTC / (1 + _vAt);
		set => _prixTTC = value + value * _vAt;
	}

	public float PrixTTC
	{
		get => _prixTTC;
		set => _prixTTC = value;
	}

	public static float Vat
	{
		get => _vAt;
		set => _vAt = value;

	}

	public string Code
	{
		get => _code;
		set => _code = value;
	}

	/// <summary>
	/// Init the product
	/// </summary>
	/// <param name="code">the unique code of the product</param>
	/// <param name="name">the name of the product</param>
	/// <param name="price">The price (include tax) of the product</param>
	public Product(string code, string name, float price)
	{
		_code = code;
		_name = name;
		_prixTTC = price;
	}

}
