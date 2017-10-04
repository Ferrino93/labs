﻿using System;
using System.Collections;

namespace CSharp_Net_module1_4_3_lab
{
    // 12) change methods of sorting to properties

    // 1) implement interface IComparable
    public class Animal : IComparable
    {
        // 2) declare properties and parameter constructor
        private string genus;

        public string Genus
        {
            get { return genus; }
            set { genus = value; }
        }

        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public Animal(string genus, int weight)
        {
            Genus = genus;
            Weight = weight;
        }
        // 3) implement method ComareTo()

        // it comares Genus of type string - return result of method String.Compare 
        // for this.genus and argument object
        // don't forget to cast object to Animal
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


        // 4) declare methods SortWeightAscending(), SortGenusDescending()
        // they are static and return IComparer
        // return type is custed from constructor of classes SortWeightAscendingHelper, 
        // SortGenusDescendingHelper calling 
        public static IComparer SortWeightAscending(object obj)
        {
            throw new NotImplementedException();
        }

        public static IComparer SortGenusDescending(object obj)
        {
            throw new NotImplementedException();
        }




        // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
        // they implement interface IComparer

        private class SortWeightAscendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                throw new NotImplementedException();
            }
        }

        private class SortGenusDescendingHelper : IComparer
        {
            public int Compare(object x, object y)
            {
                throw new NotImplementedException();
            }
        }
        // every nested class has implemented method Comare with 2 parameters of object and return int
        // class SortWeightAscendingHelper sort weight by ascending
        // class SortGenusDescendingHelper sort genus by descending

    }
}
