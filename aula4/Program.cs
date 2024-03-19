//Instanciar uma universidade

Universidade objUniversidade = new Universidade();

objUniversidade.nome = "UP";


Console.WriteLine(objUniversidade.nome);

Curso objCurso = new Curso();

//criar curso ADS e adicionar na universidade
objCurso = new Curso();
objCurso.nome = "ADS";
objUniversidade.adicionarCurso(objCurso);

//criar curso ADS e adicionar na universidade
objCurso = new Curso();
objCurso.nome = "BSI";
objUniversidade.adicionarCurso(objCurso);

foreach(var curso in objUniversidade.cursos){
    Console.WriteLine(curso.nome);
}