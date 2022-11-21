﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clicket
{
    internal class Action
    {
        DB db = new DB();
        public void add(Movie movieItem)
        {
            db.insert(movieItem);
        }
        public void update(Movie movieItem)
        {
            db.update(movieItem);
        }
        public void add(Event eventItem)
        {
            db.insert(eventItem);
        }
        public void update(Event eventItem)
        {
            db.update(eventItem);
        }
        public User login(string _username, string _password)
        {
            return db.login(_username, _password);
        }

        public List<Movie> getMovieList()
        {
            return db.getMovies();
        }

        public List<Event> getEventList()
        {
            return db.getEvents();
        }

        public List<History> getHistoryList(int _id)
        {
            return db.getHistory(_id);
        }

        public List<Transaction> getHistoryListAdmin()
        {
            return db.getHistoryAdmin();
        }

        public Boolean orderMovie(int movie_id, int user_id, int qty, int amount, string file)
        {
            return db.order_movie(movie_id, user_id, qty, amount, file);
        }

        public Boolean orderEvent(int event_id, int user_id, int qty, int amount, string file)
        {
            return db.order_event(event_id, user_id, qty, amount, file);
        }

    }
}
