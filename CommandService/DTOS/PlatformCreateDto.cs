﻿using CommandService.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommandService.DTOS
{
    public class PlatformCreateDto
    {
        public int ExternalId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }
        public IEnumerable<Command> Commands { get; set; } = new List<Command>();

    }
}
