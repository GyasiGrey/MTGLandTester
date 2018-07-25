using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGLandTester
{
    public class LandTester
    {
        enum CardType
        {
            Basic,
            NonBasic,
            Spell
        }

        public string TestLands(int basicLands, int nonBasic, int spells, int handsize, int numDraws)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            List<CardType> cards = new List<CardType>();

            sb.AppendLine("Building deck with " + basicLands + " basics " + nonBasic + " non basics and " + spells + " spells. " + (basicLands + nonBasic + spells) + " total cards.");
            for (int i = 0; i < basicLands; i++)
            {
                cards.Add(CardType.Basic);
            }

            for (int i = 0; i < nonBasic; i++)
            {
                cards.Add(CardType.NonBasic);
            }


            for (int i = 0; i < spells; i++)
            {
                cards.Add(CardType.Spell);
            }

            int[] handTypes = new int[18];

            //draw hands
            for (int i = 0; i < numDraws; i++)
            {
                //shuffle the list
                cards = cards.OrderBy(a => Guid.NewGuid()).ToList();

                int keepBasics = 0;
                int keepNonBasics = 0;

                //look at the first 7 cards to determine if they are keepers
                for (int j = 0; j < handsize; j++)
                {
                    if (cards[j] == CardType.Basic)
                    {
                        keepBasics++;
                    }
                    else if (cards[j] == CardType.NonBasic)
                    {
                        keepNonBasics++;
                    }
                }


                if (keepBasics == 0 && keepNonBasics == 0)
                {
                    handTypes[0]++;
                }
                else if (keepBasics == 1 && keepNonBasics == 0)
                {
                    handTypes[1]++;
                }
                else if (keepBasics == 2 && keepNonBasics == 0)
                {
                    handTypes[2]++;
                }
                else if (keepBasics == 3 && keepNonBasics == 0)
                {
                    handTypes[3]++;
                }
                else if (keepBasics == 4 && keepNonBasics == 0)
                {
                    handTypes[4]++;
                }
                else if (keepBasics == 5 && keepNonBasics == 0)
                {
                    handTypes[5]++;
                }

                else if (keepBasics == 0 && keepNonBasics == 1)
                {
                    handTypes[6]++;
                }
                else if (keepBasics == 1 && keepNonBasics == 1)
                {
                    handTypes[7]++;
                }
                else if (keepBasics == 2 && keepNonBasics == 1)
                {
                    handTypes[8]++;
                }
                else if (keepBasics == 3 && keepNonBasics == 1)
                {
                    handTypes[9]++;
                }
                else if (keepBasics == 4 && keepNonBasics == 1)
                {
                    handTypes[10]++;
                }
                else if (keepBasics == 5 && keepNonBasics == 1)
                {
                    handTypes[11]++;
                }

                else if (keepBasics == 0 && keepNonBasics == 2)
                {
                    handTypes[12]++;
                }
                else if (keepBasics == 1 && keepNonBasics == 2)
                {
                    handTypes[13]++;
                }
                else if (keepBasics == 2 && keepNonBasics == 2)
                {
                    handTypes[14]++;
                }
                else if (keepBasics == 3 && keepNonBasics == 2)
                {
                    handTypes[15]++;
                }
                else if (keepBasics == 4 && keepNonBasics == 2)
                {
                    handTypes[16]++;
                }
                else if (keepBasics == 5 && keepNonBasics == 2)
                {
                    handTypes[17]++;
                }
            }

            sb.AppendLine("Across " + numDraws + " draws:");
            sb.AppendLine(handTypes[0] + " 0 basic lands. 0 non basic.");
            sb.AppendLine(handTypes[1] + " 1 basic lands. 0 non basic.");
            sb.AppendLine(handTypes[2] + " 2 basic lands. 0 non basic.!!");
            sb.AppendLine(handTypes[3] + " 3 basic lands. 0 non basic.**");
            sb.AppendLine(handTypes[4] + " 4 basic lands. 0 non basic.**");
            sb.AppendLine(handTypes[5] + " 5 basic lands. 0 non basic.");
            sb.AppendLine(handTypes[6] + " 0 basic lands. 1 non basic.");
            sb.AppendLine(handTypes[7] + " 1 basic lands. 1 non basic.");
            sb.AppendLine(handTypes[8] + " 2 basic lands. 1 non basic.**");
            sb.AppendLine(handTypes[9] + " 3 basic lands. 1 non basic.**");
            sb.AppendLine(handTypes[10] + " 4 basic lands. 1 non basic.");
            sb.AppendLine(handTypes[11] + " 5 basic lands. 1 non basic.");
            sb.AppendLine(handTypes[12] + " 0 basic lands. 2 non basic.");
            sb.AppendLine(handTypes[13] + " 1 basic lands. 2 non basic.");
            sb.AppendLine(handTypes[14] + " 2 basic lands. 2 non basic.**");
            sb.AppendLine(handTypes[15] + " 3 basic lands. 2 non basic.");
            sb.AppendLine(handTypes[16] + " 4 basic lands. 2 non basic.");
            sb.AppendLine(handTypes[17] + " 5 basic lands. 2 non basic.");

            return sb.ToString();
        }
    }
}
