﻿using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public interface IRate
    {
        List<Rate> GetAllRate();
        string InsertRate(Rate rate);
        string UpdateRate(Rate rate);
    }
}
