<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using AcademiaDoZe.Domain.Entities;
=======
﻿using AcademiaDoZe.Domain.Entities;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65

namespace AcademiaDoZe.Domain.Repositories;

public interface IColaboradorRepository : IRepository<Colaborador>
{
    // Métodos específicos do domínio

    //Task<Colaborador?> ObterPorCpf(string cpf);

    // nova versão, retornando múltiplos colaboradores
    Task<IEnumerable<Colaborador>> ObterPorCpf(string cpf);
    Task<bool> CpfJaExiste(string cpf, int? id = null);
    Task<bool> TrocarSenha(int id, string novaSenha);

<<<<<<< HEAD
}
=======
}//Gabriel Coelho Severino
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
