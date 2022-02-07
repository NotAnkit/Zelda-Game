namespace Zelda_Game.LinkState
{
    public interface ILinkState
    {
        void ChangeDirection(string direction);
        void ChangeWeapon();
        void UseItem();
        void ThrowItem();
        void Update();
    }
}
