using System;

namespace TargetPractice
{
    public abstract class BubbleTemplate
    {
        int _points;
        int _speed;
        string _color;

        public BubbleTemplate()
        {
            _color = SetBubbleColor();
            _points = SetPointsValue();
            _speed = SetBubbleSpeed();

            Console.WriteLine("{0} colored bubble worth {1} points falling at speed {2}.\r\n",
                                _color, _points, _speed);
        }

        //must be overridden in derived class
        public abstract int SetPointsValue();
        public abstract string SetBubbleColor();
        public abstract int SetBubbleSpeed();

        //used to get random number for bubble speed.
        //does not have to be overridden. speed can be hardcoded in subclass
        public virtual int GenerateRandom(int minValue, int maxValue)
        {
            Random randNum = new Random();
            return randNum.Next(minValue, maxValue);
        }
    }
}