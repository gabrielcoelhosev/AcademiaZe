<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using AcademiaDoZe.Application.Enums;
=======
﻿using AcademiaDoZe.Application.Enums;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65

namespace AcademiaDoZe.Application.DTOs;

public class MatriculaDTO
{
    public int Id { get; set; }
    public required AlunoDTO AlunoMatricula { get; set; }
    public required EAppMatriculaPlano Plano { get; set; }
    public required DateOnly DataInicio { get; set; }
    public required DateOnly DataFim { get; set; }
    public required string Objetivo { get; set; }
    public required EAppMatriculaRestricoes RestricoesMedicas { get; set; }
    public string? ObservacoesRestricoes { get; set; }
    public ArquivoDTO? LaudoMedico { get; set; }
}
//Gabriel Coelho Severino