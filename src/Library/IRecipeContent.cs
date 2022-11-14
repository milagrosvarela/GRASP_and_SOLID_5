
// Para aplicar el principio de inversión de dependencias, defino la abstracción de la que ConsolePrinter y Recipe dependen.
public interface IRecipeContent
{
    string GetTextToPrint();
}