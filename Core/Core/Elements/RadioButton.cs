﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Elements
{
    public interface RadioButton : Element
    {
        void Click();

        bool IsSelect();
    }
}
