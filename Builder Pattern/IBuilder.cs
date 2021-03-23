namespace Builder_Pattern
{
    public interface IBuilder
    {
        void StartUpOperations();
         void BuildBody();
         void InsertWheels();
         void AddHeadlights();
         void  EndOperations();
         Product GetVehicle();
    }
}