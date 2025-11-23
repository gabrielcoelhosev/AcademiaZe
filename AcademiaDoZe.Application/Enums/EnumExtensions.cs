<<<<<<< HEAD
﻿//Gabriel Coelho Severino
=======
﻿
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace AcademiaDoZe.Application.Enums;

public static class EnumExtensions
{
    public static string GetDisplayName(this Enum value)
    {
        var field = value.GetType().GetField(value.ToString());

        var attribute = field?.GetCustomAttribute<DisplayAttribute>();
        return attribute?.Name ?? value.ToString();

    }
}
// Console.WriteLine( EMatriculaRestricoes.ProblemasRespiratorios.GetDisplayName() );
// Exibe: Problemas Respiratórios
//Gabriel Coelho Severino