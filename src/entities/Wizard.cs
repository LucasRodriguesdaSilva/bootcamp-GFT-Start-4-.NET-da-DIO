namespace projeto01.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType, int Hp, int Mp){
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public override string attack(){
            return $"{this.name} Lançou magia";
        }

        public string attack(int bonus){
            if(bonus > 6){
                return $"{this.name} Lançou magia super efetiva com bonus de {bonus}";
            }else{
                return $"{this.name} Lançou magia com força fraca com bonus de {bonus}";
            }
        }
        public int Life(){
            return 469;
        }

        public int Magic(){
            return 72;
        }

    }
}