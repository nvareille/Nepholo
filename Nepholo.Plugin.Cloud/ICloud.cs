﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepholo.Plugin.Cloud
{
    [InheritedExport(typeof (ICloud))]
    public interface ICloud
    {
        string Name { get; }
        string Symbol { get; }

        // Request a OAuth Token
        Task<string> GetOAuthToken();

        // Initialize a new Cloud for the first time
        Task Create(string url);

        // Initialize a new Client with nothing
        void Connect();

        // Remove Token
        void Deconnect();

        // Download something
        void Download(string id, string name);

        // Upload something
        void Upload(string id, string name);

        // List root folder's content
        Task<List<File>> GetRoot();

        // List folder's content
        Task<List<File>> GetFolder(string id);

        // Get user's informations
        Task<Account> Identify();
    }
}
