using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateEnderecoDto
    {
        [Required(ErrorMessage = "O logradouro é obrigatorio")]
        public string Logradouro { get; set; }
        public int Numero { get; set; }
    }
}
