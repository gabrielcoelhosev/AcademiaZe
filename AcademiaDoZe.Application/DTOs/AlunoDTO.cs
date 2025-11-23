<<<<<<< HEAD
﻿//Gabriel Coelho Severino


namespace AcademiaDoZe.Application.DTOs;
=======
﻿namespace AcademiaDoZe.Application.DTOs;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65

public class AlunoDTO
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Cpf { get; set; }
    public required DateOnly DataNascimento { get; set; }
    public required string Telefone { get; set; }
    public string? Email { get; set; }
    public required LogradouroDTO Endereco { get; set; }
    public required string Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Senha { get; set; }
    public ArquivoDTO? Foto { get; set; }
}
//Gabriel Coelho Severino