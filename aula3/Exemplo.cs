/*

// Instanciar um objeto aluno do tipo Estudante
Estudante aluno = new Estudante("R1223", "A que não sei o que");

//Criar outro objeto aluno
Estudante aluno2 = new Estudante("R312", "A blablable");

Console.WriteLine(aluno.Rgm + " | " + aluno.Nome);

Console.WriteLine(aluno2.Rgm + " | " + aluno2.Nome); */

//Implementação de listas de objetos
class Exemplo{
    static void Main(){
        List<Estudante> estudantes = new List<Estudante>();
        //Construir 3 estudantes e adicionar na lista "estudante"
        Estudante aluno; //Instanciar o objeto aluno
        for(int i = 0; i<3 ; i++)
        {
            aluno = new Estudante("R"+i, "Nome"+i); //Construimdo o objeto aluno aluno
            estudantes.Add(aluno); //adicionei 3 novos alunos na lista estudantes
            //Console.WriteLine(aluno.Rgm + "|" + aluno.Nome);
        }

        //Imprimir os dados que estão dentro da lista estudantes
        Console.WriteLine("Depois de adicionar os alunos na lista");
        Console.WriteLine("Iniciando a impressao dos dados dos alunos na lista estudantes");
        foreach(var estudante in estudantes)
        {
            Console.WriteLine(estudante.Rgm + "|" + estudante.Nome);
        }
    }
}
