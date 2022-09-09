namespace Servico.Helpers
{
    public static class ArquivoHelper
    {
        private const string PastaPai = "Uploads";
        private const string PastaImagens = "Produtos";

        public static string ObterCaminhoPastas() =>
            Path.Join(PastaPai, PastaImagens);

        public static string ObterCaminhoArquivo(string nomeArquivo) =>
            Path.Join(ObterCaminhoPastas(), nomeArquivo);

        public static string ObterCaminhoArquivoServico(string nomeArquivo, string caminhoServidor) =>
            Path.Join(caminhoServidor, ObterCaminhoPastas(), nomeArquivo);
    }
}
