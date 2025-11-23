<<<<<<< HEAD
﻿//Gabriel Coelho Severino
using AcademiaDoZe.Domain.Exceptions;
=======
﻿using AcademiaDoZe.Domain.Exceptions;
>>>>>>> df0a73ee51b361b095f201897a83dfe9089cce65
using AcademiaDoZe.Domain.Services;

namespace AcademiaDoZe.Domain.ValueObjects;

public record Arquivo
{
    public byte[] Conteudo { get; }
    private Arquivo(byte[] conteudo)
    {
        Conteudo = conteudo;
    }
    public static Arquivo Criar(byte[] conteudo)
    {
        if (conteudo == null || conteudo.Length == 0)
            throw new DomainException("ARQUIVO_VAZIO");
        const int tamanhoMaximoBytes = 5 * 1024 * 1024; // 5MB
        if (conteudo.Length > tamanhoMaximoBytes)
            throw new DomainException("ARQUIVO_TIPO_TAMANHO");
        // cria e retorna o objeto

        return new Arquivo(conteudo);

    }
}