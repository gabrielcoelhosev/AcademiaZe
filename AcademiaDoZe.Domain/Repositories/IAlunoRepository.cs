<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using AcademiaDoZe.Domain.Entities;
=======
﻿using AcademiaDoZe.Domain.Entities;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65

namespace AcademiaDoZe.Domain.Repositories;

public interface IAlunoRepository : IRepository<Aluno>
{
    // Métodos específicos do domínio
    Task<IEnumerable<Aluno>> ObterPorCpf(string cpf);
    Task<bool> CpfJaExiste(string cpf, int? id = null);
    Task<bool> TrocarSenha(int id, string novaSenha);
}