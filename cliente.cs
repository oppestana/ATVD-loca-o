public class Cliente
{
    private string _nome;
    private double _CPF;

    public string Nome
    {
        get
        {
            return _nome;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O nome do cliente não pode ficar vazio."
                );
            }
            _nome = value.Trim();
        }
    }


    public double CPF
    {
        get
        {
            return _CPF;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    "O CPF não pode ser zero ou negativo."
                );
            }
            _CPF = value;
        }
    }

    public Cliente(string nome, double cpf)
    {
        Nome = nome;
        CPF = cpf;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine($"CPF: {CPF}");
    }
}

