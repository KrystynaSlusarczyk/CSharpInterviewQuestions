namespace CSharpInterviewQuestions
{
    interface IVehicle
    {
        void Move();
    }

    interface ICar : IVehicle
    {
    }

    interface IBoat : IVehicle
    {
    }

    interface IAmphibian: ICar, IBoat
    {
    }

    class Amphibian : IAmphibian
    {
        public void Move()
        {
        }
    }
}
