namespace Servico.ViewModels.Mesa
{
    public class MesaEditarViewModel : MesaViewModel
    {
        public int Id { get; set; }

        public IList<MesaViewModel> Mesas { get; set; } = new List<MesaViewModel>();
    }
}
