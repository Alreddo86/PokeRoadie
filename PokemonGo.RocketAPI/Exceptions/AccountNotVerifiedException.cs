﻿#region

using System;

#endregion

namespace PokemonGo.RocketAPI.Exceptions
{
    public class AccountNotVerifiedException : Exception
    {
        public AccountNotVerifiedException()
            :base()
        {
        }
        public AccountNotVerifiedException(string message)
            :base(message)
        {
        }
    }
}