namespace criando_um_sistema_e_abstraindo_um_celular_com_POO_em_C_.Códigocomentado
{
    // A classe "Iphone" também herda da classe "Smartphone".
    public class Iphone : Smartphone
    {
        // O construtor do iPhone. Assim como o Nokia, ele chama o construtor da classe base.
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevemos o método "InstalarAplicativo" para ter um comportamento único do iPhone.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo '{nomeApp}' na App Store do iPhone.");
        }
    }
}