﻿namespace Library.Core.CrossCuttingConcerns.Exceptions;

public class AuthorizationException : Exception
{
    public AuthorizationException(string message) : base(message)
    {
    }
}