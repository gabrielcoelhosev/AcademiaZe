<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using AcademiaDoZe.Application.Enums;
=======
﻿using AcademiaDoZe.Application.Enums;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
using AcademiaDoZe.Domain.Enums;

namespace AcademiaDoZe.Application.Mappings;

public static class MatriculaEnumMappings
{
    public static EMatriculaPlano ToDomain(this EAppMatriculaPlano appPlano)
    {
        return (EMatriculaPlano)appPlano;
    }
    public static EAppMatriculaPlano ToApp(this EMatriculaPlano domainPlano)
    {
        return (EAppMatriculaPlano)domainPlano;
    }
    public static EMatriculaRestricoes ToDomain(this EAppMatriculaRestricoes appRestricoes)
    {
        return (EMatriculaRestricoes)appRestricoes;
    }
    public static EAppMatriculaRestricoes ToApp(this EMatriculaRestricoes domainRestricoes)
    {
        return (EAppMatriculaRestricoes)domainRestricoes;
    }
}
//Gabriel Coelho Severino