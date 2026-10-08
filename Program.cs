Cliente cliente1 = new Cliente("Arthur Morgan", 12345678901);
Veiculo veiculo1 = new Veiculo("ford", "ABC-1234");
Locacao locacao1 = new Locacao(cliente1, veiculo1, new DateOnly(2023, 6, 1), 10, 100.00m);

// cliente1.ExibirDados();
// veiculo1.ExibirDados();
// locacao1.ExibirResumo();


Cliente cliente2 = new Cliente("Pedro Pestana", 46801988859);
Veiculo veiculo2 = new Veiculo("Mustang", "MSA-2123");
Locacao locacao2 = new Locacao(cliente2, veiculo2, new DateOnly(2026, 6, 26), 20, 850.00m);

// cliente2.ExibirDados();
// veiculo2.ExibirDados();
// locacao2.ExibirResumo();

Cliente cliente3 = new Cliente("Maysa Segati", 41834864259);
Veiculo veiculo3 = new Veiculo("Lamborghini", "PTP-2321");
Locacao locacao3 = new Locacao(cliente3, veiculo3, new DateOnly(2026, 5, 21), 20, 4500.00m);

// cliente3.ExibirDados();
// veiculo3.ExibirDados();
// locacao3.ExibirResumo();
