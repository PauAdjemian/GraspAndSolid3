namespace Full_GRASP_And_SOLID.Library;

public interface IPrinter 
{
    void PrintTicket(Recipe Recipe);
}
/*
Se crea la interface IPrinter que va a ser implementada en este momento por: ConsolePrinter y FilePrinter.
Cumplimos con SRP ya que cada clase tiene una sola responsabilidad y Expert porque conoce lo suficiente.
Cumplimos con el patrón de Polimorfismo porque eliminamos la pregunta por el destino.
*/