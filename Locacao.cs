public class Locacao
{
    private Cliente _cliente;
    private Veiculo _veiculo;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;


    public Cliente Cliente
    {
        get
        {
            return _cliente;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "O cliente não pode ser nulo."
                );
            }
            _cliente = value;
        }
    }


    public Veiculo Veiculo
    {
        get
        {
            return _veiculo;
        }
        set
        {
            if (value == null)
            {
                throw new ArgumentException(
                    "O veículo não pode ser nulo."
                );
            }
            _veiculo = value;
        }
    }

    public DateOnly DataRetirada
    {
        get
        {
            return _dataRetirada;
        }
        set
        {
            _dataRetirada = value;
        }
    }

    public int QuantidadeDias
    {
        get
        {
            return _quantidadeDias;
        }
        set
        {
            _quantidadeDias = value;
        }
    }

    public decimal ValorDiaria
    {
        get
        {
            return _valorDiaria;
        }
        set
        {
            _valorDiaria = value;
        }
    }

    public Locacao(Cliente cliente, Veiculo veiculo, DateOnly dataRetirada, int quantidadeDias, decimal valorDiaria)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        QuantidadeDias = quantidadeDias;
        ValorDiaria = valorDiaria;
    }

    public decimal CalcularValorBruto()
    {
        decimal valorBruto = QuantidadeDias * ValorDiaria;
        return valorBruto;
    }

    public decimal CalcularDesconto()
    {
        if (QuantidadeDias >= 7)
        {
            decimal valorBruto = CalcularValorBruto();
            return valorBruto * 0.10m;
        }
        return 0;
    }

    public decimal ValorFinal()
    {
        decimal valorFinal = CalcularValorBruto() - CalcularDesconto();
        return valorFinal;
    }

    public void ExibirResumo()
    {
        Console.WriteLine("Dados da Locação");
        Console.WriteLine($"Data de Retirada: {DataRetirada}");
        Console.WriteLine($"Quantidade de Dias: {QuantidadeDias}");
        Console.WriteLine($"Valor da Diária: {ValorDiaria:C}");
        Console.WriteLine($"Valor Bruto: {CalcularValorBruto():C}");
        Console.WriteLine($"Desconto: {CalcularDesconto():C}");
        Console.WriteLine($"Valor Final: {ValorFinal():C}");

    }






















}