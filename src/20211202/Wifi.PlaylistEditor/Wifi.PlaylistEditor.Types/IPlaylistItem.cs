﻿using System;
using System.Drawing;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlaylistItem
    {
        string Title { get; }

        string Artist { get; }

        TimeSpan Duration { get; }

        string Path { get; }

        Image Thumbnail { get; }
    }
}