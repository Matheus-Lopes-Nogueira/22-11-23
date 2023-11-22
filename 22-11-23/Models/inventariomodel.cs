namespace _22_11_23.Models
{
    public class inventariomodel
    {
        public int idinventario { get; set; }
        public int idcliente { get; set; }
        public int idmaquina { get; set; }
        public int qtvalor { get; set; }

        public List<cadclientes> listaclientes { get; set; }

        public List<cadmaquinas> listamaquina { get; set; }
    }
}
