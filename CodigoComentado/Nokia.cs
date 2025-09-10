namespace criando_um_sistema_e_abstraindo_um_celular_com_POO_em_C_.Códigocomentado
{
    // A classe "Nokia" herda da classe "Smartphone" usando a sintaxe ": Smartphone".
    // Isso significa que ela "ganha" todas as propriedades e métodos da classe pai.
    public class Nokia : Smartphone
    {
        // O construtor da classe Nokia.
        // Ele chama o construtor da classe base (Smartphone) usando 'base(...)'.
        // Isso garante que as propriedades herdadas sejam inicializadas.
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // O método "InstalarAplicativo" é sobrescrito usando 'override'.
        // Isso nos permite fornecer uma implementação específica para o Nokia,
        // que é diferente da implementação do iPhone.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' na Loja de Aplicativos da Nokia.");
        }
    }
}
