namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        private string Modelo;
        private string IMEI;
        private int Memoria;
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo: " + nomeApp);
        }
    }
}