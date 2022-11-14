using System;

namespace Full_GRASP_And_SOLID
{

    // Cambio la firma del método PrintRecipe para que reciba un objeto de tipo IRecipeContent en lugar de un tipo de la clase Recipe.
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(IRecipeContent recipeContent)
        {
            Console.WriteLine(recipeContent.GetTextToPrint());
        }
    }
}