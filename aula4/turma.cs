// ./turma.cs

public class Turma{
    public int anoFormacao{get;set;}
    public string turno{get;set;}
    public string sala{get;set;}
    
    public List<Estudante> estudantes = new List<Estudante>();
    //Metodo adicionar estudantes
    //Ele recebe um estudante e adiciona ele na lista estudantes
    public void AdicionarEstudante(Estudante e){
        this.estudantes.Add(e);
    } 
}