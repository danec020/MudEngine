﻿
namespace MudDesigner.MudEngine.Actors
{
    public interface ICharacter : IActor
    {
        ICharacterClass CharacterClass { get; }

        void AddMountPoint(IMountPoint mountPoint);

        IMountPoint[] GetMountPoints();

        IMountPoint FindMountPoint(string pointName);

        void AssignAbility(IStat ability);

        IStat[] GetAbilities();
    }
}
