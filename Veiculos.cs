public class Veiculo
{
    private string _marca;
    private string _placa;

    public string Marca
    {
        get
        {
            return _marca;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A marca do veículo não pode ficar vazio."
                );
            }

            _marca = value.Trim();
        }
    }

    public string Placa
    {
        get
        {
            return _placa;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "A placa do veículo não pode ficar vazio."
                );
            }
            _placa = value.Trim();
        }
    }

    public Veiculo(string marca, string placa)
    {
        Marca = marca;
        Placa = placa;
    }
    public void ExibirDados()
    {
        Console.WriteLine($"Veículo: {Marca}");
        Console.WriteLine($"Placa: {Placa}");
    }
}