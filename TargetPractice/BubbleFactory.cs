using System;
using TargetPractice.Bubbles;

namespace TargetPractice
{
    public abstract class BubbleFactoryBase
    {
        public abstract BubbleTemplate CreateBubble(int type);
    }

    public class BubbleFactory : BubbleFactoryBase
    {
        public override BubbleTemplate CreateBubble(int type)
        {
            switch (type)
            {
                case 1: return new RedBubble();
                case 2: return new GreenBubble();
                case 3: return new BlueBubble();
                default: return new RedBubble();
            }
        }
    }
}