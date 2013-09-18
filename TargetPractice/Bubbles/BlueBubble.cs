using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TargetPractice.Bubbles
{
    public class BlueBubble : BubbleTemplate
    {
        public override int SetPointsValue()
        {
            int PointsValue = 50;
            return PointsValue;
        }
        public override string SetBubbleColor()
        {
            return "BLUE";
        }

        public override int SetBubbleSpeed()
        {
            return GenerateRandom(1, 5);
        }
    }
}
