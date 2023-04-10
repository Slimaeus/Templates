using Clean.Domain.Enums;

namespace Clean.Domain.Entities
{
    public class ExampleEntity
    {
        public string Name { get; set; }
        public ExampleEnum ExampleEnum { get; set; } = ExampleEnum.One;
    }
}
