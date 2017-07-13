using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;


namespace Pokemon01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon item = new Pokemon()
            {
                name = "妙蛙種子",
                hp = 60,
                kg = 5.94,
                gender = "男",
                type = "草/毒",
                height = 67,
                skill01 = "藤編",
                skill02 = "汙泥炸彈",
                skill01damage = 7,
                skill02damage = 80,
                Candy = 27,
                Star = 271484,
                Strong = 3000,
                EVO = 25
            };
            Console.WriteLine("名稱:{0},血量{1},體重:{2},性別:{3},屬性:{4},身高:{5},技能1:{6},技能2:{7},藤鞭傷害:{8},汙泥炸彈:{9}"
                , item.name, item.hp, item.kg, item.gender, item.type, item.height, item.skill01, item.skill02
                ,item.skill01damage,item.skill02damage
                );

            Console.WriteLine("==========================================================================");
            Console.WriteLine("糖果:{0},星星:{1},強化需求:{2},進化需求:{3}", item.Candy, item.Star, item.Strong, item.EVO);
        }
    }
}
