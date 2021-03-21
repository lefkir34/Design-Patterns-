namespace Prototype_Pattern
{
    public class RegularEmployee:EmployeePrototype
    {
        

        public override RegularEmployee ShallowCopy(){
            return (RegularEmployee)this.MemberwiseClone();
        }


          public override RegularEmployee DeepCopy(){
              var tmpEmployee = (RegularEmployee) this.MemberwiseClone();

              tmpEmployee.Address = new Address {
                  City = "My city" ,
                  Street="My street",
                  Building ="My building"
              };


              return tmpEmployee ;
          }

      
    }
}