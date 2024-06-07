namespace ApiProva.DTO
{
    public class EntregaDTO
    {
        public string EnderecoDestinatario { get; set; }
        public string EnderecoRemetente { get; set; }
        public double Distancia { get; set; } // Adicionando propriedade para armazenar a distância em quilômetros
        public string Status { get; set; }
    }
}
