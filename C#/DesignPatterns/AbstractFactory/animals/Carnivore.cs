namespace AbstractFactory.animals
{
    public abstract class Carnivore : IAnimal
    {
        public abstract string CarnivoreType();
        public string Food => "Meat";
    }
}