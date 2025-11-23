<<<<<<< HEAD
﻿//Gabriel Coelho Severino
=======
﻿
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
using AcademiaDoZe.Application.DTOs;
namespace AcademiaDoZe.Application.Interfaces;

public interface IAlunoService
{
    Task<AlunoDTO> ObterPorIdAsync(int id);
    Task<IEnumerable<AlunoDTO>> ObterTodosAsync();
    Task<AlunoDTO> AdicionarAsync(AlunoDTO alunoDto);
    Task<AlunoDTO> AtualizarAsync(AlunoDTO alunoDto);
    Task<bool> RemoverAsync(int id);
    Task<IEnumerable<AlunoDTO>> ObterPorCpfAsync(string cpf);
    Task<bool> CpfJaExisteAsync(string cpf, int? id = null);
    Task<bool> TrocarSenhaAsync(int id, string novaSenha);
}
//Gabriel Coelho Severino