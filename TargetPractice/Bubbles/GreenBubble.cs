using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPractice.Bubbles
{
    public class GreenBubble : BubbleTemplate
    {
        public override int SetPointsValue()
        {
            return 75;
        }
        public override string SetBubbleColor()
        {
            return "GREEN";
        }

        public override int SetBubbleSpeed()
        {
            return GenerateRandom(6, 10);
        }
    }
}
