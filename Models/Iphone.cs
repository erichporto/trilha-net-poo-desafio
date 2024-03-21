namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) :
            base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"| Iphone | Instalando {nomeApp}: {i}%");
                Thread.Sleep(40);
            }
        }
    }
}