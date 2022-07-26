﻿using OnlineHotelManagementAPI.Models;
using OnlineHotelManagementAPI.Repositories;

namespace OnlineHotelManagementAPI.Service
{
    public class PaymentService : IPayment
    {
        private IPayment _IPayment;

        public PaymentService(IPayment iPayment)
        {
            _IPayment = iPayment;
        }

        public List<Payment> GetAllPayment()
        {
            return _IPayment.GetAllPayment();

        }

        public string InsertPayment(Payment payment)
        {
            return _IPayment.InsertPayment(payment);
        }

        public void SavePayment(Payment payment)
        {
            _IPayment.SavePayment(payment);
        }

        public string UpdatePayment(Payment payment)
        {
            return _IPayment.UpdatePayment(payment);
        }
    }
}
