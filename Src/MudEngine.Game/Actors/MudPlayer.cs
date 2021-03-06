﻿using System.Threading.Tasks;
using MudDesigner.MudEngine.Actors;
using MudDesigner.MudEngine.Commanding;

namespace MudEngine.Game.Actors
{
    public class MudPlayer : MudCharacter, IPlayer
    {
        public MudPlayer(IActorCommand initialCommand)
        {
            this.InitialCommand = initialCommand;
        }

        public IActorCommand InitialCommand { get; private set; }

        protected override Task Load()
        {
            return Task.FromResult(0);
        }

        protected override Task Unload()
        {
            return Task.FromResult(0);
        }
    }
}
