﻿using System.Collections.Generic;

namespace Shield.Client.Fr.Models.API.Application
{
    public class UploadConfirmationDto
    {
        public bool RequiresDependencies { get; set; }
        public string Message { get; set; }

        public List<string> RequiredDependencies { get; set; }

    }
}
