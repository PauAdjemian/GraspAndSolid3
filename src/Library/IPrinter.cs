namespace Full_GRASP_And_SOLID.Library;

public interface IPrinter 
{
    void PrintTicket(Recipe Recipe);
}
/*
Se crea la interface IPrinter que va a ser implementada en este momento por: ConsolePrinter y FilePrinter.
Cumplimos con SRP ya que cada clase tiene una sola responsabilidad y Expert porque conoce lo suficiente.
Cumplimos con el patrón de Polimorfismo porque eliminamos la pregunta por el destino.
Si el día de mañana queres imprimir de otra forma, no es necesario tocar el resto de las clases.  
*/