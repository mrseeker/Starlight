﻿using Microsoft.EntityFrameworkCore;
using Starlight.Models;
using Starlight.Packets;
using Starlight.Server.Handlers.Core;
using Starlight.Server.Network;
using Starlight.Server.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starlight.Server.Handlers
{
    public class LoginPacketHandler : AbstractPacketHandler<LoginPacket>
    {
        public override void HandlePacket(RequestContext requestContext, LoginPacket packet) {
            var user = requestContext.DbContext.Users.Include(x => x.Characters)
                                                     .Where(x => x.Username.ToLower() == packet.Username.ToLower()).FirstOrDefault();
            if (user == null) {
                requestContext.Server.SendPacket(requestContext.ConnectionId, new LoginResultPacket(false, "Invalid username or password."));
                return;
            }

            var passwordHasher = new PasswordHasher();
            if (!passwordHasher.VerifyPassword(user.PasswordHash, user.PasswordSalt, packet.Password)) {
                requestContext.Server.SendPacket(requestContext.ConnectionId, new LoginResultPacket(false, "Invalid username or password."));
                return;
            }

            var characters = user.Characters.Select(x => new MenuCharacterDetails()
            {
                Id = x.Id,
                Name = x.Name
            }).ToArray();

            requestContext.Server.SendPacket(requestContext.ConnectionId, new LoginResultPacket(true, string.Empty));
            requestContext.Server.SendPacket(requestContext.ConnectionId, new MenuCharacterDetailsPacket(characters));
        }
    }
}