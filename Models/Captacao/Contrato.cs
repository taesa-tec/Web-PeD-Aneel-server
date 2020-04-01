using TaesaCore.Models;

namespace APIGestor.Models.Captacao
{
    public class Contrato : BaseEntity
    {
        public enum TipoContrato
        {
            Executor,
            CoExecutor
        }

        public enum Status
        {
            Pendente,
            Rascunho,
            Finalizado
        }

        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public TipoContrato Tipo { get; set; }
    }
}