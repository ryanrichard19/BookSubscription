﻿using BookSubscriptions.Core.Dto.UseCaseResponses;
using BookSubscriptions.Core.Interfaces;

namespace BookSubscriptions.Core.Dto.UseCaseRequests
{
  public class LoginRequest : IUseCaseRequest<LoginResponse>
  {
    public string Email { get; }
    public string Password { get; }

    public LoginRequest(string emailaddress, string password)
    {
      Email = emailaddress;
      Password = password;
    }
  }
}
