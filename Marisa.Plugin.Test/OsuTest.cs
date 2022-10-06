using System;
using System.IO;
using System.Threading.Tasks;
using Marisa.Plugin.Shared.Osu;
using NUnit.Framework;

namespace Marisa.Plugin.Test;

public class OsuTest
{
    [Test]
    [TestCase(1794551, "1794551 25-ji, Night Code de x Hatsune Miku - Jishou Mushoku.osz")]
    public async Task TestDownloadBeatmap(long beatmapId, string filename)
    {
        if (File.Exists(filename))
        {
            File.Delete(filename);
        }

        await OsuApi.DownloadBeatmap(beatmapId, Environment.CurrentDirectory);

        Assert.IsTrue(File.Exists(Path.Join(Environment.CurrentDirectory, filename)));
    }
}