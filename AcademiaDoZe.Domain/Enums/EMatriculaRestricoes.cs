<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using System.ComponentModel.DataAnnotations;
=======
﻿using System.ComponentModel.DataAnnotations;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65

namespace AcademiaDoZe.Domain.Enums;

[Flags]
public enum EMatriculaRestricoes
{
    [Display(Name = "Nenhuma Restrição")]
    None = 0,
    [Display(Name = "Diabetes")]
    Diabetes = 1,
    [Display(Name = "Pressão Alta")]
    PressaoAlta = 2,
    [Display(Name = "Labirintite")]
    Labirintite = 4,
    [Display(Name = "Alergias")]
    Alergias = 8,
    [Display(Name = "Problemas Respiratórios")]
    ProblemasRespiratorios = 16,
    [Display(Name = "Remédio Contínuo")]
    RemedioContinuo = 32
}//Gabriel Coelho Severino