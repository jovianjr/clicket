﻿using System;

namespace Clicket
{
    class Movie
    {
        private int _movieID;
        private string _title;
        private string _description;
        private DateTime _date;
        private int _durationHour;
        private int _durationMin;
        private int _price;
        private int _quota;
        private string _imgURL;
        private string _genre;
        private string _ageRate;

        public int MovieID
        {
            get { return _movieID; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public int DurationHour
        {
            get { return _durationHour; }
            set { _durationHour = value; }
        }

        public int DurationMin
        {
            get { return _durationMin; }
            set { _durationMin = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int Quota
        {
            get { return _quota; }
            set { _quota = value; }
        }

        public string ImgURL
        {
            get { return _imgURL; }
            set { _imgURL = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string ageRate
        {
            get { return _ageRate; }
            set { _ageRate = value; }
        }

        public BuyTicket(int movieID)
        {

        }
    }
}