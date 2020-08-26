
﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template

{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            tea.PrepareRecipe();


            var teaWithHook = new TeaWithHook();
            var coffeWithHook = new CoffeeWithHook();
            teaWithHook.PrepareRecipe();
            coffeWithHook.PrepareRecipe();
        }
    }
}
