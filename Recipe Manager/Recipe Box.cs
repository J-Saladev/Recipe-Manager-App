using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Manager
{
    public partial class Recipe_Box : Control
    {
        public Recipe_Box(string name, int recipeid)
        {
            InitializeComponent($"{name}", recipeid);

            
        }

        public Recipe_Box(IContainer container)
        {
            container.Add((IComponent?)this);

            InitializeComponent("",0);
        }
    }
}
