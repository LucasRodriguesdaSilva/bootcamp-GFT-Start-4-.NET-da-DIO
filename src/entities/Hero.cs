namespace projeto01.src.entities
{
    public abstract class Hero
    {
        public Hero(){}
        public Hero(string name, int level, string heroType, int Hp, int Mp){
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public string name;
        public int level;
        public string heroType;
        public int Hp;
        public int Mp;

        public override string ToString(){
            return $"{this.name} {this.level} {this.heroType}";
        }

        public virtual string attack(){
            return $"{this.name} Atacou com a sua espada";
        }
    }
}