namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : 
            base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"| Nokia | Instalando {nomeApp}: {i}%");
                Thread.Sleep(40);
            }
        }
    }
}