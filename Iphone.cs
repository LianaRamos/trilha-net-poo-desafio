namespace DesafioPOO.Models
{
    public class IPhone : Smartphone
    {
        public IPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na Apple Store.");
        }
    }
}