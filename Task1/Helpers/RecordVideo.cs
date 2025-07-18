using ScreenRecorderLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Helpers
{
    internal class RecordVideo
    {
            private static Recorder recorder;
            private static string outputPath;

        public static void StartRecording(string videoName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
            string folderPath = Path.Combine(projectPath, "Reports", "Videos");
            Directory.CreateDirectory(folderPath);

            outputPath = Path.Combine(folderPath, videoName + ".mp4");

            recorder = Recorder.CreateRecorder();
            recorder.OnRecordingComplete += (s, e) =>
            {
                Console.WriteLine("✅ Ghi video xong tại: " + e.FilePath);
            };

            Console.WriteLine($"📹 Bắt đầu ghi video: {outputPath}");
            recorder.Record(outputPath);
        }

        public static void StopRecording()
        {
            recorder.Stop();
            Console.WriteLine("⏹ Ghi video đã dừng");
            Thread.Sleep(1000); // đảm bảo file được ghi xong
        }

        public static string GetVideoPath()
        {
            return outputPath.Replace("\\", "/");
        }
    }
}
