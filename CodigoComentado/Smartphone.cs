namespace criando_um_sistema_e_abstraindo_um_celular_com_POO_em_C_.Códigocomentado
{
    // A classe "Smartphone" é definida como 'abstract'.
    // Isso significa que ela não pode ser instanciada diretamente.
    // Ela serve apenas como um modelo (blueprint) para outras classes.
    public abstract class Smartphone
    {
        // Propriedades (atributos) do Smartphone.
        // São comuns a todos os celulares (Nokia, iPhone, etc.).
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // O construtor é o método que inicializa o objeto.
        // Ele recebe os valores e os atribui às propriedades do Smartphone.
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos comuns a todos os smartphones.
        // Eles são implementados aqui para evitar repetição de código nas classes filhas.
        public void Ligar(string numeroLigado)
        {
            Console.WriteLine($"Ligando para {numeroLigado}...");
        }

        public void ReceberLigacao(string numeroChamador)
        {
            Console.WriteLine($"Recebendo ligação de {numeroChamador}...");
        }

        // Este método é definido como 'abstract'.
        // Isso significa que ele não tem uma implementação aqui.
        // As classes que herdarem de 'Smartphone' (como Nokia e iPhone)
        // serão OBRIGADAS a implementar este método,
        // mas cada uma a sua maneira (conceito de Polimorfismo).
        public abstract void InstalarAplicativo(string nomeApp);
    }
}