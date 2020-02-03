using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstApp.BLL;
using FirstApp.Models;

namespace FirstApp.BLL
{
    public class Setup
    {
        static private List<Tooling> wholeSetup = new List<Tooling>();
        static private List<Tooling> fractionSetup = new List<Tooling>();
        static private bool fnd;

        // Called by the SetUp button on Form1
        // target = mult width, mach = selection from drop down
        public List<Tooling> CalcSetup(decimal target, string mach, string fName, bool initFnd)
        {
            fnd = initFnd;

            List<Tooling> setup = new List<Tooling>();

            // clear lists
            wholeSetup.Clear();
            fractionSetup.Clear();

            // Get tooling inventory based on machine
            List<decimal> spacers = Invtry.GetArborSpacers(mach);
         
            // Break target into whole and fraction
            var parts = target.ToString().Split('.');

            // convert string whole and fraction into decimals
            decimal whole = decimal.Parse(parts[0]);
            decimal fraction = decimal.Parse(parts[1])/1000;

            // If fraction tenths = 0,1 or 2, borrow from whole
            // Only need if there are no fractional spacers < 0.100
            if ((whole >= 1) && (fraction * 10 <= 2))
            {
                whole -= 1;
                fraction += 1;
            }

            // only call Sum_Whole(), if there is a whole
            if (whole >= 1)
                wholeSetup = Sum_Whole(spacers, whole);

            // Put only fraction spacers < mult fraction in the list to pass to Sum_Fraction_Recursive
            List<decimal> fSpacers = new List<decimal>();

            foreach(decimal sp in spacers)
            {
                // Floor applied to fractions will = 0
                decimal spWhole = Math.Floor(sp);

                if (spWhole == 0 && sp <= fraction)
                    fSpacers.Add(sp);
            }

            //fractionSetup = Sum_Fraction_Recursive(spacers, fraction, 0, new List<decimal>(), fName);
            fractionSetup = Sum_Fraction_Recursive(fSpacers, fraction, new List<decimal>());

            //Add fractionSetup to end of wholeSetup.  Preserve order.
            //wholeSetup.AddRange(fractionSetup);

            // add whole and fraction setups to the main setup list
            setup.AddRange(wholeSetup);
            setup.AddRange(fractionSetup);

            // return setup;
            return setup;
        }

        //pass in list of spacers and whole part of mult width
        public static List<Tooling> Sum_Whole(List<decimal> spacers, decimal mult)
        { 
            //decimal startMult = mult;

            //List<Tooling> wholeSetup = new List<Tooling>();

            for (int i = 0; i < spacers.Count; i++)
            {
                // create new tooling object.  Function return a list of these objects.
                Tooling t = new Tooling();

                // get current space from list (ie: 3.2, 1.8, 0.1 and so on)
                decimal n = spacers[i];

                // Find largest integer <= mult / current spacer
                decimal numSp = Math.Floor(mult / n);

                // if spacer > mult, numSp = 0
                // don't execute until spacer < mult
                if (numSp != 0)
                {
                    // Create tooling object
                    t.loc = "arbor";
                    t.tp = "whole";
                    t.qty = Convert.ToInt16(numSp);
                    t.sz = n;

                    // Add tooling object to list
                    wholeSetup.Add(t);

                    // subract spacer from mult balance
                    mult = mult - numSp * n;
                }
            }

            return wholeSetup;
        }

        // pass in spacers, fraction part of mult width and empty list for recursion
        public static List<Tooling> Sum_Fraction_Recursive(List<decimal> spacers, decimal mult, List<decimal> partial)
        {         
            // variable to keep the sum of current spacer combination
            decimal s = 0;

            foreach (decimal x in partial)
                s += x;

            Console.WriteLine("Invty(" + string.Join(",", spacers.ToArray()) + ")");
            Console.WriteLine("Combo(" + string.Join(",", partial.ToArray()) + ") - " + s.ToString());

            // Exact match (s == mult)
            // Allow a match if sum of spacers is mult +/- 0.001 ((s >= (mult - 0.001m)) && (s <= (mult + 0.001m)))
            if (s == mult)
            {                      
                Console.WriteLine("Match(" + string.Join(",", partial.ToArray()) + ") = " + mult + " ***** MATCH *****");

                // Can have more than one correct combo, just keep the first
                if (fractionSetup.Count == 0)
                {
                    fnd = true;

                    // Step through partial and create a spacer object for each item in list
                    for (int k = 0; k < partial.Count; k++)
                    {
                        Tooling t = new Tooling();

                        decimal sp = partial[k];

                        // Create tooling object
                        t.loc = "arbor";
                        t.tp = "frac";
                        t.qty = 1;
                        t.sz = sp;

                        // Add object to list
                        fractionSetup.Add(t);
                    }
                }
                return fractionSetup;
            }

            // was s >= mult
            if (s > mult)
            {
                return fractionSetup;
            }
                
            for (int i = 0; i < spacers.Count; i++)
            {
                // Not sure how to end recursion when match is found.
                // Short circuit loop by advanding to Count-1.  Reduces
                // the remaining passes through the loop.
                if (fnd)
                    i = spacers.Count - 1;

                List<decimal> remaining = new List<decimal>();

                decimal n = spacers[i];

                for (int j = i + 1; j < spacers.Count; j++)
                    remaining.Add(spacers[j]);

                List<decimal> partial_rec = new List<decimal>(partial);
                partial_rec.Add(n);

                Sum_Fraction_Recursive(remaining, mult, partial_rec);
            }

            return fractionSetup;
        }

        // pass in spacers, fraction part of mult width and empty list for recursion
        public static List<Tooling> Sum_Fraction_Recursive1(List<decimal> spacers, decimal mult, List<decimal> partial, string fName)
        {
           
            // Keep of list of combinations
            List<string> combo = new List<string>();

            // variable to keep the sum of current spacer combination
            decimal s = 0;

            foreach (decimal x in partial)
                s += x;

            combo.Add("Partial(" + string.Join(",", partial.ToArray()) + ") - " + s.ToString());
            Console.WriteLine("Partial(" + string.Join(",", partial.ToArray()) + ") - " + s.ToString());

            if (s == mult)
            {
                combo.Add("Spacers(" + string.Join(",", partial.ToArray()) + ") = " + mult);
                Console.WriteLine("Spacers(" + string.Join(",", partial.ToArray()) + ") = " + mult);

                // Can have more than one correct combo, just keep the first
                if (fractionSetup.Count == 0)
                {
                    for (int k = 0; k < partial.Count; k++)
                    {
                        Tooling t = new Tooling();

                        decimal sp = partial[k];

                        // Create tooling object
                        t.loc = "arbor";
                        t.tp = "frac";
                        t.qty = 1;
                        t.sz = sp;

                        fractionSetup.Add(t);
                    }
                }
            }

            if (s >= mult)
            {
                //Helpers.WriteList(combo, fName);

                return fractionSetup;
            }


            for (int i = 0; i < spacers.Count; i++)
            {
                List<decimal> remaining = new List<decimal>();

                decimal n = spacers[i];

                for (int j = i + 1; j < spacers.Count; j++)
                    remaining.Add(spacers[j]);

                List<decimal> partial_rec = new List<decimal>(partial);
                partial_rec.Add(n);

                Sum_Fraction_Recursive1(remaining, mult, partial_rec, fName);
            }

            //Helpers.WriteList(combo, fName);

            return fractionSetup;
        }
    }
}
