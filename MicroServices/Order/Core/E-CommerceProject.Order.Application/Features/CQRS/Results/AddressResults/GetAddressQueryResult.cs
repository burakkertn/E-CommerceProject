﻿namespace E_CommerceProject.Order.Application.Features.CQRS.Results.AddressResults
{
    public class GetAddressQueryResult
    {
        public int IdAddress { get; set; }
        public string UserId { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}