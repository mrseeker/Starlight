﻿using Starlight.Client.Handlers.Core;
using Starlight.Client.Network;
using Starlight.Client.Screens;
using Starlight.Packets;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starlight.Client.Handlers
{
    public class RegistrationResultPacketHandler : AbstractPacketHandler<RegistrationResultPacket>
    {
        public override void HandlePacket(RequestContext requestContext, RegistrationResultPacket packet) {
            if (requestContext.ScreenContainer.Screen is MainMenuScreen mainMenuScreen) {
                mainMenuScreen.AnnounceRegistration(packet.Succeeded, packet.Message);
            }
        }
    }
}
