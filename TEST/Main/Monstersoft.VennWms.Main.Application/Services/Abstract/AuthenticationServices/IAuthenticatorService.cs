﻿using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;

public interface IAuthenticatorService
{
    public Task<EmailAuthenticator> CreateEmailAuthenticator(User user);
    public Task<OtpAuthenticator> CreateOtpAuthenticator(User user);
    public Task<string> ConvertSecretKeyToString(byte[] secretKey);
    public Task SendAuthenticatorCode(User user);
    public Task VerifyAuthenticatorCode(User user, string authenticatorCode);
}