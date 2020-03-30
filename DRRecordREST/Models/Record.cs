using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DRRecordREST.Models
{
    public class Record
    {
        private string _title;
        private string _artist;
        private double _duration;
        private int _yearOfProduction;

        public Record(string title, string artist, double duration, int yearOfProduction)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            YearOfProduction = yearOfProduction;
        }

        public string Title
        {
            get { return _title;}
            set
            {
                //if (value == null)
                //{
                //    throw new ArgumentNullException();
                //}
                //else
                //{
                _title = value;
                //}
            }
        }

        public string Artist
        {
            get { return _artist; }
            set
            {
                //if( value != null)
                //{
                //    if (value.Length > 2)
                //    {
                _artist = value;
                //    }
                //    throw new ArgumentOutOfRangeException();


                //}
                //throw new ArgumentNullException();


            }
        }

        public double Duration
        {
            get { return _duration; }
            set
            {
                //if (value == 0)
                //{
                //    throw new ArgumentNullException();
                //}
                //else
                //{
                _duration = value;
                //}
            }
        }

        public int YearOfProduction
        {
            get { return _yearOfProduction; }
            set
            {
                //if (value != 0)
                //{
                //    if (value > 2020)
                //    {
                _yearOfProduction = value;

                //    }
                //    throw new ArgumentOutOfRangeException();
                //}
                //throw new ArgumentNullException();

            }
        }
    }
}
