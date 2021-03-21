namespace Prototype_Pattern
{
    public abstract class EmployeePrototype
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public int age { get; set; }

        public abstract EmployeePrototype ShallowCopy();
        public abstract EmployeePrototype DeepCopy();


          public override string ToString()
        {
            return $@"Id:{this.Id}
                    Name : {this.Name} 
                    Age :{this.age}
                    City :{this.Address.City}
                    Street:{this.Address.Street}
                    Building:{this.Address.Building}" ;
        }
        
    }
}