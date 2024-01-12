using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nea_project
{
    public class Camera
    {
        private Vector2 initialPosition; // New field for initial position

        public Vector2 Position { get; private set; }
        public Matrix ViewMatrix => Matrix.CreateTranslation(new Vector3(Position, 0f));

        public Camera(Vector2 initialPosition)
        {
            this.initialPosition = initialPosition;
            Position = initialPosition;
        }

        public void ResetToInitialPosition()
        {
            Position = initialPosition;
        }
    }
}
