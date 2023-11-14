namespace AbstractFactory.animals
{
    public abstract class Herbivore : IAnimal
    {
        public abstract string HerbivoreType();
        public string Food => "Plants";
    }
}