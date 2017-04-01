using System.Collections.Generic;
using System.Windows.Forms;

namespace GameJam
{
    class Game
    {
        private Timer timer = new Timer();
        private readonly GameForm gameForm;
        private readonly Queue<Level> levels = LevelGenerator.GetLevels();
        private Level currentLevel;

        public Game(GameForm form)
        {
            gameForm = form;
            timer.Tick += GameTick;
            SwitchToNextLevel();
            //TODO
        }

        public void SwitchToNextLevel()
        {
            currentLevel = levels.Dequeue();
            //TODO
        }

        public void Start()
        {
            //TODO
            timer.Interval = 1;
            timer.Enabled = true;
        }

        private void GameTick(object sender, System.EventArgs e)
        {
            currentLevel.Physics.Move(currentLevel.Units);
            gameForm.DrawTo(currentLevel);
            currentLevel.Physics.Kill();
            gameForm.DrawTo(currentLevel);
        }
    }
}
