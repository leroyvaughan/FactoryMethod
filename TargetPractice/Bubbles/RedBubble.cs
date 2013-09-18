using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPractice.Bubbles
{
    public class RedBubble : BubbleTemplate
    {
        public override int SetPointsValue()
        {
            return 150;
        }
        public override string SetBubbleColor()
        {
            return "RED";
        }

        public override int SetBubbleSpeed()
        {
            return GenerateRandom(10, 15);
        }
    }
}
