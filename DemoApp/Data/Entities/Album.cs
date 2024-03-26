using System;
using System.Collections.Generic;

namespace DemoApp.Data.Entities;

public partial class Album
{
    public int AlbumId { get; set; }

    public string Title { get; set; } = null!;

    public int ArtistId { get; set; }
}
