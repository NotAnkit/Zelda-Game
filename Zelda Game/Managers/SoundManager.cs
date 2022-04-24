using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;

namespace Zelda_Game
{
    public class SoundManager
    {
        private SoundEffect sword;
        private SoundEffect hurt;
        private SoundEffect item;
        private SoundEffect bomb;
        private SoundEffect arrow;
        private SoundEffect fire;
        private SoundEffect boomerang;
        private SoundEffect win;
        private SoundEffect lose;

        public SoundManager()
        {

        }

        public void LoadSounds(ContentManager content)
        {
            sword = content.Load<SoundEffect>("sword");
            hurt = content.Load<SoundEffect>("Hurt");
            item = content.Load<SoundEffect>("PickUpItem");
            bomb = content.Load<SoundEffect>("BombEffect");
            arrow = content.Load<SoundEffect>("UseArrow");
            fire = content.Load<SoundEffect>("Fire");
            boomerang = content.Load<SoundEffect>("Boomerang");
            win = content.Load<SoundEffect>("WinSound");
            lose = content.Load<SoundEffect>("LoseSound");
        }

        public bool PlaySword
        {
            get => sword.Play();
        }

        public bool PlayHurt
        {
            get => hurt.Play();
        }

        public bool PlayItem
        {
            get => item.Play();
        }

        public bool PlayBomb
        {
            get => bomb.Play();
        }

        public bool PlayArrow
        {
            get => arrow.Play();
        }

        public bool PlayFire
        {
            get => fire.Play();
        }

        public bool PlayBoomerang
        {
            get => boomerang.Play();
        }

        public bool PlayWin
        {
            get => win.Play();
        }

        public bool PlayLose
        {
            get => lose.Play();
        }
    }
}
