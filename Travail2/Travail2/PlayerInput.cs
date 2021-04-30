using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail2
{
     public class PlayerInput
    {
        private bool MoveUp;
        private bool MoveDown;

        public PlayerInput()
        {
            MoveUp = false;
            MoveDown = false;
        }

        public bool GetMoveUp()
        {
            return MoveUp;
        }

        public void SetMoveUp(bool moveUp)
        {
            MoveUp = moveUp;
        }

        public bool GetMoveDown()
        {
            return MoveDown;
        }

        public void SetMoveDown(bool moveDown)
        {
            MoveDown = moveDown;
        }
    }

}
