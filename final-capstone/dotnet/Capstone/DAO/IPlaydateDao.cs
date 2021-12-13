﻿using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface IPlaydateDao
    {
        //Anonymous user methods
        public Playdate GetPlaydate(int playdateId); //Anonymous users can view any playdate
        public List<Playdate> GetPlaydatesByUserId(int userId); //Anonymous users can view any playdate of a specified user



        //Registered user methods
        public Playdate RegisterPlaydate(Playdate newPlaydate); //Registered users can register their playdate in system
        public List<Playdate> GetLoggedInUserPlaydates(int userId); //Registered users can view their playdates
        public bool DeleteLoggedInUserPlaydate(int playdateId, int userId); //Registered users can delete any of their playdates
        public bool UpdateLoggedInUserPlaydate(Playdate updatedPlaydate, int userId, int playdateId); //Registered users can update any of their playdates
        public bool RequestPlaydate(Playdate updatedPlaydate, int userId, int playdateId); //Registered users can request to meet a pet

        public bool AcceptPlaydate(Playdate updatedPlaydate, int userId, int playdateId); //Registered users can accept a playdate after a request
        public bool RejectPlaydate(Playdate updatedPlaydate, int userId, int playdateId); //Registered users can reject a playdate after a request
        public bool CancelPlaydate(Playdate updatedPlaydate, int userId, int playdateId); //Registered users can cancel a playdate after accepted (requested & posted user)

        //public bool FinishPlaydate(Playdate updatedPlaydate, int playdateId); //Registered users can make a playdate as finished




        //Admin user methods
        public bool DeletePlaydate(int playdateId); //Admins can delete any playdate
        public bool UpdatePlaydate(Playdate updatedPlaydate, int playdateId); //Admins can update any playdate
    }
}
