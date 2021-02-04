﻿using ChattingHub.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace ChattingHub.Controllers
{
    [ApiController]
    public class ChatController : ControllerBase
    {
        private ILogger<ChatController> _logger;
        public ChatController(ILogger<ChatController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("api/chat/PostUser")]
        public void PostUser(UserModel user)
        {
            if(user.Name != null)
            {
                ChatHub.UsersAndMessages.Users.Add(user);
            }
        }
    }
}
