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

        public void PlaySword()
        {
            sword.Play();
        }

        public void PlayHurt()
        {
            hurt.Play();
        }

        public void PlayItem()
        {
            item.Play();
        }

        public void PlayBomb()
        {
            bomb.Play();
        }

        public void PlayArrow()
        {
            arrow.Play();
        }

        public void PlayFire()
        {
            fire.Play();
        }

        public void PlayBoomerang()
        {
            boomerang.Play();
        }

        public void PlayWin()
        {
            win.Play();
        }

        public void PlayLose()
        {
            lose.Play();
        }
    }
}
