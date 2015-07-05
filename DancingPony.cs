using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PonyDancer
{
    public partial class DancingPony : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        internal Bitmap[] idlePositions = { Twilight.stand_right /*, Twilight.read*/ };
        internal Bitmap[] dancePositions = { Twilight.partyhard_right, Twilight.partyhard_left };

        private Bitmap bufferedBitmap;
        private bool bitmapLoaded = false;

        public enum State { DANCING, IDLE, BEING_DRAGGED };
        private State state = State.IDLE;

        private void DancingPony_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;

            bitmapLoaded = false;
            bufferedBitmap = Twilight.drag_left;
            this.state = State.BEING_DRAGGED;
        }

        private void DancingPony_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void DancingPony_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                int x = this.Location.X - xDiff + 20;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void DancingPony_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
        }

        private void DancingPony_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        /// <summary>
        /// Represents a DancingPony, it will overlay all windows
        /// on the user's desktop, and will respond to music via
        /// the PonyManager.
        /// </summary>
        /// <seealso cref="PonyManager"/>
        public DancingPony()
        {
            InitializeComponent();
            renderTick.Start();
            skinRandomizerTick.Start();

            ponyImage.MouseMove += DancingPony_MouseMove;
            ponyImage.MouseDown += DancingPony_MouseDown;
            ponyImage.MouseUp   += DancingPony_MouseUp;

            ponyImage.MouseEnter += DancingPony_MouseEnter;
            ponyImage.MouseLeave += DancingPony_MouseLeave;
        }

        private Bitmap GetRandomPosition(Bitmap[] positions)
        {
            // we want to keep this positions.Length
            // because it will never return the max
            return positions[Utils.RandomNumber(0, positions.Length)];
        }

        /// <summary>
        /// Gets the pony's current state.
        /// </summary>
        /// <see cref="DancingPony.State"/>
        /// <returns>The current state of the pony</returns>
        public State GetState()
        {
            return this.state;
        }

        /// <summary>
        /// Set the pony to its IDLE state and position.
        /// </summary>
        /// <seealso cref="DancingPony.State"/>
        public void SetIdle()
        {
            if (this.state != State.IDLE && !mouseIsDown)
            {
                bitmapLoaded = false;
                bufferedBitmap = GetRandomPosition(idlePositions);
                this.state = State.IDLE;
            }
        }

        /// <summary>
        /// Set the pony to its DANCING state and position.
        /// </summary>
        /// <seealso cref="DancingPony.State"/>
        public void SetDancing()
        {
            if (this.state != State.DANCING && !mouseIsDown)
            {
                bitmapLoaded = false;
                bufferedBitmap = GetRandomPosition(dancePositions);
                this.state = State.DANCING;
            }
        }

        /// <summary>
        /// Sets the pony's position relative to the bottom left of it.
        /// </summary>
        public void SetPosition(Point coords)
        {
            Point newCoords = new Point(coords.X, coords.Y - this.Height);
            this.Location = newCoords;
        }

        /// <summary>
        /// Makes sure the pony stays on its feet and the Form doesn't
        /// take up more than it should.
        /// </summary>
        private void renderTick_Tick(object sender, EventArgs e)
        {
            if (!bitmapLoaded && bufferedBitmap != null)
            {
                ponyImage.Image = bufferedBitmap;
                bitmapLoaded = true;
            }

            int prevHeight = this.Height;

            ponyImage.Height = ponyImage.Image.Height;
            ponyImage.Width = ponyImage.Image.Width;
            this.Height = ponyImage.Image.Height;
            this.Width = ponyImage.Image.Width;

            // to keep their feet on wherever they should be, like this:
            // https://i.imgur.com/ryEmJjk.gif
            int heightDiff = this.Height - prevHeight;
            this.Location = new Point(this.Location.X, this.Location.Y - heightDiff);
        }

        private void skinRandomizerTick_Tick(object sender, EventArgs e)
        {
            switch (state)
            {
                case State.DANCING:
                    bitmapLoaded = false;
                    bufferedBitmap = GetRandomPosition(dancePositions);
                    break;
                case State.IDLE:
                    bitmapLoaded = false;
                    bufferedBitmap = GetRandomPosition(idlePositions);
                    break;
            }
        }
    }
}
