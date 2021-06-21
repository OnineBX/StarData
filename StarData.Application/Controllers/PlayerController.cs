//  PlayerController.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       20:38:6 21/6/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StarData.Application.Controllers
{
    public class PlayerController : ControllerBase
    {
        private readonly ILogger<PlayerController> _logger;
        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }
    }
}
