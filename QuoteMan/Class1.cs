using System;

namespace QuoteMan
{
    public class Quotes
    {
        private System.String _sQuote1 = "Hello world";
        private System.String _sQuote2 = "I am a little tea pot";
        private System.String _sQuote3 = "Hail to the king, baby!";

        public System.String PrintRandomQuote()
        {
            System.String Result = "SHIT";

            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int bob = rnd.Next(1, 4);

            switch (bob)
            {
                case 1:
                    Result = _sQuote1;
                    break;
                case 2:
                    Result = _sQuote2;
                    break;
                case 3:
                    Result = _sQuote3;
                    break;
            }

            return Result;
        }

        public System.String ReturnQuote(int QuoteNumber)
        {
            System.String Result = "Fuck you!";

            if (1 <= QuoteNumber && QuoteNumber <= 3)
            {
                switch (QuoteNumber)
                {
                    case 1:
                        Result = _sQuote1;
                        break;
                    case 2:
                        Result = _sQuote2;
                        break;
                    case 3:
                        Result = _sQuote3;
                        break;
                }
            }

            return Result;
        }

        public System.Int16 QuoteCount
        {
            get { return 3; }
        }
    }
}
