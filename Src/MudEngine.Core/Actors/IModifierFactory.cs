﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudDesigner.MudEngine.Actors
{
    public interface IModifierFactory
    {
        IModifier CreateModifier(IActor target, IActor source, int amount);

        IModifier CreateModifier(IActor target, IActor source, int amount, int duration);

        IModifier CreateModifier(IActor target, IActor source, IStat stat, int amount);

        IModifier CreateModifier(IActor target, IActor source, IStat stat, int amount, int duration);
    }
}
