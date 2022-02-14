namespace projeto01.src.entities
{
    public class BWizzard : Hero
    {
        public BWizzard(string name, int level, string heroType, int Hp, int Mp){
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public int Life(){
            return 469;
        }

        public int Magic(){
            return 72;
        }
    }
}