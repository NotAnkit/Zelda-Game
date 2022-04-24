
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class GameStateManager
    {
        private string gameState;
        private Game1 game;
        private RoomManager manager;
        private Link player;
        private InventoryDisplay hud;
        private ItemSelectionState itemSelectionState;
        private LoseScreen loseScreen;
        private WinScreen winScreen;

        public string State
        {
            get { return gameState; }
            set { gameState = value; }
        }

        public GameStateManager(Game1 game, RoomManager manager, Link player, InventoryDisplay hud, ItemSelectionState pauseMenu)
        {
            gameState = "running";
            this.game = game;
            this.manager = manager;
            this.player = player;
            this.hud = hud;
            itemSelectionState = pauseMenu;
            loseScreen = new LoseScreen(game);
            winScreen = new WinScreen(game);

        }

        public void Draw(SpriteBatch _spriteBatch)
        {
            if(gameState.Equals("running"))
            {
                manager.Draw(_spriteBatch);
                player.Draw(_spriteBatch);
                hud.Draw(_spriteBatch);
                if (manager.TransitionState)
                {
                    manager.TransitionDraw(_spriteBatch);
                }
            }
            else if (gameState.Equals("paused"))
            {
                manager.Draw(_spriteBatch);
                if (manager.TransitionState)
                {
                    manager.TransitionDraw(_spriteBatch);

                }
                if (manager.TransitionStateFinished)
                {
                    itemSelectionState.Draw(_spriteBatch, player);
                }
            }
            else if (gameState.Equals("win"))
            {
                winScreen.Draw(_spriteBatch);
            }
            else if (gameState.Equals("lose"))
            {
                loseScreen.Draw(_spriteBatch);
            }

        }

        public void Update()
        {
            if (gameState.Equals("running"))
            {
                player.Update();
                manager.Update();
                hud.Update(player);
                if (manager.TransitionState)
                {
                    manager.TransitionUpdate();
                }
            }
            else if (gameState.Equals("paused"))
            {
                if (manager.TransitionState && !manager.TransitionStateFinished)
                {
                    manager.TransitionUpdate();
                }
                itemSelectionState.Update();
            }
            if (player.inventory.TriForce)
            {
                gameState = "win";
            }
            if (player.inventory.NumLives() == 0)
            {
                gameState = "lose";
            }
        }
    }
}
