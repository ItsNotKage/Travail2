using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail2
{
     public class PlayerInput
    {
        private bool MoveRight;
        private bool MoveLeft;

        public PlayerInput()
        {
            MoveRight = false;
            MoveLeft = false;
        }

        public bool GetMoveRight()
        {
            return MoveRight;
        }

        public void SetMoveRight(bool moveRight)
        {
            MoveRight = moveRight;
        }

        public bool GetMoveLeft()
        {
            return MoveLeft;
        }

        public void SetMoveLeft(bool moveLeft)
        {
            MoveLeft = moveLeft;
        }
    }

}
