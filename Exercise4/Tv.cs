using System;

namespace Exercise4
{
    internal class Tv
    {
        private int _currentChannel;
        private string _marke;
        private int _maxChannels;
        private int _volume;
        public bool TurnTvOn { get; set; }

        public int CurrentChannel
        {
            get { return _currentChannel; }
            set
            {
                if (value >= 0 && value <= _maxChannels)
                {
                    _currentChannel = value;
                }
                else if (value > MaxChannels)
                {
                    _currentChannel = 0;
                }
                else
                {
                    _currentChannel = _maxChannels;
                }
            }
        }

        public int Volume
        {
            get { return _volume; }
            set
            {
                if (value >= 0 && value < 100)
                {
                    _volume = value;
                }
            }
        }

        public string Marke
        {
            get { return _marke; }
            set
            {
                if (value != null)
                {
                    _marke = value;
                }
            }
        }

        public int MaxChannels
        {
            get { return _maxChannels; }
            set
            {
                if (value > 0 && value <= 100)
                {
                    _maxChannels = value;
                }
                else
                {
                    throw new Exception("Ange en kanal mängd mellan 1-100");
                }
            }
        }
    }
}