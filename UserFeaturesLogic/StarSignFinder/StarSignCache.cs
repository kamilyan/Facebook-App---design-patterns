using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using UserFeaturesLogic.Types;

namespace UserFeaturesLogic
{ // this class saves information of each star sign.
    internal sealed class StarSignCache
    {
        private static StarSignCache s_StarSignInstance = null;
        private static object s_LockObj = new object();

        public static StarSignCache StarSignsInstance
        {
            get
            {
                if (s_StarSignInstance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_StarSignInstance == null)
                        {
                            s_StarSignInstance = new StarSignCache();
                        }
                    }
                }

                return s_StarSignInstance;
            }
        }

        public Dictionary<eZodiacSigns, string> StarSignContentInfo { get; private set; }

        private StarSignCache()
        {
            StarSignContentInfo = new Dictionary<eZodiacSigns, string>();
            initializeCacheStarSignInformation();
        }

        public eZodiacSigns GetZodiacSign(DateTime i_DateTime)
        {
            eZodiacSigns astroSign = eZodiacSigns.NoSetUp;
            eMonths month = (eMonths)i_DateTime.Month;
            int day = i_DateTime.Day;

            switch (month)
            {
                case eMonths.December: 
                     astroSign = (day < 22) ? eZodiacSigns.Sagittarius : eZodiacSigns.Capricorn;
                    break;

                case eMonths.January:
                    astroSign = (day < 20) ? eZodiacSigns.Capricorn : eZodiacSigns.Aquarius;
                    break;

                case eMonths.February:
                    astroSign = (day < 19) ? eZodiacSigns.Aquarius : eZodiacSigns.Pisces;
                    break;

                case eMonths.March:
                    astroSign = (day < 21) ? eZodiacSigns.Pisces : eZodiacSigns.Aries;
                    break;

                case eMonths.April:
                    astroSign = (day < 20) ? eZodiacSigns.Aries : eZodiacSigns.Taurus;
                    break;

                case eMonths.May:
                    astroSign = (day < 21) ? eZodiacSigns.Taurus : eZodiacSigns.Gemini;
                    break;

                case eMonths.June:
                    astroSign = (day < 21) ? eZodiacSigns.Gemini : eZodiacSigns.Cancer;
                    break;

                case eMonths.July:
                    astroSign = (day < 23) ? eZodiacSigns.Cancer : eZodiacSigns.Leo;
                    break;

                case eMonths.August:
                    astroSign = (day < 23) ? eZodiacSigns.Leo : eZodiacSigns.Virgo;
                    break;

                case eMonths.September:
                    astroSign = (day < 23) ? eZodiacSigns.Virgo : eZodiacSigns.Libra;
                    break;

                case eMonths.October:
                     astroSign = (day < 23) ? eZodiacSigns.Libra : eZodiacSigns.Scorpio;
                    break;

                case eMonths.November:
                    astroSign = (day < 22) ? eZodiacSigns.Scorpio : eZodiacSigns.Sagittarius;
                    break;
            }

            return astroSign;
        }

        private void initializeCacheStarSignInformation()
        {
            string aries = "The Ram - because of r_Aries’ brave, tenacious ability to climb to the top of the mountain, no matter what.";
            string taurus = "The Bull - because of their resilience and stubbornness! And, like a bull, they can be both frighteningly fierce or serenely gentle.";
            string gemini = "The Twins - because of their duality, versatility and ability to talk twice as fast and say twice as much as everyone else.";
            string cancer = "The Crab - because they are secretive and guarded. A hard shell protects the soft flesh beneath (their extreme emotional sensitivity). ";
            string leo = "The Lion - because of their regal and noble personality, they love to lead and naturally protect those they perceive as being vulnerable.";
            string virgo = "The Virgin - because of their pure intentions, and their modest, conscientious nature.";
            string libra = "he Scales - because Librans are ALL about balance. Keeping everything on an even keel and behaving with fairness are their driving motivations.";
            string scorpio = "The Scorpion - because Scorpios are kinda’ dangerous, a secretive creature which can poison its enemies if riled… beware!";
            string sagittarius = "The Archer - because they aim high and true, love the outdoors and enjoy the thrill of the case.";
            string capricorn = "The Goat - because they are a determined animal who rises up the path by taking advantage of every foothold. Always climbing.";
            string aquarius = "The Water-Bearer - symbolically, the water represents truth, which Aquarians deliver freely and fairly to the world. A truth-sayer!";
            string pisces = "Two fishes tied to one another, swimming in opposite directions- because all Pisceans swim amidst shifting emotional currents, and are plagued by both conflicting desires and extremes of temperament.";

            StarSignContentInfo.Add(eZodiacSigns.Aries, aries);
            StarSignContentInfo.Add(eZodiacSigns.Taurus, taurus);
            StarSignContentInfo.Add(eZodiacSigns.Gemini, gemini);
            StarSignContentInfo.Add(eZodiacSigns.Cancer, cancer);
            StarSignContentInfo.Add(eZodiacSigns.Leo, leo);
            StarSignContentInfo.Add(eZodiacSigns.Virgo, virgo);
            StarSignContentInfo.Add(eZodiacSigns.Libra, libra);
            StarSignContentInfo.Add(eZodiacSigns.Scorpio, scorpio);
            StarSignContentInfo.Add(eZodiacSigns.Sagittarius, sagittarius);
            StarSignContentInfo.Add(eZodiacSigns.Capricorn, capricorn);
            StarSignContentInfo.Add(eZodiacSigns.Aquarius, aquarius);
            StarSignContentInfo.Add(eZodiacSigns.Pisces, pisces);
        }
    }
}