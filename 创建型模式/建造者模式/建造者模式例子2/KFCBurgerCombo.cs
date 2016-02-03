using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式例子2
{
    class Customer
    {
        public void Construct(ComboBuilder builder)
        {
            builder.BuildHanburger();
            builder.BuildColo();
            builder.BuildSausage();
        }
    }
    abstract class ComboBuilder
    {
        public abstract void BuildHanburger();
        public abstract void BuildColo();
        public abstract void BuildSausage();
        public abstract KFCBurgerCombo GetCombo();
    }
    /// <summary>
    /// 汉堡套餐1
    /// </summary>
    class Combo1 : ComboBuilder
    {
        private KFCBurgerCombo combo = new KFCBurgerCombo();
        public override void BuildHanburger()
        {
            combo.Add("套餐1：汉堡");
        }

        public override void BuildColo()
        {
            combo.Add("套餐1：可乐");
        }

        public override void BuildSausage()
        {
            combo.Add("套餐1：香肠");
        }
        public override KFCBurgerCombo GetCombo()
        {
            return combo;
        }
    }
    class Combo2 : ComboBuilder
    {
        private KFCBurgerCombo combo = new KFCBurgerCombo();
        public override void BuildHanburger()
        {
            combo.Add("套餐2：汉堡");
        }

        public override void BuildColo()
        {
            combo.Add("套餐2：可乐");
        }

        public override void BuildSausage()
        {
            combo.Add("套餐2：香肠");
        }
        public override KFCBurgerCombo GetCombo()
        {
            return combo;
        }
    }

    class KFCBurgerCombo
    {
        //汉堡套餐=汉堡+可乐+香肠
        List<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("汉堡套餐内容如下：");
            foreach (var part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
