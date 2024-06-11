namespace OpticsSetsMy.Models
{
    public class Soczewka
    {
        public string Name { get; set; }
    }

    public class Oprawka
    {
        public string Name { get; set; }
    }

    public class KompletOptics
    {
        public string Name { get; set; }
        public Soczewka SoczewkaLewa { get; set; }
        public Soczewka SoczewkaPrawa { get; set; }
        public Oprawka Oprawa { get; set; }
    }
}
