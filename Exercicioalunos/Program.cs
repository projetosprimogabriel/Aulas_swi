﻿namespace Exercicioalunos;
class Program
{
    static void Main(string[] args)
    {
        alunos aluno1 = new alunos();
        aluno1.nome = "fulano da silva";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 7.8;

        aluno1.mensagem();
    }
}
