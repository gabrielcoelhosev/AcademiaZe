<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using AcademiaDoZe.Application.Enums;
=======
﻿using AcademiaDoZe.Application.Enums;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
using AcademiaDoZe.Domain.Enums;

namespace AcademiaDoZe.Application.Mappings;

public static class ColaboradorEnumMappings
{
    public static EColaboradorTipo ToDomain(this EAppColaboradorTipo appTipo)
    {
        return (EColaboradorTipo)appTipo;
    }
    public static EAppColaboradorTipo ToApp(this EColaboradorTipo domainTipo)
    {
        return (EAppColaboradorTipo)domainTipo;
    }
    public static EColaboradorVinculo ToDomain(this EAppColaboradorVinculo appVinculo)
    {
        return (EColaboradorVinculo)appVinculo;
    }
    public static EAppColaboradorVinculo ToApp(this EColaboradorVinculo domainVinculo)
    {
        return (EAppColaboradorVinculo)domainVinculo;
    }
}
//Gabriel Coelho Severino