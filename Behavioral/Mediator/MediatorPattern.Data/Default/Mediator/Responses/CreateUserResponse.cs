﻿using System;

namespace MediatorPattern.Data.Default.Mediator.Responses
{
    public class CreateUserResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
