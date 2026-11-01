using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program4Spring2025
{
    public class LibraryBook
    {
        public const int default_PageCount = 100;//default page count set
        public const double default_Price = 1.00;//default price amount set
        public const int default_TimesBorrowed = 0;//default times borrowed count set

        private string _title;//backing field for the title
        private double _retailPrice;//backing field for the price
        private int _pageCount;//backing field for the page count
        private int _timesBorrowed;//backing field for the times borrowed
        private bool _available;//backing field for available

        //constructor
        public LibraryBook(string title, double retailPrice, int pageCount, int timesBorrowed, bool available) 
        {//property = parameter
            Title = title;
            RetailPrice = retailPrice;
            PageCount = pageCount;
            TimesBorrowed = timesBorrowed;
            Available = available;
        }

        public string Title//Title property
        { 
            get { return _title; } 
            set { _title = value; } 
        }

        public double RetailPrice//Price property
        {
            get { return _retailPrice; }
            set
            {
                if (value > 0) //validates price is greater than 0
                    _retailPrice = value;
                else
                    _retailPrice = default_Price;//if not then used default
            }
        }

        public int PageCount//Page count property 
        { 
            get { return _pageCount; } 
            set {
                if (value>0) //validates page count is greater than 0
                    _pageCount = value;
                else
                    _pageCount = default_PageCount;//if not then used default
            } 
        }
        public int TimesBorrowed//Times borrowed property
        {
            get { return _timesBorrowed; }
            set
            {
                if (value >= 0)//validates times borrowed is greater than or 0
                    _timesBorrowed = value;
                else
                    _timesBorrowed = default_TimesBorrowed;//if not then used default
            }
        }

        public bool Available//Available property
        {
            get { return _available; }
            set { _available = value; }
        }

        public void MakeAvailable()//method that sets availability to true
        {
            _available = true;
        }

        public void MakeUnavailable()//method that sets availability to false
        {
            _available = false;
        }

        public bool IsAvailable()
        { 
            return _available;
        }

        public override string ToString()//method that returns a string with no parameters
        {
            return $"Title: {Title} {Environment.NewLine}Retail Price: {RetailPrice:C} {Environment.NewLine}Page Count: {PageCount} {Environment.NewLine}" +
                $"Times Borrowed: {TimesBorrowed} {Environment.NewLine}Available?: {IsAvailable()}";
        }



    }
}
