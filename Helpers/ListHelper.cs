namespace SearchNavigator.Helpers
{
    public class ListHelper
    {
        public static List<T> GetRandomPartOfElements<T>(List<T> BasicList, int ElementsQuantity) 
        {
            List<T> RandomElementsPart = new List<T>();
            Random rnd = new Random();

            for (int i = 0; i < ElementsQuantity; i++) {
                int NewRandomIndex = rnd.Next(BasicList.Count);
                RandomElementsPart.Add(BasicList.ElementAt(NewRandomIndex));
                BasicList.RemoveAt(NewRandomIndex);
            }

            return RandomElementsPart;
        }
    }
}
