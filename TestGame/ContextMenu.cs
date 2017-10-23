using Unbroken.LaunchBox.Plugins;
using Unbroken.LaunchBox.Plugins.Data;

namespace TestGame
{
    public class ContextMenu : IGameMenuItemPlugin
    {
        public bool SupportsMultipleGames => false;

        public string Caption => "Test Game";

        public System.Drawing.Image IconImage => null;

        public bool ShowInLaunchBox => true;

        public bool ShowInBigBox => false;

        public bool GetIsValidForGame(IGame selectedGame)
        {
            return true;
        }

        public bool GetIsValidForGames(IGame[] selectedGames)
        {
            return false;
        }

        public void OnSelected(IGame selectedGame)
        {
            selectedGame.Play();
        }

        public void OnSelected(IGame[] selectedGames)
        {
            throw new System.NotImplementedException();
        }
    }
}
