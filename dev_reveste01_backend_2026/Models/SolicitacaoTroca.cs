using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_reveste01_backend_2026.Models
{
    [Table("SolicitacoesTroca")]

    public class SolicitacaoTroca

    {

        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o usuário!")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a peça!")]
        public int PecaId { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Tamanho é obrigatório.")]
        public string Tamanho { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o endereço!")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o número!")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cidade!")]
        public string Cidade { get; set; }

        public string EstadoEndereco { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o CEP!")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor da peça!")]
        public decimal ValorPeca { get; set; }

        public decimal Frete { get; set; }

        public decimal Comissao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor total!")]
        public decimal Total { get; set; }

        public string Status { get; set; }

    }

}











